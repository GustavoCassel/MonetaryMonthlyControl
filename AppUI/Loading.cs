namespace AppUI;

public partial class Loading : UserControl
{
    private readonly CancellationTokenSource _cancellationTokenSource;
    public Loading(CancellationTokenSource cancellationTokenSource)
    {
        InitializeComponent();
        _cancellationTokenSource = cancellationTokenSource;
    }

    public void Close()
    {
        Dispose();
        GC.WaitForPendingFinalizers();
    }

    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        if (_cancellationTokenSource.IsCancellationRequested)
            return;

        _cancellationTokenSource.Cancel();
    }

    public async Task Log(string log)
        => await Task.Run(delegate
        {
            void method()
            {
                LabelLoading.Text = log;
            }

            Invoke(method);
        });

    public async static Task<Loading> DockOnParentForm(Form parent, CancellationTokenSource cancellationTokenSource)
        => await Task.Run(delegate
        {
            Loading loading = new(cancellationTokenSource)
            {
                BackColor = parent.BackColor,
                Visible = true,
                Anchor = AnchorStyles.None,
            };

            void method()
            {
                parent.Controls.Add(loading);

                loading.BringToFront();

                loading.Dock = DockStyle.Fill;
            }

            parent.Invoke(method);

            return loading;
        });
}