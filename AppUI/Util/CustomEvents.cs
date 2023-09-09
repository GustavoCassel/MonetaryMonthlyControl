namespace AppUI.Util;

public static class CustomEvents
{
    private const int MaxDecimalCharacters = 4;
    private const char DecimalSeparator = ','; // code 44
    private const char ControlV = '\u0016'; // code 22
    private const char Zero = '0'; // code 48

    private static readonly ToolTip _toolTip = new();

    public static void ShowToolTip(TextBox textBox, string message)
    {
        const int MillisecondsPerCharacter = 68;

        _toolTip.RemoveAll();

        _toolTip.Show(
            message,
            textBox,
            textBox.Width,
            -textBox.Height,
            message.Length * MillisecondsPerCharacter);
    }

    public static void KeyPressFormatTextBoxToDouble(object? sender, KeyPressEventArgs eventArgs)
    {
        if (sender is not TextBox textBox)
            throw new ArgumentException($"Objeto sender deve ser do tipo 'TextBox' !", nameof(sender));

        eventArgs.Handled = true;

        if (eventArgs.KeyChar == ControlV)
        {
            ShowToolTip(textBox, "Não é permitido 'Ctrl+V' !");
            return;
        }

        if (!char.IsControl(eventArgs.KeyChar) &&
            !char.IsDigit(eventArgs.KeyChar) &&
            eventArgs.KeyChar != DecimalSeparator)
        {
            ShowToolTip(textBox, "Somente números e 1 vírgula são válidos!");
            return;
        }

        if (eventArgs.KeyChar == Zero && textBox.SelectionStart == 0)
        {
            ShowToolTip(textBox, "Não são permitidos '0' à esquerda!");
            return;
        }

        if (eventArgs.KeyChar == DecimalSeparator)
        {
            HandleDecimalSeparator(textBox, eventArgs);
            return;
        }

        eventArgs.Handled = false;

        // like backspace or delete
        if (!char.IsDigit(eventArgs.KeyChar))
            return;

        if (!textBox.Text.Contains(DecimalSeparator))
            return;

        int separatorPosition = textBox.Text.IndexOf(DecimalSeparator);
        string afterSeparatorText = textBox.Text.Substring(separatorPosition + 1);
        if (textBox.SelectionStart > separatorPosition && afterSeparatorText.Length > MaxDecimalCharacters - 1)
        {
            ShowToolTip(textBox, $"Máximo de {MaxDecimalCharacters} casas decimais!");
            eventArgs.Handled = true;
        }
    }
    private static void HandleDecimalSeparator(TextBox textBox, KeyPressEventArgs eventArgs)
    {
        if (textBox.Text.Length == 0)
        {
            ShowToolTip(textBox, "O texto ainda está vazio!");
            return;
        }

        if (textBox.SelectionStart == 0)
        {
            ShowToolTip(textBox, "Não é aceito vírgula no início!");
            return;
        }

        if (textBox.Text.Contains(DecimalSeparator))
        {
            ShowToolTip(textBox, "Só é permitido 1 vírgula!");
            return;
        }

        if (textBox.SelectionStart != textBox.Text.Length)
        {
            string afterSeparatorText = textBox.Text.Substring(textBox.SelectionStart);

            if (afterSeparatorText.Length > MaxDecimalCharacters)
            {
                ShowToolTip(textBox, $"Posição da vírgula viola o máximo de {MaxDecimalCharacters} caracteres decimais!");
                eventArgs.Handled = true;
                return;
            }
        }

        eventArgs.Handled = false;
    }

    public static void LeaveFormatTextBoxToDouble(object? sender, EventArgs e)
    {
        if (sender is not TextBox textBox)
            throw new ArgumentException(
                $"{nameof(sender)} must be of type 'TextBox'!", nameof(sender));

        if (textBox.Text.Length == 0)
            return;

        int lastCharIndex = textBox.Text.Length - 1;
        if (textBox.Text[lastCharIndex] != DecimalSeparator)
            return;

        ShowToolTip(textBox, """
            It's not allowed a comma in the end of the sequence!
            The character was removed!
            """);
        textBox.Text = textBox.Text.Remove(lastCharIndex);
    }

    public static void LeaveFormatTextBoxToCurrency(object? sender, EventArgs e)
    {
        if (sender is not TextBox textBox)
            throw new ArgumentException(
                $"{nameof(sender)} must be of type 'TextBox'!", nameof(sender));


    }

    public static void KeyPressTextBoxOnlyAllowNumbers(object? sender, KeyPressEventArgs eventArgs)
    {
        if (sender is not TextBox textBox)
            throw new ArgumentException(
                $"{nameof(sender)} must be of type 'TextBox'!", nameof(sender));

        if (!char.IsControl(eventArgs.KeyChar) &&
            !char.IsDigit(eventArgs.KeyChar))
        {
            ShowToolTip(textBox, "Only numbers are allowed!");
            eventArgs.Handled = true;
        }
    }
}