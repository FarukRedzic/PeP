using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCL.Models
{
    public class Narudzba
    {
        public int Id { get; set; }
        public string BrojNarudzbe { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public bool isZakljucena { get; set; }
        public bool isOtkazana { get; set; }
        public bool isUToku { get; set; }
        public string NapomenaPosiljaoc { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
        public virtual Proizvod Proizvod { get; set; }
        public int ProizvodId { get; set; }


    }
}