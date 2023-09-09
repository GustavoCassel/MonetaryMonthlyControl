using AppLib.Models;
using AppUI.Util;

namespace AppUI;

public partial class FormManageCategory : Form
{
    private readonly Category _category;

    public FormManageCategory(Category category)
    {
        InitializeComponent();

        _category = category;
    }

    #region Buttons Events

    private void ButtonReturn_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}