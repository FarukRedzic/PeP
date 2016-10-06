using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Komentar
    {
        public int Id { get; set; }
        public string Sadrzaj { get; set; }

        public virtual Proizvod Proizvod { get; set; }
        public int ProizvodId { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
    }
}