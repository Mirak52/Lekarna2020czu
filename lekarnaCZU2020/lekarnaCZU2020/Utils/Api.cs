using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms.VisualStyles;
using lekarnaCZU2020.Models.Database;
using lekarnaCZU2020.Models.Entity;
using lekarnaCZU2020.Pages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Extensions;
using RestSharp.Serialization.Json;

namespace lekarnaCZU2020.Utils
{
    public class Api
    {
        public static string ApiTalksKey = "v95yyWUqPg9ewCWNUEUi7VleZJIs5th8NdNXwZ86";
        public static string ApiTalksUrl = "https://api.apitalks.store/lekarny";

        public static List<Pharmacy> Pharmacies = new List<Pharmacy>();
        public static void GetResult(int skip = 0)
        {
            //client url a api klíč v hlavičce
            var client = new RestClient(ApiTalksUrl
            + "?filter=" + HttpUtility.UrlEncode("{\"skip\":" + skip + "}"));
            
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-api-key", ApiTalksKey);

            //odeslání požadavků
            var res = client.Execute<List<PharmacyApi>>(request);

            //vybrání prvního prvku z listu
            var queryResult = res.Data.First();
            if (res.ResponseStatus == ResponseStatus.Error)
            {
                throw new System.ArgumentException("Objevila se chyba: "+ res.ErrorMessage);
            }

            Random random = new Random();
            foreach (Pharmacy pharmacy in queryResult.data)
            {
                pharmacy.VZDALENOST = random.Next(50, 200);
                Pharmacies.Add(pharmacy);
            }
            UpdateMessage(skip);
            if (skip < 270)
            {
                //ApiTalks umožnuje max 30 záznamů najednou.
                GetResult(skip + 30);
            }
            else
            {
                //uložení záznamu
                Program.PharmacyDatabase.SaveItemsAsync(Pharmacies);
            }
        }

        private static void UpdateMessage(int skip)
        {
            LoginPage.Instance.statusL.Text = "Počet stažených záznamů: " + (skip + 30);
            LoginPage.Instance.statusL.Refresh();
        }
    }
}
