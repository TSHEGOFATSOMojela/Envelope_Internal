using System;
using System.Collections.Generic;
using SQLite;
using Envelope_Internal.Indigent.Models;
using System.Threading.Tasks;
using System.Text;

namespace Envelope_Internal.Data
{
    public class IndigentDB
    {
        readonly SQLiteAsyncConnection database;

        public IndigentDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<assignment>().Wait();
        }

        public Task<List<assignment>> GetItemsAsync()
        {
            return database.Table<assignment>().ToListAsync();
        }

        public Task<List<assignment>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<assignment>("SELECT * FROM [assignment] WHERE [Done] = 0");
        }

        public Task<assignment> GetItemAsync(int id)
        {
            return database.Table<assignment>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(assignment item)
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

        public Task<int> DeleteItemAsync(assignment item)
        {
            return database.DeleteAsync(item);
        }
    }
}
