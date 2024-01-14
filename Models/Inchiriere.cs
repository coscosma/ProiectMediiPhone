using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMediiPhone.Models
{
    public class Inchiriere
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Client))]
        public int? ClientID { get; set; }

        [ManyToOne(CascadeOperations = CascadeOperation.CascadeRead)]
        public Client? Client { get; set; }

        [ForeignKey(typeof(Masina))]
        public int? MasinaID { get; set; }

        [ManyToOne(CascadeOperations = CascadeOperation.CascadeRead)]
        public Masina? Masina { get; set; }

        public DateTime DataProgramarii { get; set; }
    }
}
