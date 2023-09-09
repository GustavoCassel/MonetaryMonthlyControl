using AppLib;

namespace AppUI;

public partial class FormConfigurations : Form
{
    private readonly CancellationTokenSource _cancellationTokenSource;
    private readonly CancellationToken _token;

    private Configurations? _configurations;
    public FormConfigurations()
    {
        InitializeComponent();

        _cancellationTokenSource = new();
        _token = _cancellationTokenSource.Token;

        Load += FormConfigurations_Load;

        FormClosing += FormConfigurations_FormClosing;
    }

    private void FormConfigurations_FormClosing(object? sender, FormClosingEventArgs e)
    {
        const string message = "Do you want to discard the edits and exit?";

        if (!UserMessage.ShowQuestionUserYes(message))
            e.Cancel = true;
    }

    private async void FormConfigurations_Load(object? sender, EventArgs e)
    {
        try
        {
            using Loading loading = await Loading.DockOnParentForm(this, _cancellationTokenSource);

            await LoadDependenciesAsync();

            SetValues();
        }
        catch (TaskCanceledException ex)
        {
            Hide();
            UserMessage.ShowError(ex.Message, Level.Success);
            Close();
        }
        catch (Exception ex)
        {
            Hide();
            UserMessage.ShowError($"""
                An unknown error occurred!
                Error message: {ex.Message}
                """, Level.Unknown);
            Close();
        }
    }

    private void SetValues()
    {
        Theme[] themes = Enum.GetValues<Theme>();
        foreach (Theme theme in themes)
            ComboBoxThemes.Items.Add(theme);

        ComboBoxThemes.SelectedItem = _configurations!.ActiveTheme;

        Language[] languages = Enum.GetValues<Language>();
        foreach (Language language in languages)
            ComboBoxLanguages.Items.Add(language);

        ComboBoxLanguages.SelectedItem = _configurations!.ActiveLanguage;
    }

    private async Task LoadDependenciesAsync()
    {
        _configurations = await ConfigurationsManager.GetConfigurationAsync(_token);
    }

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
        Close();
    }

    #endregion


    #region Buttons Events

    private void ButtonReturn_Click(object sender, EventArgs e)
    {
        FormClosing -= FormConfigurations_FormClosing;

        Close();
    }

    #endregion
}