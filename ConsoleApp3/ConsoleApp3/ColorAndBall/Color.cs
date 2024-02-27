using System;

namespace ConsoleApp3.ColorAndBall
{
    public class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }

        public Color(byte red, byte green, byte blue, byte alpha=255)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public float GetGrayScale()
        {
            float ave = Convert.ToByte((Red + Green + Blue) / 3);
            return ave;
        }
    }
}