using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetaryMonthlyControl
{
    public sealed class ThemeManager
    {
        public Color PrimaryColor { get; private set; }
        public Color SecondaryColor { get; private set; }
        
        public void ChangeColor(Color color)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            double correctionFactor = -0.35d;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor++;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            PrimaryColor = color;
            SecondaryColor = Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}