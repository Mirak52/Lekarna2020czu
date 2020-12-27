using System;
using System.Windows.Forms;

namespace lekarnaCZU2020.Pages
{
    public partial class LoginPage : Form
    {
        private static LoginPage _instance;
        public LoginPage()
        {

            InitializeComponent();
            _instance = this;
        }
        public static LoginPage Instance { get { return _instance; } }



        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MainPage mp = new MainPage();
            mp.Dock = DockStyle.Fill;
            this.Controls.Add(mp);
        }

        private void databaseB_Click(object sender, EventArgs e)
        {
            databaseB.Enabled = false;
            try
            {
                statusL.Text = "Stahuji záznamy lékáren";
                Utils.Api.GetResult();
                loginButton.Enabled = true;
                statusL.Text = statusL.Text + ", Záznamy úspěšně staženy";
            }
            catch (Exception apiException)
            {
                statusL.Text = apiException.Message;
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            if (Program.PharmacyDatabase.CheckDatabase() == 0)
            {
                loginButton.Enabled = false;
            }
            else
            {
                databaseB.Enabled = false;
            }
        }
    }
}
