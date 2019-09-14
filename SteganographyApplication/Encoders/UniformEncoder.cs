using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SteganographyProject.Encoders
{
    class UniformEncoder : Encoder
    {
        new public static Color[] encodeMessage(Color[] pixelArray, Byte[] message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                byte character = message[i];
                int offset = (i * charWidth);
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
            return pixelArray;
        }

        //Encodes an odd bit
        private static Color encodeOdd(Color c)
        {
            //return Color.FromArgb(c.A, ((c.R % 2 == 1) ? c.R : c.R - 1), c.G, c.B);
            return Color.FromArgb(c.A, ((c.R / 2) * 2) + 1, c.G, c.B);
        }

        //Encodes an even bit
        private static Color encodeEven(Color c)
        {
            //return Color.FromArgb(c.A, ((c.R % 2 == 0) ? c.R : c.R - 1), c.G, c.B);
            return Color.FromArgb(c.A, (c.R / 2) * 2, c.G, c.B);
        }

        new public static Byte[] decodeMessage(Color[] pixelArray)
        {
            //bool padding = oaepPadding.Checked;
            int messageSize = (((int)decodeByte(0, pixelArray)) << 8) + ((int)decodeByte(1, pixelArray));
            Byte[] message = new byte[messageSize];

            int hash = (int)decodeByte(2, pixelArray);
            for (int i = 0; i < messageSize; i++)
                message[i] = decodeByte(3 + i, pixelArray);

            return message;
        }

        //Decodes a bit, returning 'true' if it is odd or 'false' if it is even
        private static bool decodePixel(Color c)
        {
            return (c.R % 2) == 1;
        }

        //Decodes 8 bits, returning a full byte
        private static byte decodeByte(int index, Color[] pixelArray)
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
