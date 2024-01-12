﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ProiectMediiPhone.Models;
using ProiectMediiPhone.Autentificare;


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
            _database.CreateTableAsync<Agent>().Wait();

        }

        //Client - pentru auth 
        public Task<Agent> AuthenticateAgentAsync(string email, string password)
        {
            return _database.Table<Agent>()
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
        public Task<List<Inchiriere>> GetInchirieriAsync()
        {
            return _database.Table<Inchiriere>().ToListAsync();
        }
        public Task<Inchiriere> GetInchiriereAsync(int id)
        {
            return _database.Table<Inchiriere>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveProgramareAsync(Inchiriere programare)
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
        public Task<int> DeleteProgramareAsync(Inchiriere programare)
        {
            return _database.DeleteAsync(programare);
        }


        // Barber
        public Task<List<Agent>> GetAgentiAsync()
        {
            return _database.Table<Agent>().ToListAsync();
        }

        public Task<Agent> GetAgentAsync(int id)
        {
            return _database.Table<Agent>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveAgentAsync(Agent agent)
        {
            if (agent.ID != 0)
            {
                return _database.UpdateAsync(agent);
            }
            else
            {
                return _database.InsertAsync(agent);
            }
        }

        public Task<int> DeleteAgentAsync(Agent agent)
        {
            return _database.DeleteAsync(agent);
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

        public Task<List<Inchiriere>> GetVisibleInchirieriForClientAsync(int clientId)
        {
            return _database.Table<Inchiriere>()
                .Where(p => p.Client.ID == clientId)
                .ToListAsync();
        }

        public async Task<int?> GetUserIdByEmailAndPasswordAsync(string email, string password)
        {
            var agentUserId = await _database.Table<Agent>()
                .Where(u => u.Email == email && u.Parola == password)
                .FirstOrDefaultAsync();

            var clientUserId = await _database.Table<Client>()
                .Where(u => u.Email == email && u.Parola == password)
                .FirstOrDefaultAsync();

            if (agentUserId != null)
                return agentUserId.ID;
            else if (clientUserId != null)
                return clientUserId.ID;
            else
                return null;
        }

    }


}
