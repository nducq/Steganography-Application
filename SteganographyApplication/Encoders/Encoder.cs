using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
    }
}
