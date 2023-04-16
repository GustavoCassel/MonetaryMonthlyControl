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
        private readonly FormatTextToCurrency _formatTextToCurrency;
        public FormManager()
        {
            InitializeComponent();
            _formatTextToCurrency = new FormatTextToCurrency(this, TextBoxValue);
        }

        private void TextBoxValue_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.BackColor = Color.WhiteSmoke;

            if (double.TryParse(textbox.Text, out double value))
                textbox.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                textbox.Text = string.Empty;
        }

        private void TextBoxValue_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Cyan;
            ((TextBox)sender).Text = string.Empty;
        }

        private void FormManager_Click(object sender, EventArgs e)
        {

        }
    }
}
