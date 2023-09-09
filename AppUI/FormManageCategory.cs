using AppLib.Models;
using AppUI.Util;

namespace AppUI;

public partial class FormManageCategory : Form
{
    public FormManageCategory(Category category)
    {
        InitializeComponent();

        bsCategory.DataSource = category;
    }

    #region Buttons Events

    private void ButtonReturn_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}