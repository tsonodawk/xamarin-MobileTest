using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using MobileTest.Models;

namespace MobileTest.Data
{
    public class MobileTestDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public MobileTestDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<UserLogin>().Wait();  
        }

        public Task<List<UserLogin>> GetUserLoginsAsync()
        {
            return _database.Table<UserLogin>().ToListAsync();
        }

        public Task<UserLogin> GetUserLoginAsync(int id)
        {
            return _database.Table<UserLogin>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<UserLogin> GetUserLoginAsync(string companyId, string userId, string passwd)
        {
            return _database.Table<UserLogin>()
                            .Where(i => i.CompanyId == companyId & i.UserId == userId & i.Passwd == passwd)
                            .FirstOrDefaultAsync();
        }

    }
}
