using AppLib;
using AppUI.Util;

namespace AppUI;

public partial class FormMenu : Form
{
    private readonly CancellationTokenSource _cancellationTokenSource;
    private readonly CancellationToken _cancellationToken;

    public FormMenu()
    {
        InitializeComponent();

        ButtonConfigurations.Click += ButtonConfigurations_Click;
        ButtonEntries.Click += ButtonEntries_Click;
        ButtonCategories.Click += ButtonCategories_Click;
        ButtonReport.Click += ButtonReport_Click;
        ButtonAbout.Click += ButtonAbout_Click;

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


    #region Left Ribbon Buttons Events

    private void ButtonConfigurations_Click(object? sender, EventArgs e)
    {
        OpenChildForm<FormConfigurations>();
    }

    private void ButtonEntries_Click(object? sender, EventArgs e)
    {

    }

    private void ButtonCategories_Click(object? sender, EventArgs e)
    {
        OpenChildForm<FormCategories>();
    }

    private void ButtonReport_Click(object? sender, EventArgs e)
    {

    }

    private void ButtonAbout_Click(object? sender, EventArgs e)
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