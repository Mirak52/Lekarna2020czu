using System;
using System.Windows.Forms;

namespace lekarnaCZU2020.Pages
{
    public partial class PharmacyDetail : UserControl
    {
        public PharmacyDetail(string id)
        {
            InitializeComponent();
            ShowDetailedInfo(id);
        }

        private void backB_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MainPage mp = new MainPage();
            mp.Dock = DockStyle.Fill;
            this.Controls.Add(mp);
        }

        private void ShowDetailedInfo(string id)
        {
            //výběr z databáze a dosazení do labels
            var pharmacy = Program.PharmacyDatabase.QueryGetById(int.Parse(id)).Result;

            typLekarnyInfoL.Text = pharmacy[0].TYP_LEKARNY;
            erpInfoL.Text = pharmacy[0].ERP;
            faxInfoL.Text = pharmacy[0].FAX;
            telefonInfoL.Text = pharmacy[0].TELEFON;
            emailInfoL.Text = pharmacy[0].EMAIL;
            wwwInfoL.Text = pharmacy[0].WWW;
            lekarnikTitulInfoL.Text = pharmacy[0].LEKARNIK_TITUL;
            lekarnikJmenoInfoL.Text = pharmacy[0].LEKARNIK_JMENO;
            lekarnikPrijmeniInfoL.Text = pharmacy[0].LEKARNIK_PRIJMENI;
            pscInfoL.Text = pharmacy[0].PSC;
            uliceInfoL.Text = pharmacy[0].ULICE;
            mestoInfoL.Text = pharmacy[0].MESTO;
            icoInfoL.Text = pharmacy[0].ICO;
            iczInfoL.Text = pharmacy[0].ICZ;
            kodLekarnyInfoL.Text = pharmacy[0].KOD_LEKARNY;
            kodPracovisteInfoL.Text = pharmacy[0].KOD_PRACOVISTE;
            nazevInfoL.Text = pharmacy[0].NAZEV;
            idInfoL.Text = pharmacy[0].id;
        }
    }
}
