using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsMauiApp.Models
{
    class SongDAO
    {
        SQLiteAsyncConnection conn;

        public async Task InitializeDatabase()
        {
            if (conn == null)
            {
                string connString = Path.Combine(FileSystem.AppDataDirectory, "database.db");
                conn = new SQLiteAsyncConnection(connString, false);
                await conn.CreateTableAsync<Song>();
            }
        }

        public async Task<int> Insert(Song song)
        {
            await InitializeDatabase();

            return await conn.InsertAsync(song);
        }
        public async Task<int> Delete(Song song)
        {
            await InitializeDatabase();
            return await conn.DeleteAsync(song);
        }

        public async Task<List<Song>> GetAll()
        {
            await InitializeDatabase();
            return await conn.Table<Song>().ToListAsync();
        }

       

    }
}
