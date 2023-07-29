using AppUI.Properties;

namespace AppUI;

public partial class MainMenu : UserControl
{
    public MainMenu(bool loading)
    {
        InitializeComponent();

        PictureBoxLogo.Image = loading ? Resources.loading_gif : Resources.book_512;

        LabelText.Text = loading ? "Loading..." : "Controle Monetário\r\nMensal";

        PictureBoxLogo.Location = new Point(
            (Width / 2) - (PictureBoxLogo.Width / 2) - 120,
            (Height / 2) - (PictureBoxLogo.Height / 2));

        LabelText.Location = new Point(
            (Width / 2) - (LabelText.Width / 2) + 120,
            (Height / 2) - (LabelText.Height / 2));
    }
}