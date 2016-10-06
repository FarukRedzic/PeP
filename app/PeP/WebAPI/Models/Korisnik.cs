using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [StringLength(450)]
        [Index(IsUnique = true)]
        public string Email { get; set; }
        public string Telefon { get; set; }
        [StringLength(450)]
        [Index(IsUnique = true)]
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public byte[] Slika { get; set; }
        public int Aktivan { get; set; }
        public bool IsTrgovina { get; set; }
        public string Adresa { get; set; }


        public virtual Opstina Opstina { get; set; }
        public int OpstinaId { get; set; }
    }
}