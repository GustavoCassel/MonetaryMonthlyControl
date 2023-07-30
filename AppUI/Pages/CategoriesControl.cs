using AppLib.Models;

namespace AppUI.Pages;

public partial class CategoriesControl : UserControl
{
    public CategoriesControl()
    {
        InitializeComponent();

        FulfillView();

        DataGridViewCategories.CellDoubleClick += DataGridViewCategories_CellDoubleClick;

        Load += ReziseControls;
        SizeChanged += ReziseControls;
    }

    private void ReziseControls(object? sender, EventArgs e)
    {
        DataGridViewCategories.AutoResizeColumn(0);
    }

    private void DataGridViewCategories_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        DataGridViewRow row = DataGridViewCategories.Rows[e.RowIndex];

        MessageBox.Show(row.Cells[0].Value.ToString());
    }

    private void FulfillView()
    {
        using DataContext dataContext = new();

        DataGridViewCategories.Columns.Add("Name", "Name");
        DataGridViewCategories.Columns.Add("Description", "Description");

        foreach (Category category in dataContext.Categories)
        {
            string?[] row = new string?[2] { category.Name, category.Description };

            DataGridViewCategories.Rows.Add(row);
        }
    }

    private async void ButtonNewCategory_Click(object sender, EventArgs e)
    {
        if (Parent is not Panel parentPanel)
            return;

        Hide();

        using EntriesControl form = new();
        MessageBox.Show(parentPanel.Controls.Count.ToString());
        parentPanel.Controls.Add(form);
        
        await Task.Delay(2000);

        Show();
    }
}