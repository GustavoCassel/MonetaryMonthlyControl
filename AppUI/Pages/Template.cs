using System.Globalization;

namespace AppUI;

public partial class Template : UserControl
{
    public Template()
    {
        InitializeComponent();
        TextBox textBox = new()
        {
            Location = new Point(50, 50),
            Size = new Size(150, 1),
            PlaceholderText = "digite o valor"
        };
        textBox.Leave += DefaultCurrencyTextBoxLeave;
        textBox.TextChanged += DefaultCurrencyTextBoxTextChanged;
        Controls.Add(textBox);
    }

    private void DefaultCurrencyTextBoxTextChanged(object? sender, EventArgs e)
    {
        if (sender is not TextBox textBox)
            return;


    }

    private void DefaultCurrencyTextBoxLeave(object? sender, EventArgs e)
    {
        if (sender is not TextBox textBox)
            return;

        NumberFormatInfo numberFormat = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;

        string text = textBox.Text
            .Replace(numberFormat.CurrencySymbol, "")
            .Trim();

        if (!decimal.TryParse(text, out decimal result))
        {
            textBox.Text = "";
            textBox.PlaceholderText = "valor inválido!";
            textBox.BackColor = Color.LightPink;
            return;
        }

        textBox.Text = $"{result:C2}";
        textBox.PlaceholderText = "digite o valor";
        textBox.BackColor = Color.White;
    }
}