using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCL.Models {

    public class Notifikacije {
        public int Id { get; set; }
        public bool isNeaktivna { get; set; }
        public string KomentarisaoProizvod { get; set; }
        public string PoslaoPoruku { get; set; }

        public int? NarudzbaId { get; set; }
        public virtual Narudzba Narudzba{ get; set; }
        public int? VrstaNotifikacijeId { get; set; }
        public virtual VrstaNotifikacije VrstaNotifikacije { get; set; }
        public int? KorisnikId { get; set; } // if (narudzbaId == null) -> poruka prema korisniku
        public virtual Korisnik Korisnik { get; set; }
        public int? ProizvodId { get; set; } // komentar na proizvod
        public virtual Proizvod Proizvod { get; set; }
    }
}