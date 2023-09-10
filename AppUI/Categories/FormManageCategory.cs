using AppLib.Enums;
using AppLib.Models;
using AppUI.Util;

namespace AppUI.Categories;

public partial class FormManageCategory : Form
{
    private readonly ManageMode _manageMode;

    private readonly Category _sourceCategory;
    private readonly Category _localCategory;

    public FormManageCategory(Category category, ManageMode manageMode)
    {
        InitializeComponent();
        _sourceCategory = category;
        _manageMode = manageMode;

        _localCategory = new()
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
            Created = category.Created,
            Modified = category.Modified,
            Entries = category.Entries
        };

        bsCategory.DataSource = _localCategory;

        SetDisplayMode();
    }

    private void TextBox_TextChanged(object? sender, EventArgs e)
    {
        LabelMessage.Text = HasUserEdit() ? "Pending user edit" : "No pending edits";
    }

    private void SetDisplayMode()
    {
        switch (_manageMode)
        {
            case ManageMode.Create:
                SetCreateDisplayMode();
                break;
            case ManageMode.Edit:
                SetEditDisplayMode();
                break;
            case ManageMode.Delete:
                SetDeleteDisplayMode();
                break;
            case ManageMode.Zoom:
                SetZoomDisplayMode();
                break;
            default:
                throw new NotImplementedException();
        }
    }

    private void SetCreateDisplayMode()
    {
        LabelTitle.Text = "Create Category";
        LabelMessage.Text = "Fulfill category info";
    }

    private void SetEditDisplayMode()
    {
        FormClosing += Form_FormClosing;
        LabelTitle.Text = "Edit Category";
        LabelMessage.Text = "No pending edits";

        TextBoxName.Leave += TextBox_TextChanged;
        TextBoxDescription.Leave += TextBox_TextChanged;
    }

    private void SetDeleteDisplayMode()
    {
        LabelTitle.Text = "Delete Category";
        LabelMessage.Text = "Are you sure you want to delete this category?";
        TextBoxName.ReadOnly = true;
        TextBoxDescription.ReadOnly = true;
        ButtonConfirm.Text = "Delete";
        ButtonReturn.Text = "Cancel";
    }

    private void SetZoomDisplayMode()
    {
        LabelTitle.Text = "Zoom Category";
        TextBoxName.ReadOnly = true;
        TextBoxDescription.ReadOnly = true;
        LabelMessage.Visible = false;
        ButtonConfirm.Visible = false;
    }

    private bool HasUserEdit()
    {
        return _sourceCategory.Name != _localCategory.Name ||
            _sourceCategory.Description != _localCategory.Description;
    }

    private void Form_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (!HasUserEdit())
            return;

        const string message = "Do you want to discard the edits and exit?";

        if (!UserMessage.ShowQuestionUserYes(message))
            e.Cancel = true;
    }

    private void ButtonReturn_Click(object sender, EventArgs e)
    {
        if (!HasUserEdit())
            FormClosing -= Form_FormClosing;

        Close();
    }

    private void ButtonConfirm_Click(object sender, EventArgs e)
    {
        if (_manageMode == ManageMode.Delete)
        {
            DialogResult = DialogResult.OK;
            return;
        }

        if (_manageMode == ManageMode.Create)
        {
            TextBoxName.Text = TextBoxName.Text.Trim();
            string name = TextBoxName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                LabelMessage.Text = "Invalid name!";
                return;
            }

            TextBoxDescription.Text = TextBoxDescription.Text.Trim();
            string description = TextBoxDescription.Text;
            if (string.IsNullOrWhiteSpace(description))
            {
                LabelMessage.Text = "Invalid description!";
                return;
            }

            _sourceCategory.Name = name;
            _sourceCategory.Description = description;

            DialogResult = DialogResult.OK;
            return;
        }

        if (HasUserEdit())
        {
            const string message = "Confirm edit?";

            if (!UserMessage.ShowQuestionUserYes(message))
                return;

            _sourceCategory.Name = _localCategory.Name;
            _sourceCategory.Description = _localCategory.Description;
            _sourceCategory.Modified = DateTime.Now;
        }

        FormClosing -= Form_FormClosing;
        Close();
    }
}