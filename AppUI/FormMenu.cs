using AppLib;

namespace AppUI;

public partial class FormMenu : Form
{
    private readonly CancellationTokenSource _cancellationTokenSource;
    private readonly CancellationToken _cancellationToken;

    public FormMenu()
    {
        InitializeComponent();

        _cancellationTokenSource = new();
        _cancellationToken = _cancellationTokenSource.Token;

        Load += FormMenu_Load;
    }


    #region Loading Updater

    private async void FormMenu_Load(object? sender, EventArgs e)
    {
        try
        {
            using Loading loading = new(_cancellationTokenSource);

            AddControlToMainPanel(loading);

            SetEnabledStatusOfAllControls(false);

            await Server.StartDatabase(_cancellationToken);

#if DEBUG
            await Server.FulfillFakeData(_cancellationToken);
#endif

            SetEnabledStatusOfAllControls(true);

            AddControlToMainPanel(new SystemPlaceholder());
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

    private void SetEnabledStatusOfAllControls(bool enabled)
    {
        foreach (Control control in PanelSideBar.Controls)
        {
            if (control is not Button button)
                continue;

            button.Enabled = enabled;
        }

        foreach (Control control in MainTableLayoutPanel.Controls)
        {
            if (control is not Button button)
                continue;

            button.Enabled = enabled;
        }
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

    private void ButtonConfigurations_Click(object sender, EventArgs e)
    {
        OpenChildForm<FormConfigurations>();
    }

    private void ButtonEntries_Click(object sender, EventArgs e)
    {

    }

    private void ButtonCategories_Click(object sender, EventArgs e)
    {

    }

    private void ButtonReport_Click(object sender, EventArgs e)
    {

    }

    private void ButtonAbout_Click(object sender, EventArgs e)
    {

    }

    #endregion

    private void AddControlToMainPanel(Control control)
    {
        control.Dock = DockStyle.Fill;

        PanelMainContainer.Controls.Clear();
        PanelMainContainer.Controls.Add(control);
    }

    private void OpenChildForm<T>() where T : Form, new()
    {
        Hide();

        try
        {
            using T form = new();
            form.ShowDialog(this);
        }
        catch (Exception ex)
        {
            UserMessage.ShowError(ex.Message, Level.Unknown);
        }
        finally
        {
            Show();
        }
    }
}