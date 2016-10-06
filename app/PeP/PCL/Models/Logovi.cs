using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCL.Models
{
    public class Logovi
    {
        public int Id { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public bool Uspjesnost { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public int? KorisnikId { get; set; }
    }
}