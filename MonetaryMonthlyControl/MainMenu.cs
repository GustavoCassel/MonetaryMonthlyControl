using Microsoft.Win32;
using MonetaryMonthlyControl.DatabaseMaintenance;
using System.CodeDom;
using System.Diagnostics;
using System.Security.Policy;
using System.Windows.Forms;

namespace MonetaryMonthlyControl
{
    public partial class MainMenu : Form
    {
        private Button? _activeButton;
        private Form _activeForm;

        private readonly ToolTip _toolTip = new();
        private readonly ThemeManager _themeManager;
        public MainMenu()
        {
            InitializeComponent();
            _themeManager = new ThemeManager();
            UpdateAllStyles();
            DisableAllButtonsInMenu();
        }

        private void UpdateAllStyles()
        {
            this.BackColor = _themeManager.MainBackGroundColor;
            RecursivePanels(this.Controls);
            DisableAllButtonsInMenu();
            ActivateButton(_activeButton);
        }

        private void RecursivePanels(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button button = (Button)control;
                    button.FlatAppearance.MouseOverBackColor = Color.LightBlue;
                    button.BackColor = Color.Transparent;
                    button.ForeColor = _themeManager.GeneralForeColor;
                }

                if (control.GetType() == typeof(Panel))
                {
                    Panel panel = (Panel)control;
                    panel.BackColor = _themeManager.LighterBackColor;
                    panel.ForeColor = _themeManager.GeneralForeColor;

                    RecursivePanels(panel.Controls);
                }
            }
        }

        #region Responsive User Interface Methods

        private void ActivateButton(object? sender)
        {
            if (sender is null)
                return;

            if (sender.GetType() != typeof(Button))
                throw new ArgumentException("Sender is not a Button!", nameof(sender));

            DisableAllButtonsInMenu();

            _activeButton = (Button)sender;

            Font currentFont = _activeButton.Font;
            _activeButton.BackColor = _themeManager.DarkerBackColor;//  Color.FromArgb(67, 67, 138);
            _activeButton.ForeColor = Color.White;
            _activeButton.Font = new Font(currentFont.FontFamily, currentFont.Size + 2F, currentFont.Style, currentFont.Unit);
        }

        private void DisableAllButtonsInMenu()
        {
            foreach (Control control in this.panelMenu.Controls)
            {
                if (control.GetType() != typeof(Button))
                    continue;

                Button button = (Button)control;
                button.BackColor = Color.Transparent;
                button.ForeColor = _themeManager.GeneralForeColor;
                Font currentFont = button.Font;
                button.Font = new Font(currentFont.FontFamily, 12F, currentFont.Style, currentFont.Unit);
            }
        }

        #endregion

        #region Button Click Events


        private void OpenChildForm(Form childForm, object sender)
        {
            _activeForm?.Close();

            ActivateButton(sender);

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(childForm);
            this.panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ButtonVisualize_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormManager(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void ButtonChangeColor_Click(object sender, EventArgs e)
        {
            const string DarkThemeMessage = "Dark Theme";
            const string LightThemeMessage = "Light Theme";

            bool isDarkThemeActive = ButtonChangeColor.Text == DarkThemeMessage;
            ButtonChangeColor.Text = isDarkThemeActive ? LightThemeMessage : DarkThemeMessage;

            _themeManager.SetTheme(isDarkThemeActive);

            UpdateAllStyles();
        }

        #endregion
    }
}

/*private async void CreateDB()
{
    Update();

    await Task.Run(() =>
    {
        DatabaseManager databaseManager = new();
        //databaseManager.DeleteDatabase();
        databaseManager.CreateDatabase();

        string[] monthNames = Enum.GetNames(typeof(Month));
        foreach (string month in monthNames)
        {
            if (month == Month.Unknown.ToString())
                continue;

            databaseManager.CreateTable(month);
        }
    });
}*/