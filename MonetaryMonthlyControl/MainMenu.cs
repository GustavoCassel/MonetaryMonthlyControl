using MonetaryMonthlyControl.DatabaseMaintenance;

namespace MonetaryMonthlyControl
{
    public partial class MainMenu : Form
    {
        private readonly FormManager formManager = new();
        public MainMenu()
        {
            InitializeComponent();
        }

        private async void ButtonCreateDB_Click(object sender, EventArgs e)
        {
            LabelLoading.Visible = true;
            PictureBoxLoading.Visible = true;
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

            LabelLoading.Text = "Finalizado!";
            PictureBoxLoading.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            formManager.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}