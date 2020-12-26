using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SQLite;

namespace lekarnaCZU2020.Models.Entity
{
    public class Pharmacy
    {
        private int _vzdalenost;

        [PrimaryKey, AutoIncrement]
        public int primaryId { get; set; }
        public string id { get; set; }
        public string NAZEV { get; set; }
        public string KOD_PRACOVISTE { get; set; }
        public string KOD_LEKARNY { get; set; }
        public string ICZ { get; set; }
        public string ICO { get; set; }
        public string MESTO { get; set; }
        public string ULICE { get; set; }
        public string PSC { get; set; }
        public string LEKARNIK_PRIJMENI { get; set; }
        public string LEKARNIK_JMENO { get; set; }
        public string LEKARNIK_TITUL { get; set; }
        public string WWW { get; set; }
        public string EMAIL { get; set; }
        public string TELEFON { get; set; }
        public string FAX { get; set; }
        public string ERP { get; set; }
        public string TYP_LEKARNY { get; set; }

        public int VZDALENOST { get; set; }
    }

    public class Info
    {
        public string provider { get; set; }
    }

    public class PharmacyApi
    {
        public List<Pharmacy> data { get; set; }
        public int skip { get; set; }
        public int count { get; set; }
        public int limit { get; set; }
        public Info info { get; set; }
    }
}
