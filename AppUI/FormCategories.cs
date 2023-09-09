using System.Diagnostics;
using AppLib.Models;
using AppUI.Util;
using Microsoft.EntityFrameworkCore;

namespace AppUI;

public partial class FormCategories : Form
{
    private readonly CancellationTokenSource cancellationTokenSource;
    private readonly CancellationToken cancellationToken;

    private readonly DataContext _dataContext;
    public FormCategories()
    {
        InitializeComponent();

        cancellationTokenSource = new();
        cancellationToken = cancellationTokenSource.Token;

        _dataContext = new();

        Load += Form_Load;

        //DataGridViewCategories.CellDoubleClick += DataGridViewCategories_CellDoubleClickAsync;
    }

    private void DataGridViewCategories_CellDoubleClickAsync(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1)
            return;

        DataGridViewRow row = DataGridViewCategories.Rows[e.RowIndex];

        if (row.DataBoundItem is not Category category)
        {
            UserMessage.ShowError("Category not found!", Level.Success);
            return;
        }

        FormManageCategory formManageCategory = new(category);
        formManageCategory.ShowDialog(this);

        DataGridViewCategories.InvalidateRow(e.RowIndex);
    }

    private async void Form_Load(object? sender, EventArgs e)
    {
        try
        {
            using Loading loading = await Loading.DockOnParentForm(this, cancellationTokenSource);

            await _dataContext.Categories.LoadAsync(cancellationToken);
            DataGridViewCategories.DataSource = _dataContext.Categories.Local.ToBindingList();

            DataGridViewCategories.Columns.Remove(nameof(Category.Id));
            DataGridViewCategories.Columns.Remove(nameof(Category.Entries));
            DataGridViewCategories.Columns.Remove(nameof(Category.Created));
            DataGridViewCategories.Columns.Remove(nameof(Category.Modified));
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
        //FormManageCategory form = new();
    }

    private void ButtonEdit_Click(object sender, EventArgs e)
    {
        if (DataGridViewCategories.SelectedRows.Count != 1)
            return;

        DataGridViewRow selectedRow = DataGridViewCategories.SelectedRows[0];

        if (selectedRow.DataBoundItem is not Category category)
            return;

        FormManageCategory formManageCategory = new(category);
        formManageCategory.ShowDialog(this);

        DataGridViewCategories.InvalidateRow(selectedRow.Index);
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
        DataGridViewRow selectedRow = DataGridViewCategories.SelectedRows[0];

        if (selectedRow.DataBoundItem is not Category category)
            return;

        if (!UserMessage.ShowQuestionUserYes($"""
            u sure?
            {category.Name}
            """))
            return;

        _dataContext.Categories.Remove(category);
    }

    private async void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            using Loading loading = await Loading.DockOnParentForm(this, cancellationTokenSource);

            await _dataContext.SaveChangesAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            Hide();
            UserMessage.ShowError($"""
                An unknown error occurred!
                Error message: {ex.Message}
                """, Level.Unknown);
            return;
        }

        UserMessage.ShowSuccess("Saved successfully!");

        Close();
    }

    #endregion
}