using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCL.Models
{
    public class Favoriti
    {
        public int Id { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
        public virtual Proizvod Proizvod { get; set; }
        public int ProizvodId { get; set; }
    }
}