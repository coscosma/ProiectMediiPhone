using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ProiectMediiPhone.Models;
using ProiectMediiPhone.Auth;


namespace ProiectMediiPhone.Data
{
    public class InchirieriDatabase
    {

        readonly SQLiteAsyncConnection _database;
        public InchirieriDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Inchiriere>().Wait();
            _database.CreateTableAsync<Masina>().Wait();
            _database.CreateTableAsync<Client>().Wait();
            _database.CreateTableAsync<Admin>().Wait();

        }

        //IUser - pentru auth 
        public Task<Masina> AuthenticateMasinaAsync(string email, string password)
        {
            return _database.Table<Barber>()
                .Where(u => u.Email == email && u.Parola == password)
                .FirstOrDefaultAsync();
        }

        public Task<Client> AuthenticateClientAsync(string email, string password)
        {
            return _database.Table<Client>()
                .Where(u => u.Email == email && u.Parola == password)
                .FirstOrDefaultAsync();
        }

        // Programare
        public Task<List<Programare>> GetProgramariAsync()
        {
            return _database.Table<Programare>().ToListAsync();
        }
        public Task<Programare> GetProgramareAsync(int id)
        {
            return _database.Table<Programare>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveProgramareAsync(Programare programare)
        {
            if (programare.ID != 0)
            {
                return _database.UpdateAsync(programare);
            }
            else
            {
                return _database.InsertAsync(programare);
            }
        }
        public Task<int> DeleteProgramareAsync(Programare programare)
        {
            return _database.DeleteAsync(programare);
        }


        // Barber
        public Task<List<Barber>> GetBarbersAsync()
        {
            return _database.Table<Barber>().ToListAsync();
        }

        public Task<Barber> GetBarberAsync(int id)
        {
            return _database.Table<Barber>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveBarberAsync(Barber barber)
        {
            if (barber.ID != 0)
            {
                return _database.UpdateAsync(barber);
            }
            else
            {
                return _database.InsertAsync(barber);
            }
        }

        public Task<int> DeleteBarberAsync(Barber barber)
        {
            return _database.DeleteAsync(barber);
        }

        // Client

        public Task<List<Client>> GetClientsAsync()
        {
            return _database.Table<Client>().ToListAsync();
        }

        public Task<Client> GetClientAsync(int id)
        {
            return _database.Table<Client>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveClientAsync(Client client)
        {
            if (client.ID != 0)
            {
                return _database.UpdateAsync(client);
            }
            else
            {
                return _database.InsertAsync(client);
            }
        }

        public Task<int> DeleteClientAsync(Client client)
        {
            return _database.DeleteAsync(client);
        }


        // in functie de ID

        public Task<List<Programare>> GetVisibleProgramariForClientAsync(int clientId)
        {
            return _database.Table<Programare>()
                .Where(p => p.Client.ID == clientId)
                .ToListAsync();
        }

        public async Task<int?> GetUserIdByEmailAndPasswordAsync(string email, string password)
        {
            var barberUserId = await _database.Table<Barber>()
                .Where(u => u.Email == email && u.Parola == password)
                .FirstOrDefaultAsync();

            var clientUserId = await _database.Table<Client>()
                .Where(u => u.Email == email && u.Parola == password)
                .FirstOrDefaultAsync();

            if (barberUserId != null)
                return barberUserId.ID;
            else if (clientUserId != null)
                return clientUserId.ID;
            else
                return null;
        }

    }


}
