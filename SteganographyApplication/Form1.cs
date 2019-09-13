using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SteganographyProject
{
    public partial class MainForm : Form
    {
        //Initialize class variables
        private enum hashTypes { NONE, MD5, SHA256};
        //private RSAParameters publicKey;
        //private RSAParameters privateKey;
        private Color[] pixelArray = new Color[0];
        private byte[] encryptedMessage;
        private int bmpWidth = 0;
        private int bmpHeight = 0;
        private int charWidth = 8;
        private CspParameters csp = new CspParameters();
        private RSACryptoServiceProvider rsa;
        private int keySize = 1024;
        private hashTypes selectedHash = hashTypes.NONE;

        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void createKeys(int keySize)
        {
            rsa = new RSACryptoServiceProvider(keySize, csp);
            rsa.PersistKeyInCsp = true;
            //RSAParameters privateKey = rsa.ExportParameters(true);
            //RSAParameters publicKey = rsa.ExportParameters(false);
            
            //this.privateKey = privateKey;
            //this.publicKey = publicKey;
        }

        private Byte[] encryptMessage(byte[] data, bool enablePadding)
        {
            return rsa.Encrypt(data, enablePadding);
        }

        private Byte[] decryptMessage(byte[] data, bool enablePadding)
        {
            return rsa.Decrypt(data, enablePadding);
        }

        private void endProgram()
        {
            this.Close();
        }

        private void loadKey()
        {
            DialogResult result = openImageDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openImageDialog.FileName;

                if (rsa == null)
                {
                    rsa = new RSACryptoServiceProvider(keySize, csp);
                    rsa.PersistKeyInCsp = true;
                }

                using (System.IO.StreamReader privateFileIn = new System.IO.StreamReader(file))
                {
                    rsa.FromXmlString(privateFileIn.ReadToEnd());
                    Console.WriteLine("Loaded Key: " + rsa.ToXmlString(false));
                }

            }
        }

        private void saveKey(bool publicOnly)
        {
            DialogResult result = saveImageDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = saveImageDialog.FileName;

                using (System.IO.StreamWriter privateFileOut = new System.IO.StreamWriter(file))
                    privateFileOut.WriteLine(rsa.ToXmlString(!publicOnly).ToString());
            }
        }

        private void loadKeyClick(object sender, EventArgs e)
        {
            loadKey();
        }

        private void saveKeyClick(object sender, EventArgs e)
        {
            saveKey(false);
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            endProgram();
        }

        private void createKeyClick(object sender, EventArgs e)
        {
            createKeys(keySize);
        }

        private void exportButtonClick(object sender, EventArgs e)
        {
            bool padding = oaepPadding.Checked;
            Console.WriteLine(padding);

            byte[] inputData = Encoding.ASCII.GetBytes(inputTextBox.Text.ToCharArray());
            byte[] encryptedData = encryptMessage(inputData, padding);
            string output = new string(Encoding.ASCII.GetChars(encryptedData));

            encryptedMessage = encryptedData;

            Console.WriteLine(output);
            outputTextBox.Text = output;

            if (rsa.PublicOnly)
                encryptedOutputTextBox.Text = "*** Public Fields Only ***\n*** Decryption Not Possible***";
            else
                encryptedOutputTextBox.Text = new string(Encoding.ASCII.GetChars(decryptMessage(encryptedData, padding)));


            //Confirm that we have enpough space to encode the message
            if (pixelArray.Length < encryptedMessage.Length)
            {
                MessageBox.Show("Message to large for target image.", "Encoding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Encode the message
            else
            {
                short messageSize = (short)encryptedMessage.Length;
                byte[] msgSizeEncoded = { (byte)(messageSize >> 8), (byte)messageSize, 0xAA };

                encodePixelArray(0, pixelArray, msgSizeEncoded);
                encodePixelArray(24, pixelArray, encryptedMessage);

                //for (int i = 0; i < encryptedMessage.Length; i++)
                //{
                //pixelArray[i] = Color.FromArgb(pixelArray[i].A, encryptedMessage[i], pixelArray[i].G, pixelArray[i].B);
                //}
            }

            //Export pixel array
            Bitmap bmpImg = new Bitmap(bmpWidth, bmpHeight);

            DialogResult result = saveImageDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {

                string file = saveImageDialog.FileName;
                for (int i = 0; i < pixelArray.Length; i++)
                {
                    bmpImg.SetPixel(i % bmpImg.Width, i / bmpImg.Width, pixelArray[i]);
                }

                bmpImg.Save(file);
            }
        }

        private void decodeMessageButtonClick(object sender, EventArgs e)
        {
            bool padding = oaepPadding.Checked;
            int messageSize = (((int)decodeByte(0)) << 8) + ((int)decodeByte(1));
            int hash = (int)decodeByte(2);            

            if (rsa != null)
            {
                byte[] message = new byte[messageSize];

                for (int i = 0; i < messageSize; i++)
                    message[i] = decodeByte(3 + i);

                if (rsa.PublicOnly)
                    encryptedOutputTextBox.Text = "*** Public Fields Only ***\n*** Decryption Not Possible***";
                else
                    encryptedOutputTextBox.Text = new string(Encoding.ASCII.GetChars(decryptMessage(message, padding)));
            }
            else
            {
                MessageBox.Show("No keys loaded for image decryption.", "Decoding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadImageButtonClick(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openImageDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openImageDialog.FileName;
                try
                {
                    pictureBox1.Image = Image.FromFile(openImageDialog.FileName);

                    using (Bitmap bmpImg = new Bitmap(pictureBox1.Image))
                    {
                        bmpWidth = bmpImg.Width;
                        bmpHeight = bmpImg.Height;

                        pixelArray = new Color[(bmpImg.Width * bmpImg.Height)];
                        for (int y = 0; y < bmpImg.Height; y++)
                        {
                            for (int x = 0; x < bmpImg.Width; x++)
                            {
                                pixelArray[(y * bmpImg.Width) + x] = bmpImg.GetPixel(x, y);
                            }
                        }
                    }

                    pictureBox1.Refresh();
                    pictureBox1.Invalidate();
                }
                catch (IOException)
                {
                }
            }
            System.Console.WriteLine(result); // <-- For debugging use.
        }

        private void encodePixelArray(int bitOffset, Color[] pixelArray, byte[] message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                byte character = message[i];
                int offset = (i * charWidth) + bitOffset;
                Console.WriteLine("Encoding byte: " + character + " at index: " + offset);

                for (int p = 0; p < charWidth; p++)
                {
                    int mask = 128 / (int)(Math.Pow(2, p));
                    Console.WriteLine("Encoding bit: " + ((character & mask) != 0 ? "0x" + mask : "0") + " at index: " + (offset + p));

                    if ((character & mask) != 0)
                    {
                        pixelArray[offset + p] = encodeOdd(pixelArray[offset + p]);
                    }
                    else
                    {
                        pixelArray[offset + p] = encodeEven(pixelArray[offset + p]);
                    }
                }
            }
        }

        private Color encodeOdd(Color c) {
            //return Color.FromArgb(c.A, ((c.R % 2 == 1) ? c.R : c.R - 1), c.G, c.B);
            return Color.FromArgb(c.A, 255, 0, 0);
        }

        private Color encodeEven(Color c) {
            //return Color.FromArgb(c.A, ((c.R % 2 == 0) ? c.R : c.R - 1), c.G, c.B);
            return Color.FromArgb(c.A, 0, 0, 255);
        }

        public bool decodePixel(Color c)
        {
            return c.B == 0 && c.R == 255;
        }

        public byte decodeByte(int index)
        {
            return decodeByte(index, pixelArray);
        }

        public byte decodeByte(int index, Color[] pixelArray)
        {
            int val = 0;
            for (int bit = 0; bit < 8; bit++)
            {
                int mask = 128 / (int)(Math.Pow(2, bit));

                val += ((decodePixel(pixelArray[(index * 8) + bit])) ? mask : 0);
            }

            return (byte)val;
        }

        private void createKeyPairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createKeys(keySize);
        }

        private void loadPrivateKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadKey();
        }
        
        private void exportPublicKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveKey(true);
        }

        private void saveKeyPairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveKey(false);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            endProgram();
        }

        private void noHash_CheckedChanged(object sender, EventArgs e)
        {
            selectedHash = hashTypes.NONE;
        }

        private void md5Hash_CheckedChanged(object sender, EventArgs e)
        {
            selectedHash = hashTypes.MD5;
        }

        private void sha256Hash_CheckedChanged(object sender, EventArgs e)
        {
            selectedHash = hashTypes.SHA256;
        }
    }
}
