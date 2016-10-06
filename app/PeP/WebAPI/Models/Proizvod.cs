using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Proizvod
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public byte[] Slika { get; set; }
        public bool isAktivan { get; set; }
        public string Opis { get; set; }
        public bool isDeleted { get; set; }
        public DateTime Postavio { get; set; }
        public bool Koristen { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
        public virtual Kategorija Kategorija { get; set; }
        public int KategorijaId { get; set; }

    }
}