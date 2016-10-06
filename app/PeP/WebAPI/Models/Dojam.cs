using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Dojam {
        public int Id { get; set; }
        public string Sadrzaj { get; set; }
        public int Ocjena { get; set; }

        [Index(IsUnique = true)]
        public int NarudzbaId { get; set; }
        public virtual Narudzba Narudzba { get; set; }

        public int? KorisnikId { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }

}