using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMediiPhone.Models
{
    public class Producator
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }
        public string Nume { get; set; }

        public ICollection<Masina>? Masini { get; set; }


    }
}
