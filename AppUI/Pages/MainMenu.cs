using System.Globalization;

namespace AppUI;

public partial class MainMenu : UserControl
{
    public MainMenu()
    {
        InitializeComponent();

        PictureBoxLogo.Location = new Point(
            (Width / 2) - (PictureBoxLogo.Width / 2) - 120,
            (Height / 2) - (PictureBoxLogo.Height / 2));

        LabelText.Location = new Point(
            (Width / 2) - (LabelText.Width / 2) + 120,
            (Height / 2) - (LabelText.Height / 2));
    }
}