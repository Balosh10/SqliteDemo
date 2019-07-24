using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite.Model;

namespace SQLite.Data
{
    public class FriendsDB
    {
        private readonly SQLiteAsyncConnection dataBase;

        public FriendsDB(string dbPath)
        {
            dataBase = new SQLiteAsyncConnection(dbPath);
            dataBase.CreateTableAsync<Friend>().Wait();
        }

        public async Task<List<Friend>> GetItemsAsync()
        {
            return await dataBase.Table<Friend>().ToListAsync();
        }

        public async Task<Friend> GetItemAsync(int id)
        {
            return await dataBase.Table<Friend>()
                         .Where(i => i.Id.Equals(id))
                         .FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Friend item)
        {
            return !Equals(item.Id, null) ?  dataBase.UpdateAsync(item) : dataBase.InsertAsync(item);
            
        }

        public Task<int> DeleteItemAsync(Friend item)
        {
            return dataBase.DeleteAsync<Friend>(item);
        }
    }
}
