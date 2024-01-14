using ProiectMediiPhone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectMediiPhone.Data;

namespace ProiectMediiPhone.Autentificare
{
    public class Login
    {
        public async Task<Agent> AuthenticateAgentAsync(string email, string password)
        {
            // Autentificare ca si barber
            Agent authenticatedBarber = await App.Database.AuthenticateAgentAsync(email, password);
            return authenticatedBarber;
        }

        public async Task<Client> AuthenticateClientAsync(string email, string password)
        {
            // Autentificare ca si client
            Client authenticatedClient = await App.Database.AuthenticateClientAsync(email, password);
            return authenticatedClient;
        }

    }
}
