namespace AppUI;

public partial class Menu : Form, IUserInterfaceUpdater
{
    private Button? _activeButton;
    public Menu()
    {
        InitializeComponent();

        UpdateUserInterface();

        ReturnToMainMenu();
    }

    #region Button Style

    private void OpenChildForm(UserControl control, Button button)
    {
        if (button.Equals(_activeButton))
            return;

        ButtonMainMenu.Visible = true;

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

        _activeButton.FlatAppearance.BorderSize = 2;
        _activeButton.BackColor = UIConfig.MidColor;
        _activeButton.Font = new Font(_activeButton.Font.FontFamily, _activeButton.Font.Size, FontStyle.Bold);
    }

    private void DeactivateButton()
    {
        if (_activeButton is null)
            return;

        _activeButton.FlatAppearance.BorderSize = 0;
        _activeButton.BackColor = Color.Transparent;
        _activeButton.Font = new Font(_activeButton.Font.FontFamily, _activeButton.Font.Size, FontStyle.Regular);

        _activeButton = null;
    }

    private void ReturnToMainMenu()
    {
        DeactivateButton();
        OpenChildForm(new MainMenu(), ButtonMainMenu);
        ButtonMainMenu.Visible = false;
    }

    #endregion

    private void Menu_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
            Application.Exit();
    }

    #region Buttons Events

    private void ButtonMainMenu_Click(object sender, EventArgs e)
    {
        LabelTitle.Text = "Início";
        ReturnToMainMenu();
    }

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
        OpenChildForm(new Configurations(), (Button)sender);
    }

    private void ButtonInsertEntry_Click(object sender, EventArgs e)
    {
        LabelTitle.Text = "Adicionar Entrada";
        OpenChildForm(new FormInsertEntry(), (Button)sender);
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