using AppLib;

namespace AppUI;

public partial class FormMenu : Form
{
    private readonly CancellationTokenSource _cancellationTokenSource;
    private readonly CancellationToken _cancellationToken;
    private Button? _activeButton;
    public FormMenu()
    {
        InitializeComponent();

        _cancellationTokenSource = new();
        _cancellationToken = _cancellationTokenSource.Token;
        Shown += FormMenu_Load;

        AddControlToMainPanel(new MainMenu(true));
    }

    private async void FormMenu_Load(object? sender, EventArgs e)
    {
        try
        {
            await LocalDbManager.CheckLocalDBInstance(_cancellationToken);

            await DatabaseManager.ConfigureEntireDatabase(_cancellationToken);

            await Task.Delay(1000);
        }
        catch (Exception ex)
        {
            UserMessage.ShowError($"""
                An unexpected error occurred!
                Error Message: {ex.Message}
                """, Level.Unknown);
            Close();
            return;
        }

        AddControlToMainPanel(new MainMenu(false));
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

        AddControlToMainPanel(control);
    }

    private void AddControlToMainPanel(UserControl control)
    {
        control.Dock = DockStyle.Fill;

        PanelMainContainer.Controls.Clear();
        PanelMainContainer.Controls.Add(control);
    }

    private void ActivateButton()
    {
        if (_activeButton is null)
            return;

        _activeButton.FlatAppearance.BorderSize = 2;
        //_activeButton.BackColor = UIConfig.MidColor;
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
        OpenChildForm(new MainMenu(false), ButtonMainMenu);
        ButtonMainMenu.Visible = false;
    }

    #endregion

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
        //OpenChildForm(new Configurations(), (Button)sender);
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

    #endregion

    #region Drag Move Window

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    internal static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [System.Runtime.InteropServices.LibraryImport("user32.dll")]
    [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
    internal static partial bool ReleaseCapture();

    #endregion
}