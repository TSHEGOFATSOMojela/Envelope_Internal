using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Envelope_Internal.Indigent.Assignment;
using Envelope_Internal.Indigent.Models;
using Envelope_Internal.Indigent.Services;
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

            public Task<List<Assignment1>> GetItemsAsync()
            {
                return database.Table<Assignment1>().ToListAsync();
            }

            public Task<List<Assignment1>> GetItemsNotDoneAsync()
            {
                return database.QueryAsync<Assignment1>("SELECT * FROM [Assignment1] WHERE [Done] = 0");
            }

            public Task<Assignment1> GetItemAsync(int id)
            {
                return database.Table<Assignment1>().Where(i => i.ID == id).FirstOrDefaultAsync();
            }

            public Task<int> SaveItemAsync(Assignment1 assignment)
            {
                if (assignment.ID != 0)
                {
                    return database.UpdateAsync(assignment);
                }
                else
                {
                    return database.InsertAsync(assignment);
                }
            }

            public Task<int> DeleteItemAsync(Assignment1 assignment)
            {
                return database.DeleteAsync(assignment);
            }
        }
}
