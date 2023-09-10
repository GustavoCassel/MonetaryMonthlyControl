using System.Diagnostics;
using AppLib.Enums;
using AppLib.Models;
using AppUI.Util;
using Microsoft.EntityFrameworkCore;

namespace AppUI.Categories;

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

    private void ButtonCreate_Click(object sender, EventArgs e)
    {
        Category category = new()
        {
            Id = Guid.NewGuid(),
            Created = DateTime.Now
        };

        using FormManageCategory form = new(category, ManageMode.Create);
        form.ShowDialog(this);

        _dataContext.Categories.Add(category);
    }

    private void ButtonEdit_Click(object sender, EventArgs e)
    {
        if (DataGridViewCategories.SelectedRows.Count != 1)
            return;

        DataGridViewRow selectedRow = DataGridViewCategories.SelectedRows[0];

        if (selectedRow.DataBoundItem is not Category category)
            return;

        using FormManageCategory form = new(category, ManageMode.Edit);
        form.ShowDialog(this);

        DataGridViewCategories.InvalidateRow(selectedRow.Index);
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
        DataGridViewRow selectedRow = DataGridViewCategories.SelectedRows[0];

        if (selectedRow.DataBoundItem is not Category category)
            return;

        using FormManageCategory form = new(category, ManageMode.Delete);
        if (form.ShowDialog(this) == DialogResult.Cancel)
            return;

        _dataContext.Categories.Remove(category);
    }

    private void ButtonZoom_Click(object sender, EventArgs e)
    {
        DataGridViewRow selectedRow = DataGridViewCategories.SelectedRows[0];

        if (selectedRow.DataBoundItem is not Category category)
            return;

        using FormManageCategory form = new(category, ManageMode.Zoom);
        form.ShowDialog(this);
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