using AppLib;
using AppUI.Pages;

namespace AppUI;

public partial class FormMenu : Form
{
    private readonly CancellationTokenSource _cancellationTokenSource;
    private readonly CancellationToken _cancellationToken;
    private Button _activeButton;

    public FormMenu()
    {
        InitializeComponent();

        _cancellationTokenSource = new();
        _cancellationToken = _cancellationTokenSource.Token;

        Load += FormMenu_Load;

        _activeButton = ButtonMainMenu;
        ReturnToMainMenu();
    }


    #region Loading Updater

    private async void FormMenu_Load(object? sender, EventArgs e)
    {
        try
        {
            SetLoadingBehavior(true);

            await Server.StartDatabase(_cancellationToken);

#if DEBUG
            await Server.FulfillFakeData(_cancellationToken);
#endif

            SetLoadingBehavior(false);
        }
        catch (Exception ex)
        {
            UserMessage.ShowError($"""
                {ex.Message}
                Inner Exception: {ex.InnerException?.Message}
                """, Level.FatalError);
            Close();
        }
    }
    private void SetLoadingBehavior(bool loading)
    {
        foreach (Control control in PanelSideBar.Controls)
        {
            if (control is not Button button)
                continue;

            button.Enabled = !loading;
        }

        foreach (Control control in MainTableLayoutPanel.Controls)
        {
            if (control is not Button button)
                continue;

            button.Enabled = !loading;
        }

        AddControlToMainPanel(new MainMenuPlaceholderControl(_cancellationTokenSource, loading));
    }

    #endregion


    #region Drag Move Window

    [System.Runtime.InteropServices.LibraryImport("user32.dll", EntryPoint = "SendMessageA")]
    internal static partial int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [System.Runtime.InteropServices.LibraryImport("user32.dll")]
    [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
    internal static partial bool ReleaseCapture();

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


    #region Button Style

    public void OpenChildForm(UserControl control, Button button)
    {
        if (button.Equals(_activeButton))
            return;

        LabelTitle.Text = button.Text;
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
        _activeButton.FlatAppearance.BorderSize = 2;
        _activeButton.Font = new Font(_activeButton.Font.FontFamily, _activeButton.Font.Size, FontStyle.Bold);
    }
    private void DeactivateButton()
    {
        _activeButton.FlatAppearance.BorderSize = 0;
        _activeButton.BackColor = Color.Transparent;
        _activeButton.Font = new Font(_activeButton.Font.FontFamily, _activeButton.Font.Size, FontStyle.Regular);
    }
    private void ReturnToMainMenu()
    {
        DeactivateButton();
        OpenChildForm(new MainMenuPlaceholderControl(_cancellationTokenSource), ButtonMainMenu);
        ButtonMainMenu.Visible = false;
    }

    #endregion


    #region Upper Ribbon Buttons Events

    private void ButtonMinimize_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }
    private void ButtonMaximize_Click(object sender, EventArgs e)
    {
        bool normal = WindowState == FormWindowState.Normal;
        WindowState = normal ? FormWindowState.Maximized : FormWindowState.Normal;
    }
    private void ButtonClose_Click(object sender, EventArgs e)
    {
        _cancellationTokenSource.Cancel();
        Application.Exit();
    }

    #endregion


    #region Left Ribbon Buttons Events

    private void ButtonMainMenu_Click(object sender, EventArgs e)
    {
        ReturnToMainMenu();
    }
    private void ButtonConfigurations_Click(object sender, EventArgs e)
    {
        //Button button = (Button)sender;
        //LabelTitle.Text = button.Text;
        //OpenChildForm(new Configurations(), button);
    }
    private void ButtonEntries_Click(object sender, EventArgs e)
    {
        OpenChildForm(new EntriesControl(), (Button)sender);
    }
    private void ButtonCategories_Click(object sender, EventArgs e)
    {
        OpenChildForm(new CategoriesControl(this), (Button)sender);
    }
    private void ButtonReport_Click(object sender, EventArgs e)
    {
        OpenChildForm(new ReportControl(), (Button)sender);
    }

    #endregion
}