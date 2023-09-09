using AppUI.Properties;

namespace AppUI;

public partial class SystemPlaceholder : UserControl
{
    public SystemPlaceholder()
    {
        InitializeComponent();

        PictureBoxLogo.Image = Resources.book_512;

        LabelText.Text = "Monetary Monthly\r\nControl System";

        PictureBoxLogo.Location = new Point(
            (Width / 2) - (PictureBoxLogo.Width / 2) - 120,
            (Height / 2) - (PictureBoxLogo.Height / 2));

        LabelText.Location = new Point(
            (Width / 2) - (LabelText.Width / 2) + 120,
            (Height / 2) - (LabelText.Height / 2));
    }
}