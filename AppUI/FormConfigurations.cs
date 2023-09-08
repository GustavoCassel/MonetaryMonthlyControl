using AppLib;
using AppUI.Pages;

namespace AppUI;

public partial class FormConfigurations : Form
{
    public FormConfigurations()
    {
        InitializeComponent();
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

    }

    #endregion
}