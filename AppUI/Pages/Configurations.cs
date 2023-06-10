using System.Globalization;

namespace AppUI;

public partial class Configurations : UserControl, IUserInterfaceUpdater
{
    public Configurations()
    {
        InitializeComponent();
        ComboBoxLanguage.Items.AddRange(Enum.GetNames(typeof(Language)));
        ComboBoxLanguage.SelectedIndex = (int)UIConfig.Language;
        ComboBoxThemes.Items.AddRange(Enum.GetNames(typeof(Theme)));
        ComboBoxThemes.SelectedIndex = (int)UIConfig.Theme;
    }

    public void UpdateUserInterface()
    {
        foreach (Button button in Controls.OfType<Button>())
        {
            button.BackColor = UIConfig.BackColor;
            button.ForeColor = UIConfig.ForeColor;

            button.FlatAppearance.MouseOverBackColor = UIConfig.MouseOverColor;
            button.FlatAppearance.MouseDownBackColor = UIConfig.MouseDownColor;
        }
    }

    private void ButtonApplyChanges_Click(object sender, EventArgs e)
    {
        UIConfig.SetTheme((Theme)ComboBoxThemes.SelectedIndex);
        UpdateUserInterface();
        ((IUserInterfaceUpdater?)ParentForm)?.UpdateUserInterface();
    }
}