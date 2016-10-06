using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class KorisniciUloge
    {
        public int Id { get; set; }

        public virtual Korisnik Korisnik  { get; set; }
        public int KorisnikId { get; set; }
        public virtual Uloga Uloga { get; set; }
        public int UlogaId { get; set; }
    }
}