using System.Collections.Generic;
using System.Threading.Tasks;
using Envelope_Internal.Indigent.Models;
using SQLite;

namespace Envelope_Internal.Indigent.Data
{
        public class IndigentDB
        {
        readonly SQLiteAsyncConnection database;

        public IndigentDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Assignment1>().Wait();
        }

        public Task<List<Assignment1>> GetAssignmentsAsync()
        {
            return database.Table<Assignment1>().ToListAsync();
        }

        public Task<List<Assignment1>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Assignment1>("SELECT * FROM [Assignment1] WHERE [Status] = Accepted");
        }

        public Task<Assignment1> GetItemAsync(int id)
        {
            return database.Table<Assignment1>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Assignment1 item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Assignment1 item)
        {
            return database.DeleteAsync(item);
        }
    }
}
