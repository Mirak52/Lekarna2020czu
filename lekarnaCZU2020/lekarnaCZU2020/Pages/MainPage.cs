using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using lekarnaCZU2020.Models.Entity;

namespace lekarnaCZU2020.Pages
{
    public partial class MainPage : UserControl
    {
        Bitmap DrawArea;
        private Random rnd = new Random();

        public MainPage()
        {
            InitializeComponent();
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = DrawArea;
        }

        public int SelectedInt;

        private void MainPage_Load(object sender, EventArgs e)
        {

            pharmaciesView.View = View.Details;
            pharmaciesView.FullRowSelect = true;

            //listview pro lékárny
            pharmaciesView.Columns.Add("ID", -1, HorizontalAlignment.Left);
            pharmaciesView.Columns.Add("Název", -2, HorizontalAlignment.Left);
            pharmaciesView.Columns.Add("Kód pracoviště", -2, HorizontalAlignment.Left);
            pharmaciesView.Columns.Add("Město", -2, HorizontalAlignment.Left);
            pharmaciesView.Columns.Add("Ulice", -2, HorizontalAlignment.Center);
            pharmaciesView.Columns.Add("Vzdálenost", -2, HorizontalAlignment.Center);


            //listview pro cestu
            roadViewList.View = View.Details;
            roadViewList.FullRowSelect = true;
            roadViewList.Columns.Add("ID", -1, HorizontalAlignment.Left);
            roadViewList.Columns.Add("Název", -2, HorizontalAlignment.Left);
            roadViewList.Columns.Add("Kód pracoviště", -2, HorizontalAlignment.Left);
            roadViewList.Columns.Add("Město", -2, HorizontalAlignment.Left);
            roadViewList.Columns.Add("Ulice", -2, HorizontalAlignment.Center);
            roadViewList.Columns.Add("Vzdálenost", -2, HorizontalAlignment.Center);
            SetPharmacyView();

            //nastevní select boxu pro filter

            Dictionary<string, string> boxDictionary = new Dictionary<string, string>();
            boxDictionary.Add("primaryId", "ID");
            boxDictionary.Add("NAZEV", "Název");
            boxDictionary.Add("MESTO", "Město");
            boxDictionary.Add("ULICE", "Ulice");
            boxDictionary.Add("PSC", "Psč");
            boxDictionary.Add("WWW", "webové stránky");
            filterBox.DataSource = new BindingSource(boxDictionary, null);
            filterBox.DisplayMember = "Value";
            filterBox.ValueMember = "Key";

            //nastevní select boxu pro možnosti
            boxDictionary = new Dictionary<string, string>();
            boxDictionary.Add("detail", "Detail lékárny");
            boxDictionary.Add("edit", "Výběr pro výpočet");
            modeBox.DataSource = new BindingSource(boxDictionary, null);
            modeBox.DisplayMember = "Value";
            modeBox.ValueMember = "Key";
            modeBox.SelectedIndex = 0;
        }

        private void SetPharmacyView(string filter = null, string value = null)
        {
            //filter settings
            List<Pharmacy> pharmacies;
            if (filter == null && value == null)
            {
                pharmacies = Program.PharmacyDatabase.QueryGet().Result;
            }
            else
            {
                pharmacies = Program.PharmacyDatabase.QueryGetByFilter(filter, value).Result;
            }

            pharmaciesView.Items.Clear();
            pharmaciesView.Update();

            foreach (var pharmacy in pharmacies)
            {
                ListViewItem viewItem = new ListViewItem(pharmacy.primaryId.ToString());
                viewItem.SubItems.Add(pharmacy.NAZEV);
                viewItem.SubItems.Add(pharmacy.KOD_PRACOVISTE);
                viewItem.SubItems.Add(pharmacy.MESTO);
                viewItem.SubItems.Add(pharmacy.ULICE);
                viewItem.SubItems.Add(pharmacy.VZDALENOST.ToString());
                pharmaciesView.Items.Add(viewItem);
            }
        }

