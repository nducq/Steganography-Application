using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SteganographyProject.Encoders
{
    class UniformEncoder : Encoder
    {
        new public static Color[] encodeMessage(Color[] pixelArray, Byte[] message, hashTypes selectedHash)
        {
            encodeByte(0, (byte)((message.Length >> 8) & 0xFF), pixelArray);
            encodeByte(1, (byte)((message.Length) & 0xFF), pixelArray);
            encodeByte(2, 0xAA, pixelArray);

            //Compute the message hash
            Byte[] hash = computeHash(message, selectedHash);
            encodeByteArray(3, hash, pixelArray);

            encodeByteArray(3 + hash.Length, message, pixelArray);

            return pixelArray;
        }

        new public static Byte[] decodeMessage(Color[] pixelArray, hashTypes selectedHash)
        {
            //bool padding = oaepPadding.Checked;
            int messageSize = (((int)decodeByte(0, pixelArray)) << 8) + ((int)decodeByte(1, pixelArray));
            Byte[] message = new byte[messageSize];

            //int hash = (int)decodeByte(2, pixelArray);
            int hashSize = 0;

            //Compute the size of the hash
            switch (selectedHash)
            {
                case hashTypes.MD5:
                    hashSize = 16;
                    break;
                case hashTypes.SHA256:
                    hashSize = 32;
                    break;
                case hashTypes.SHA512:
                    hashSize = 64;
                    break;
            }

            Byte[] hash = decodeByteArray(3, hashSize, pixelArray);

            message = decodeByteArray(3 + hashSize, messageSize, pixelArray);

            if(!compareHashes(hash, computeHash(message, selectedHash)))
                MessageBox.Show("Hashes do not match!", "Decoding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return message;
        }

        //Encodes an array of bytes 
        protected static void encodeByteArray(int index, Byte[] array, Color[] pixelArray)
        {
            for(int i = 0; i < array.Length; i++) {
                encodeByte(index + i, array[i], pixelArray);
            }
        }

        //Encodes 8 bits
        protected static void encodeByte(int index, byte character, Color[] pixelArray)
        {
            for (int p = 0; p < charWidth; p++)
            {
                int mask = 128 / (int)(Math.Pow(2, p));
                Console.WriteLine("Encoding bit: " + ((character & mask) != 0 ? "0x" + mask : "0") + " at index: " + ((index * 8) + p));

                if ((character & mask) != 0)
                {
                    pixelArray[(index * 8) + p] = encodeOdd(pixelArray[(index * 8) + p]);
                }
                else
                {
                    pixelArray[(index * 8) + p] = encodeEven(pixelArray[(index * 8) + p]);
                }
            }
        }

        //Encodes an odd bit
        protected static Color encodeOdd(Color c)
        {
            //return Color.FromArgb(c.A, ((c.R % 2 == 1) ? c.R : c.R - 1), c.G, c.B);
            return Color.FromArgb(c.A, ((c.R / 2) * 2) + 1, c.G, c.B);
        }

        //Encodes an even bit
        protected static Color encodeEven(Color c)
        {
            //return Color.FromArgb(c.A, ((c.R % 2 == 0) ? c.R : c.R - 1), c.G, c.B);
            return Color.FromArgb(c.A, (c.R / 2) * 2, c.G, c.B);
        }

        //Decodes a bit, returning 'true' if it is odd or 'false' if it is even
        protected static bool decodePixel(Color c)
        {
            return (c.R % 2) == 1;
        }

        //Decodes an array of bytes
        protected static Byte[] decodeByteArray(int index, int size, Color[] pixelArray)
        {
            Byte[] ret = new byte[size];

            for (int i = 0; i < size; i++)
            {
                ret[i] = decodeByte(index + i, pixelArray);
            }

            return ret;
        }

        //Decodes 8 bits, returning a full byte
        protected static byte decodeByte(int index, Color[] pixelArray)
        {
            int val = 0;
            for (int bit = 0; bit < 8; bit++)
            {
                int mask = 128 / (int)(Math.Pow(2, bit));

                val += ((decodePixel(pixelArray[(index * 8) + bit])) ? mask : 0);
            }

            return (byte)val;
        }
    }
}
