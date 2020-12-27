using System.Collections.Generic;
using System.Threading.Tasks;
using lekarnaCZU2020.Models.Entity;
using SQLite;

namespace lekarnaCZU2020.Models.Database
{
    public class PharmacyDatabase
    {
        // SQLite connection
        public SQLiteAsyncConnection Database;

        public PharmacyDatabase(string dbPath)
        {
            Database = new SQLiteAsyncConnection(dbPath);
            Database.CreateTableAsync<Pharmacy>().Wait();
        }
        public Task<List<Pharmacy>> QueryGet()
        {
            return Database.QueryAsync<Pharmacy>("SELECT * FROM [Pharmacy];");
        }
        public Task<List<Pharmacy>> QueryGetById(int id)
        {
            return Database.QueryAsync<Pharmacy>("SELECT * FROM [Pharmacy] WHERE [primaryId] = ?;", id);
        }
        public Task<int> SaveItemsAsync(List<Pharmacy> items)
        {
           return Database.InsertAllAsync(items);
        }

        public int CheckDatabase()
        {
            return Database.QueryAsync<Pharmacy>("SELECT * FROM [Pharmacy] LIMIT 1").Result.Count;
        }

        public Task<List<Pharmacy>> QueryGetByFilter(string filter, string value)
        {
            return Database.QueryAsync<Pharmacy>("SELECT * FROM [Pharmacy] WHERE [" + filter.ToUpper() + "] like ?", "%"+value+"%");
        }
    }
}
