using System.Diagnostics;
using AppLib.Models;
using AppUI.Util;

namespace AppUI;

public partial class FormCategories : Form
{
    private readonly CancellationTokenSource _cancellationTokenSource;
    private readonly CancellationToken _token;
    private List<Category>? _categories;

    public FormCategories()
    {
        InitializeComponent();

        _cancellationTokenSource = new();
        _token = _cancellationTokenSource.Token;

        Load += Form_Load;

        DataGridViewCategories.SelectionChanged += DataGridViewCategories_SelectionChanged;

        DataGridViewCategories.CellDoubleClick += DataGridViewCategories_CellDoubleClick;
    }

    private void DataGridViewCategories_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        DataGridViewRow row = DataGridViewCategories.Rows[e.RowIndex];

        MessageBox.Show(row.ToString());
    }

    private void DataGridViewCategories_SelectionChanged(object? sender, EventArgs e)
    {
        if (DataGridViewCategories.Rows.Count == 0)
        {
            ButtonEdit.Visible = false;
            ButtonDelete.Visible = false;
            return;
        }

        if (DataGridViewCategories.SelectedRows.Count != 1)
            return;

        DataGridViewRow selectedRow = DataGridViewCategories.SelectedRows[0];
        if (selectedRow.Tag is not Category)
            return;

        ButtonEdit.Visible = true;
        ButtonDelete.Visible = true;
    }

    private async void Form_Load(object? sender, EventArgs e)
    {
        try
        {
            using Loading loading = await Loading.DockOnParentForm(this, _cancellationTokenSource);

            using DataContext context = new();
            _categories = context.Categories.Select(x => new Category()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Created = x.Created,
                Modified = x.Modified
            }).ToList();

            DataGridViewCategories.DataSource = _categories;
            DataGridViewCategories.Columns.Remove(nameof(Category.Id));
            DataGridViewCategories.Columns.Remove(nameof(Category.Entries));
        }
        catch (TaskCanceledException ex)
        {
            Hide();
            UserMessage.ShowError(ex.Message, Level.Success);
            Close();
        }
        catch (Exception ex)
        {
            Hide();
            UserMessage.ShowError($"""
                An unknown error occurred!
                Error message: {ex.Message}
                """, Level.Unknown);
            Close();
        }
    }

    #region Buttons Events

    private void ButtonReturn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {

    }

    private void ButtonEdit_Click(object sender, EventArgs e)
    {
        DataGridViewRow selectedRow = DataGridViewCategories.SelectedRows[0];

        if (selectedRow.Tag is not Category)
            return;


    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
        DataGridViewRow selectedRow = DataGridViewCategories.SelectedRows[0];

        if (selectedRow.Tag is not Category)
            return;

        DataGridViewCategories.Rows.Remove(selectedRow);
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {

    }

    #endregion
}