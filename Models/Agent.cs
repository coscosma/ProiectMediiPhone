using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Attributes;
using ProiectMediiPhone.Autentificare;


namespace ProiectMediiPhone.Models
{
    public class Agent
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(50), Unique]
        public string Nume { get; set; }

        [MaxLength(50), Unique]
        public string Prenume { get; set; }

        [MaxLength(10), Unique]
        public string Telefon { get; set; }

        [MaxLength(50)]
        public string Parola { get; set; }

        [MaxLength(50), Unique]
        public string Email { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Inchiriere> Inchirieri { get; set; }

    }
}
