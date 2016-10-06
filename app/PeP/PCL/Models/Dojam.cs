using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCL.Models
{
    public class Dojam
    {
        public int Id { get; set; }
        public string Sadrzaj { get; set; }
        public int Ocjena { get; set; }

        public virtual Narudzba Narudzba { get; set; }
        public int NarudzbaId { get; set; }

        public int? KorisnikId { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}