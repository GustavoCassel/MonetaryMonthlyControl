using AppLib;
using AppLib.Models;

namespace AppUI.Pages;

public partial class CategoriesControl : UserControl
{
    private readonly FormMenu _formMenu;

    public CategoriesControl(FormMenu formMenu)
    {
        InitializeComponent();
        _formMenu = formMenu;

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
        DataGridViewCategories.Columns.Add("Name", "Name");
        DataGridViewCategories.Columns.Add("Description", "Description");

        foreach (Category category in Server.DataContext.Categories)
        {
            string?[] row = new string?[2] { category.Name, category.Description };

            DataGridViewCategories.Rows.Add(row);
        }
    }

    private void ButtonNewCategory_Click(object sender, EventArgs e)
    {
        Panel parentPanel = default;

        parentPanel.Controls.Clear();
        NewCategoryControl control = new()
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(0, 0, 10, 10)
        };

        parentPanel.Controls.Add(control);
    }
}