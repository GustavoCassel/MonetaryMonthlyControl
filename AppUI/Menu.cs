using AppUI.Properties;
using System.Diagnostics;
using System.Reflection;

namespace AppUI;

public partial class Menu : Form, IUserInterfaceUpdater
{
    private Button? _activeButton = null;
    public Menu()
    {
        InitializeComponent();
        UIConfig.SetTheme(Theme.Dark);
        UpdateUserInterface();

        FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
        LabelVersion.Text = $"Versão: {fvi.FileVersion}";
    }

    #region Button Style

    private void OpenChildForm(UserControl control, object? sender)
    {
        if (sender is not Button button)
            return;

        if (button.Equals(_activeButton))
            return;

        DeactivateButton();

        _activeButton = button;

        ActivateButton();

        control.Dock = DockStyle.Fill;

        PanelMainContainer.Controls.Clear();
        PanelMainContainer.Controls.Add(control);

        UpdateUserInterface();
    }

    private void ActivateButton()
    {
        if (_activeButton is null)
            return;

        _activeButton.Font = new Font(_activeButton.Font.FontFamily, _activeButton.Font.Size, FontStyle.Bold);
    }

    private void DeactivateButton()
    {
        if (_activeButton is null)
            return;

        _activeButton.BackColor = Color.Transparent;
        _activeButton.Font = new Font(_activeButton.Font.FontFamily, _activeButton.Font.Size, FontStyle.Regular);

        _activeButton = null;
    }

    private void ReturnToHomeScreen(object sender, EventArgs e)
    {
        if (_activeButton is null)
            return;

        PanelMainContainer.Controls.Clear();

        PictureBox pictureBox = new()
        {
            Size = new Size(128, 128),
            Image = Resources.book_512,
            Visible = true

        };

        pictureBox.Location = new Point(
            (PanelMainContainer.Width - pictureBox.Width) / 2,
            (PanelMainContainer.Height - pictureBox.Height) / 2);

        PanelMainContainer.Controls.Add(pictureBox);
        DeactivateButton();
    }

    #endregion

    private void Menu_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
            Application.Exit();
    }

    #region Buttons Events

    private void ButtonClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void ButtonMaximize_Click(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Normal)
            WindowState = FormWindowState.Maximized;
        else
            WindowState = FormWindowState.Normal;
    }

    private void ButtonMinimize_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void ButtonConfigurations_Click(object sender, EventArgs e)
    {
        LabelTitle.Text = "Configurações";
        OpenChildForm(new Configurations(), sender);
    }

    private void PanelWindowButtons_MouseDown(object sender, MouseEventArgs e)
    {
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            foreach (Screen screen in Screen.AllScreens)
            {
                if (Location.Y == screen.Bounds.Y)
                    WindowState = FormWindowState.Maximized;
            }
        }
    }

    public void UpdateUserInterface()
    {
        BackColor = UIConfig.BackColor;
        PanelWindowButtons.BackColor = UIConfig.MidColor;
        UIConfig.UpdateStyles(Controls);
    }

    #endregion

    #region Drag Move Window

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    internal static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [System.Runtime.InteropServices.LibraryImport("user32.dll")]
    [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
    internal static partial bool ReleaseCapture();

    #endregion

}