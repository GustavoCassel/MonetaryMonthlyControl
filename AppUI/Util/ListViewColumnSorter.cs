using System.Collections;

namespace AppUI.Util;

public sealed class ListViewColumnSorter : IComparer
{
    private int _sortColumn = 0;
    private SortOrder _sortOrder = SortOrder.None;

    private readonly CaseInsensitiveComparer _objectCompare = new();
    private readonly ListView _listView;

    public ListViewColumnSorter(ListView listView)
    {
        _listView = listView;
        _listView.ColumnClick += ListView_ColumnClick;
    }

    private void ListView_ColumnClick(object? sender, ColumnClickEventArgs e)
    {
        SortListViewByColumn(e);

        _listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        _listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }

    public int Compare(object? x, object? y)
    {
        if (x is null || y is null)
            throw new Exception();

        ListViewItem listviewX = (ListViewItem)x;
        ListViewItem listviewY = (ListViewItem)y;

        int compareResult = _objectCompare.Compare(
            listviewX.SubItems[_sortColumn].Text,
            listviewY.SubItems[_sortColumn].Text);

        return _sortOrder switch
        {
            SortOrder.Ascending => compareResult,
            SortOrder.Descending => -compareResult,
            _ => 0,
        };
    }

    private void SortListViewByColumn(ColumnClickEventArgs columnClickEventArgs)
    {
        // if the user click the same column twice
        if (columnClickEventArgs.Column == _sortColumn)
        {
            _sortOrder = _sortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            _listView.Sort();
            return;
        }

        // the user clicked a new column
        _sortColumn = columnClickEventArgs.Column;
        _sortOrder = SortOrder.Ascending;
        _listView.Sort();
    }
}