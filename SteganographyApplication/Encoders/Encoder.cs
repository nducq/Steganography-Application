using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography;

namespace SteganographyProject
{
    abstract class Encoder
    {
        protected static int charWidth = 8;

        public static Color[] encodeMessage(Color[] pixelArray, Byte[] message)
        {
            return pixelArray;
        }

        public static Byte[] decodeMessage(Color[] pixelArray)
        {
            return new byte[0];
        }

        public static void setCharWidth(int charWidth)
        {
            Encoder.charWidth = charWidth;
        }

        protected static Byte[] computeHash(Byte[] message, hashTypes selectedHash)
        {
            Byte[] hash = new Byte[0]; 
            switch(selectedHash)
            {
                case hashTypes.NONE:
                    break;
                case hashTypes.MD5:
                    MD5 md5Hash = MD5.Create();
                    hash = md5Hash.ComputeHash(message);
                    break;
                case hashTypes.SHA256:
                    SHA256 sha256 = SHA256.Create();
                    hash = sha256.ComputeHash(message);
                    break;
                case hashTypes.SHA512:
                    SHA512 sha512 = SHA512.Create();
                    hash = sha512.ComputeHash(message);
                    break;
            }

            return hash;
        }
    }
}
