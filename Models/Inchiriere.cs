using SQLite;
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
        public int? ClientID { get; set; }

        public Client? Client { get; set; }

        public int? MasinaID { get; set; }

        public Masina? Masina { get; set; }

        public DateTime DataProgramarii { get; set; }


    }
}
