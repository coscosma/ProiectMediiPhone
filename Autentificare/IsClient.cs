using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMediiPhone.Autentificare
{
    public interface ItsClient
    {
        string Email { get; set; }
        string Parola { get; set; }
    }
}
