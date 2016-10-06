using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Favoriti
    {
        public int Id { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        [Index("IX_Favoriti", 1, IsUnique = true)]
        public int KorisnikId { get; set; }
        public virtual Proizvod Proizvod { get; set; }
        [Index("IX_Favoriti", 2, IsUnique = true)]
        public int ProizvodId { get; set; }
    }
}