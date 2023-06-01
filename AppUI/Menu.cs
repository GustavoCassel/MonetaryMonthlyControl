using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace AppUI;

public partial class Menu : Form
{
    private Button? _activeButton = null;
    public Menu()
    {
        InitializeComponent();
        FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
        LabelVersion.Text = $"Versão: {fvi.FileVersion}";
        PanelWindowButtons.MouseDown += Drag_MouseDownEvent;

        button1.Click += ButtonCick;
        button2.Click += ButtonCick;
        button3.Click += ButtonCick;
        button4.Click += ButtonCick;
    }

    private void ButtonCick(object? sender, EventArgs e)
    {
        OpenChildForm(new Template(), sender);
    }

    #region Button Style

    private void OpenChildForm(UserControl control, object? sender)
    {
        if (sender is not Button button)
            return;

        if (button.Equals(_activeButton))
            return;

        DeactivateButton();

        _activeButton = button;

        ActivateButton();

        PanelMainContainer.Controls.Clear();
        PanelMainContainer.Controls.Add(control);
    }

    private void ActivateButton()
    {
        if (_activeButton is null)
            return;

        _activeButton.BackColor = ThemeManager.ClickColor;
        _activeButton.Font = new Font(_activeButton.Font.FontFamily, _activeButton.Font.Size, FontStyle.Bold);
    }

    private void DeactivateButton()
    {
        if (_activeButton is null)
            return;

        _activeButton.BackColor = Color.Transparent;
        _activeButton.Font = new Font(_activeButton.Font.FontFamily, _activeButton.Font.Size, FontStyle.Regular);

        _activeButton = null;
    }

    private void ReturnToHomeScreen(object sender, EventArgs e)
    {
        DeactivateButton();
    }

    #endregion

    #region Drag Move Window

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    internal static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [System.Runtime.InteropServices.LibraryImport("user32.dll")]
    [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
    internal static partial bool ReleaseCapture();

    private void Drag_MouseDownEvent(object? sender, MouseEventArgs e)
    {
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            // Drag to top to maximize
            if (Location.Y <= 0)
            {
                WindowState = FormWindowState.Maximized;
            }
        }
    }

    #endregion

    private void Menu_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
            Application.Exit();
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

}
