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
    public Menu()
    {
        InitializeComponent();
        FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
        LabelVersion.Text = $"Versão: {fvi.FileVersion}";

        //MouseDown += Menu_MouseDown;
        SetStyle(ControlStyles.ResizeRedraw, true);
    }
    /*
    #region teste

    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    private void Menu_MouseDown(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    #endregion
    */



    /*protected override void OnPaint(PaintEventArgs e)
    {
        Rectangle rc = new(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
        ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
    }*/

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




    /*protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.FillRectangle(Brushes.Transparent, Top);
        e.Graphics.FillRectangle(Brushes.Transparent, Left);
        e.Graphics.FillRectangle(Brushes.Transparent, Right);
        e.Graphics.FillRectangle(Brushes.Transparent, Bottom);
    }*/

    private enum Border
    {
        Left = 10,
        Right = 11,
        Top = 12,
        TopLeft = 13,
        TopRight = 14,
        Bottom = 15,
        BottomLeft = 16,
        BottomRight = 17
    }

    private const int ResizeBorderWidth = 15;
    private const int cGrip = 16;      // Grip size
    private const int cCaption = 32;   // Caption bar height;

    private new Rectangle Top => new(0, 0, ClientSize.Width, ResizeBorderWidth);
    private new Rectangle Left => new(0, 0, ResizeBorderWidth, ClientSize.Height);
    private new Rectangle Bottom => new(0, ClientSize.Height - ResizeBorderWidth, ClientSize.Width, ResizeBorderWidth);
    private new Rectangle Right => new(ClientSize.Width - ResizeBorderWidth, 0, ResizeBorderWidth, ClientSize.Height);
    private static Rectangle TopLeft => new(0, 0, ResizeBorderWidth, ResizeBorderWidth);
    private Rectangle TopRight => new(ClientSize.Width - ResizeBorderWidth, 0, ResizeBorderWidth, ResizeBorderWidth);
    private Rectangle BottomLeft => new(0, ClientSize.Height - ResizeBorderWidth, ResizeBorderWidth, ResizeBorderWidth);
    private Rectangle BottomRight => new(ClientSize.Width - ResizeBorderWidth, ClientSize.Height - ResizeBorderWidth, ResizeBorderWidth, ResizeBorderWidth);

    protected override void WndProc(ref Message message)
    {
        base.WndProc(ref message);

        if (message.Msg != 0x84) // WM_NCHITTEST
            return;

        Point cursor = PointToClient(Cursor.Position);

        if (TopLeft.Contains(cursor)) message.Result = (int)Border.TopLeft;
        else if (TopRight.Contains(cursor)) message.Result = (int)Border.TopRight;
        else if (BottomLeft.Contains(cursor)) message.Result = (int)Border.BottomLeft;
        else if (BottomRight.Contains(cursor)) message.Result = (int)Border.BottomRight;

        else if (Top.Contains(cursor)) message.Result = (int)Border.Top;
        else if (Left.Contains(cursor)) message.Result = (int)Border.Left;
        else if (Right.Contains(cursor)) message.Result = (int)Border.Right;
        else if (Bottom.Contains(cursor)) message.Result = (int)Border.Bottom;


        // Trap WM_NCHITTEST
        Point pos = new(message.LParam.ToInt32());
        pos = PointToClient(pos);
        if (pos.Y < cCaption)
        {
            message.Result = 2;  // HTCAPTION
            return;
        }
        if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
        {
            message.Result = 17; // HTBOTTOMRIGHT
            return;
        }

        base.WndProc(ref message);
    }
}