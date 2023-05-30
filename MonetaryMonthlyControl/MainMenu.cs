namespace MonetaryMonthlyControl;

public partial class MainMenu : Form
{
    public MainMenu()
    {
        InitializeComponent();
    }
}
/*
private async void CreateDB()
{
Update();

await Task.Run(() =>
{
DatabaseManager databaseManager = new();
//databaseManager.DeleteDatabase();
databaseManager.CreateDatabase();

string[] monthNames = Enum.GetNames(typeof(Month));
foreach (string month in monthNames)
{
    if (month == Month.Unknown.ToString())
        continue;

    databaseManager.CreateTable(month);
}
});
}*/