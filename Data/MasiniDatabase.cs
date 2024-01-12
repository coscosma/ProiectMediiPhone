using ProiectMediiPhone.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMediiPhone.Data
{
    public class MasiniDatabase
    {
        
      

        //tabela categorie
        readonly SQLiteAsyncConnection _database;
        public MasiniDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Categorie>().Wait();
            _database.CreateTableAsync<Client>().Wait();
            _database.CreateTableAsync<Inchiriere>().Wait();
            _database.CreateTableAsync<Producator>().Wait();
            _database.CreateTableAsync<Masina>().Wait();
            _database.CreateTableAsync<Locatie>().Wait();
        }
        public Task<List<Categorie>> GetCategorieListsAsync()
        {
            return _database.Table<Categorie>().ToListAsync();
        }


        public Task<Categorie> GetCategorieListAsync(int id)
        {
            return _database.Table<Categorie>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveCategorieListAsync(Categorie slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteCategorieListAsync(Categorie slist)
        {
            return _database.DeleteAsync(slist);
        }





        //masina
        public Task<List<Masina>> GetMasinaListsAsync()
        {
            return _database.Table<Masina>().ToListAsync();
        }


        public Task<Masina> GetMasinaListAsync(int id)
        {
            return _database.Table<Masina>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveMasinaListAsync(Categorie slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteMasinaListAsync(Categorie slist)
        {
            return _database.DeleteAsync(slist);
        }






        /*
        //inchiriere
        public Task<List<Categorie>> GetCategorieListsAsync()
        {
            return _database.Table<Categorie>().ToListAsync();
        }

        
        public Task<Categorie> GetCategorieListAsync(int id)
        {
            return _database.Table<Categorie>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveCategorieListAsync(Categorie slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteCategorieListAsync(Categorie slist)
        {
            return _database.DeleteAsync(slist);
        }



        //locatie
        public Task<List<Categorie>> GetCategorieListsAsync()
        {
            return _database.Table<Categorie>().ToListAsync();
        }


        public Task<Categorie> GetCategorieListAsync(int id)
        {
            return _database.Table<Categorie>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveCategorieListAsync(Categorie slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteCategorieListAsync(Categorie slist)
        {
            return _database.DeleteAsync(slist);
        }

        //producator
        public Task<List<Categorie>> GetCategorieListsAsync()
        {
            return _database.Table<Categorie>().ToListAsync();
        }


        public Task<Categorie> GetCategorieListAsync(int id)
        {
            return _database.Table<Categorie>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveCategorieListAsync(Categorie slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteCategorieListAsync(Categorie slist)
        {
            return _database.DeleteAsync(slist);
        }

        
        

        //client
        public Task<List<Categorie>> GetCategorieListsAsync()
        {
            return _database.Table<Categorie>().ToListAsync();
        }


        public Task<Categorie> GetCategorieListAsync(int id)
        {
            return _database.Table<Categorie>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveCategorieListAsync(Categorie slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteCategorieListAsync(Categorie slist)
        {
            return _database.DeleteAsync(slist);
        }*/

    }
}
