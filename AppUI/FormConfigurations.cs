using AppLib;
using AppUI.Util;

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

        Load += Form_Load;

        FormClosing += Form_FormClosing;
    }

    private void Form_FormClosing(object? sender, FormClosingEventArgs e)
    {
        const string message = "Do you want to discard the edits and exit?";

        if (!UserMessage.ShowQuestionUserYes(message))
            e.Cancel = true;
    }

    private async void Form_Load(object? sender, EventArgs e)
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


    #region Buttons Events

    private void ButtonReturn_Click(object sender, EventArgs e)
    {
        FormClosing -= Form_FormClosing;

        Close();
    }

    #endregion
}