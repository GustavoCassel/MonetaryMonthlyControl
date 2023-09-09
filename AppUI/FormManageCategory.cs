using AppLib.Models;
using AppUI.Util;

namespace AppUI;

public partial class FormManageCategory : Form
{
    public FormManageCategory(Category category)
    {
        InitializeComponent();

        bsCategory.DataSource = category;

        FormClosing += Form_FormClosing;
    }

    private void Form_FormClosing(object? sender, FormClosingEventArgs e)
    {
        const string message = "Do you want to discard the edits and exit?";

        if (!UserMessage.ShowQuestionUserYes(message))
            e.Cancel = true;
    }

    private void ButtonReturn_Click(object sender, EventArgs e)
    {
        FormClosing -= Form_FormClosing;
        Close();
    }

    private void ButtonConfirm_Click(object sender, EventArgs e)
    {
        Close();
    }
}