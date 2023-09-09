using AppUI.Util;

namespace AppUI;

public partial class FormBase : Form
{
    private readonly CancellationTokenSource _cancellationTokenSource;
    private readonly CancellationToken _token;

    public FormBase()
    {
        InitializeComponent();

        _cancellationTokenSource = new();
        _token = _cancellationTokenSource.Token;

        Load += Form_Load;
    }

    private async void Form_Load(object? sender, EventArgs e)
    {
        try
        {
            using Loading loading = await Loading.DockOnParentForm(this, _cancellationTokenSource);


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

    #region Buttons Events

    private void ButtonReturn_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}