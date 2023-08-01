using AppLib.Models;

namespace AppUI.Pages;

public partial class NewCategoryControl : UserControl
{
    public NewCategoryControl()
    {
        InitializeComponent();
    }

    private async void ButtonConfirm_Click(object sender, EventArgs e)
    {
        string name = TextBoxName.Text;
        if (string.IsNullOrWhiteSpace(name))
            return;

        string description = RichTextBoxDescription.Text;
        if (string.IsNullOrWhiteSpace(description))
            return;

        using DataContext dataContext = new();

        foreach (Category category in dataContext.Categories)
        {
            if (category.Name == name)
                return;
        }

        dataContext.Categories.Add(new Category { Name = name, Description = description });

        await dataContext.SaveChangesAsync();

        Parent?.Controls.Clear();

        Dispose();
    }
}