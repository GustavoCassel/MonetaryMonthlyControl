using AppUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI;

internal enum Language
{
    English,
    PortugueseBrazil
}
internal enum Theme
{
    Light,
    Dark
}

internal static class UIConfig
{
    public static Color BackColor { get; private set; }
    public static Color ForeColor { get; private set; }
    public static Color MidColor { get; private set; }
    public static Color MouseOverColor { get; private set; }
    public static Color MouseDownColor { get; private set; }

    public static Language Language { get; private set; }
    public static Theme Theme { get; private set; }

    public static void SetTheme(Theme theme)
    {
        if (Theme == theme)
            return;

        Theme = theme;
        switch (Theme)
        {
            case Theme.Dark:
                SetDarkThemeColors();
                break;

            case Theme.Light:
                SetLightThemeColors();
                break;

            default:
                throw new NotImplementedException();
        }
    }

    private static void SetLightThemeColors()
    {
        BackColor = Color.FromArgb(236, 242, 255);
        ForeColor = Color.Black;
        MidColor = Color.FromArgb(142, 167, 233);
        MouseOverColor = Color.FromArgb(176, 218, 255);
        MouseDownColor = Color.FromArgb(25, 167, 206);
    }

    private static void SetDarkThemeColors()
    {
        BackColor = Color.FromArgb(10, 38, 71);
        ForeColor = Color.White;
        MidColor = Color.FromArgb(20, 66, 114);
        MouseOverColor = Color.FromArgb(32, 82, 149);
        MouseDownColor = Color.FromArgb(73, 66, 228);
    }

    public static void UpdateStyles(Control.ControlCollection controlCollection)
    {
        foreach (var obj in controlCollection)
        {
            if (obj is Control control)
                RecursiveControls(control);
        }
    }

    private static void RecursiveControls(Control control)
    {
        foreach (var childControl in control.Controls)
        {
            if (childControl is Button button)
            {
                button.BackColor = BackColor;
                button.ForeColor = ForeColor;

                button.FlatAppearance.MouseOverBackColor = MouseOverColor;
                button.FlatAppearance.MouseDownBackColor = MouseDownColor;
            }

            if (childControl is Panel panel)
            {
                panel.BackColor = Color.Transparent;
            }

            if (childControl is Label label)
            {
                label.BackColor = Color.Transparent;
                label.ForeColor = ForeColor;
            }

            if (childControl is Control control1)
                RecursiveControls(control1);
        }
    }
}