        private void pharmaciesView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pharmaciesView.SelectedItems.Count > 0)
            {
                if (modeBox.SelectedIndex == 0)
                {
                    var item = pharmaciesView.SelectedItems[0];
                    this.Controls.Clear();
                    PharmacyDetail pd = new PharmacyDetail(item.Text);
                    pd.Dock = DockStyle.Fill;
                    this.Controls.Add(pd);
                }
                else
                {
                    var selectedItem = pharmaciesView.SelectedItems[0];

                    DrawMap(int.Parse(selectedItem.SubItems[selectedItem.SubItems.Count - 1].Text));

                    SelectedInt += 1;
                    numberOfSelectedL.Text = SelectedInt + "/5";
                    pharmaciesView.Items.Remove(selectedItem);
                    roadViewList.Items.Add(selectedItem);
                    if (SelectedInt >= 5)
                    {
                        pharmaciesView.Enabled = false;
                    }
                }

            }
        }

        private int _x;
        private int _y;
        private void DrawMap(int vzdalenost)
        {
            //vykreslení mapy
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            Pen mypen = new Pen(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
            SetXY(vzdalenost);
            if (SelectedInt == 0)
            {
                g.DrawEllipse(mypen, pictureBox1.Width / 2, pictureBox1.Height / 2, 40, 40);
                g.DrawString("Začátek",
                    new Font("Arial", 12), new SolidBrush(Color.DarkOrange),
                    pictureBox1.Width/2 - 10,
                    pictureBox1.Height / 2 + 10 ,
                    new StringFormat());
                pictureBox1.Image = DrawArea;

            }
            g.DrawEllipse(mypen, _x, _y, 40, 40);
            g.DrawString(SelectedInt.ToString(),
                new Font("Arial", 12), new SolidBrush(Color.Black),
                _x + 18,
                _y + 18,
                new StringFormat());
            pictureBox1.Image = DrawArea;
            g.Dispose();
        }

        private void SetXY(int vzdalenost)
        {
            switch (SelectedInt)
            {
                case 0:
                    _x = pictureBox1.Width / 2 + vzdalenost;
                    _y = pictureBox1.Height / 2 + vzdalenost / 2;
                    break;
                case 1:
                    _x = pictureBox1.Width / 2 - vzdalenost;
                    _y = pictureBox1.Height / 2 + vzdalenost / 2;
                    break;
                case 2:
                    _x = pictureBox1.Width / 2 + vzdalenost;
                    _y = pictureBox1.Height / 2 - vzdalenost / 2;
                    break;
                case 3:
                    _x = pictureBox1.Width / 2 - vzdalenost;
                    _y = pictureBox1.Height / 2 - vzdalenost / 2;
                    break;
                case 4:
                    _x = pictureBox1.Width / 2 + vzdalenost / 2;
                    _y = pictureBox1.Height / 2 + vzdalenost / 2;
                    break;
                case 5:
                    _x = pictureBox1.Width / 2 - vzdalenost * 2;
                    _y = pictureBox1.Height / 2 - vzdalenost / 2;
                    break;
            }
        }
        
        private void searchB_Click(object sender, EventArgs e)
        {
            if (filterTextBox.Text != null)
            {
                SetPharmacyView(filterBox.SelectedValue.ToString(), filterTextBox.Text);
                errorL.Text = "";
            }
            else
            {
                errorL.Text = "Vyberte prosím co chcete filtrovat";
            }
        }

        private void backB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toggleB_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MainPage mp = new MainPage();
            mp.Dock = DockStyle.Fill;
            this.Controls.Add(mp);
        }

        private void countPathB_Click(object sender, EventArgs e)
        {
            var items = roadViewList.Items;
            int vzdalenostCelkem = 0;
            SelectedInt = 0;
            foreach (ListViewItem item in items)
            {
                var vzdalenost = int.Parse(item.SubItems[item.SubItems.Count - 1].Text);
                DrawResult(vzdalenost);
                vzdalenostCelkem += vzdalenost;
                SelectedInt += 1;
            }

            resultL.Text = "Celkem: " + vzdalenostCelkem + " Km.";
        }
        //kreslení čar ke středu rozvážky
        private void DrawResult(int vzdalenost)
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            Pen mypen = new Pen(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
            SetXY(vzdalenost);
            g.DrawLine(mypen, pictureBox1.Width / 2 + 19, pictureBox1.Height / 2 + 19, _x + 19, _y + 19);
            pictureBox1.Image = DrawArea;
            g.Dispose();
        }
    }
}
