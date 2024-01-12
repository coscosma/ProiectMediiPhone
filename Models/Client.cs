using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMediiPhone.Models
{
    public class Client
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }
        public string Nume { get; set; }

        public string? Adresa { get; set; }

        public string? Email { get; set; }

        public string? NumarTel { get; set; }

        public ICollection<Inchiriere>? Inchirieri { get; set; }

    }
}
