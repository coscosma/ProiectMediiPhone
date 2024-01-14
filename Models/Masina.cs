using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMediiPhone.Models
{
    public class Masina
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Marca { get; set; }

        [MaxLength(50)]
        public string Model { get; set; }

        [MaxLength(25)]
        public string TipCombustibil { get; set; }

        [MaxLength(50)]
        public string Categorie { get; set; }

        [MaxLength(30)]
        public string Culoare { get; set; }

        public int Putere { get; set; }

        public int NrLocuri { get; set; }

        public int An { get; set; }

        public decimal? Pret { get; set; }



    }
}
