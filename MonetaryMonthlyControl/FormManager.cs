using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MonetaryMonthlyControl
{
    public partial class FormManager : Form
    {
        private readonly Color _enterColor = Color.LightBlue;
        private readonly Color _leaveColor = Color.WhiteSmoke;

        public FormManager()
        {
            InitializeComponent();
            ComboBoxCategory.Items.AddRange(new string[] { "Teste1", "Teste2" });
        }

        #region ControlEvents

        private void FormManager_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxValue_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.BackColor = _leaveColor;

            if (double.TryParse(textbox.Text, out double value))
                textbox.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                textbox.Text = string.Empty;
        }
        private void TextBoxValue_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = _enterColor;
            ((TextBox)sender).Text = string.Empty;
        }

        private void TextBoxDate_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = _leaveColor;
        }
        private void TextBoxDate_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = _enterColor;
            ((TextBox)sender).Text = string.Empty;
        }

        private void TextBoxDescription_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = _leaveColor;
        }
        private void TextBoxDescription_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = _enterColor;
            ((TextBox)sender).Text = string.Empty;
        }

        private void ComboBoxCategory_Leave(object sender, EventArgs e)
        {
            ((ComboBox)sender).BackColor = _leaveColor;
        }
        private void ComboBoxCategory_Enter(object sender, EventArgs e)
        {
            ((ComboBox)sender).BackColor = _enterColor;
            ((ComboBox)sender).Text = string.Empty;
        }

        #endregion
    }
}
