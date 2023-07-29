namespace AppUI;

public partial class EntriesControl : UserControl
{
    public EntriesControl()
    {
        InitializeComponent();
        TextBox textBox = new()
        {
            Location = new Point(50, 50),
            Size = new Size(150, 1),
            PlaceholderText = "write the value"
        };

        textBox.KeyPress += CustomEvents.KeyPressFormatTextBoxToDouble;
        textBox.Leave += CustomEvents.LeaveFormatTextBoxToDouble;

        Controls.Add(textBox);
    }
}