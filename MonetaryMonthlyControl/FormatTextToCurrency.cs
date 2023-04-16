using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetaryMonthlyControl
{
    public sealed class FormatTextToCurrency
    {
        private readonly Form _ownerForm;
        private readonly TextBox _textBox;
        public FormatTextToCurrency(Form ownerForm, TextBox textBox)
        {
            _ownerForm = ownerForm;
            _textBox = textBox;
        }

        private string _text = string.Empty;
        private double _currency;

        public void HandleEntry(KeyPressEventArgs e)
        {
            e.Handled = true;

            if (e.KeyChar == (char)Keys.Back)
            {
                RemoveLastChar();
                FormatAndUpdateTextBox();
                return;
            }

            if (!char.IsDigit(e.KeyChar) || e.KeyChar == ',')
            {
                return;
            }

            _text += e.KeyChar;
            FormatAndUpdateTextBox();
        }

        private void RemoveLastChar()
        {
            if (_text.Length == 0)
                return;

            _text = _text.Remove(_text.Length - 1, 1);
        }

        private void FormatAndUpdateTextBox()
        {
            string? formattedText = default;
            if (!string.IsNullOrWhiteSpace(_text))
            {
                formattedText = Convert.ToDouble(_text).ToString("C2");
            }

            _textBox.Text = formattedText;
            _ownerForm.Update();
        }
    }
}
