using System;

using System.Windows.Forms;
using lekarnaCZU2020.Models.Database;
using lekarnaCZU2020.Pages;

namespace lekarnaCZU2020
{
    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage());
        }
        public static PharmacyDatabase Database;

        public static PharmacyDatabase PharmacyDatabase
        {
            get
            {
                if (Database == null)
                {
                    var fileHelper = new Utils.FileHelper();
                    Database = new PharmacyDatabase(fileHelper.GetLocalFilePath("database.db3"));
                }
                return Database;
            }
        }
    }
}
