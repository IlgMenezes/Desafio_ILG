using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Desafio_ILG.Model
{
    public class CityDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public CityDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<City>().Wait();
        }

        public Task<List<City>> GetCitiesAsync()
        {
            return _database.Table<City>().ToListAsync();
        }

        public Task<City> GetCityAsync(int id)
        {
            return _database.Table<City>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveCityAsync(City city)
        {
            if (city.Id != 0)
            {
                return _database.UpdateAsync(city);
            }
            else
            {
                return _database.InsertAsync(city);
            }
        }

        public void DropCityAsync(City city)
        {
            _database.DropTableAsync<City>();
            _database.CreateTableAsync<City>().Wait();
        }
    }
}
