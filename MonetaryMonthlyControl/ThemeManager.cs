using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonetaryMonthlyControl
{
    public sealed class ThemeManager
    {
        public Color PrimaryBackColor { get; private set; }
        public Color DarkerBackColor { get; private set; }
        public Color LighterBackColor { get; private set; }
        public Color MainBackGroundColor { get; private set; }
        public Color GeneralForeColor { get; private set; }

        private readonly Color _darkThemeBackColor;
        private readonly Color _lightThemeBackColor;
        public ThemeManager()
        {
            //_darkThemeBackColor = Color.FromArgb(55, 71, 79);
            _lightThemeBackColor = Color.FromArgb(222, 228, 231);

            _darkThemeBackColor = Color.FromArgb(38, 50, 56);
            //_lightThemeBackColor = Color.FromArgb(255, 255, 255);

            SetTheme(true); // Dark Theme By Default
        }

        public void SetTheme(bool darkTheme)
        {
            const double Factor = 0.35d;

            GeneralForeColor = darkTheme ? Color.White : Color.Black;
            PrimaryBackColor = darkTheme ? _darkThemeBackColor : _lightThemeBackColor;
            MainBackGroundColor = GetColorAndChangeBrightness(PrimaryBackColor, Factor + 0.2d);
            DarkerBackColor = GetColorAndChangeBrightness(PrimaryBackColor, -Factor);
            LighterBackColor = GetColorAndChangeBrightness(PrimaryBackColor, Factor);
        }

        private static Color GetColorAndChangeBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

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

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}