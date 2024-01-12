using SQLite;
using SQLiteNetExtensions.Attributes;
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

        [MaxLength(30)]
        public string Nume { get; set; }

        [MaxLength(30)]
        public string Prenume {  get; set; }

        [MaxLength(100)]
        public string? Adresa { get; set; }

        [MaxLength(50), Unique]
        public string? Email { get; set; }

        [MaxLength(30)]
        public string Parola {  get; set; }

        [MaxLength(20)]
        public string? NumarTel { get; set; }

        [OneToMany(CascadeOperations=CascadeOperation.All)]
        public List<Inchiriere> Inchirieri { get; set; }

    }
}
