using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PCL.Models
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public byte[] Slika { get; set; }
        public int Aktivan { get; set; }
        public bool IsTrgovina { get; set; }
        public string Adresa { get; set; }


        public virtual Opstina Opstina { get; set; }

        //[ForeignKey("OpstinaId")]
        public int OpstinaId { get; set; }
    }
}