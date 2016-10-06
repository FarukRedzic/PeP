using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCL.Models
{
    public class Poruka
    {
        public int Id { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public bool Procitana { get; set; }
        public bool isDeletedPoslana { get; set; }
        public bool isDeletedPrimljena { get; set; }

        public virtual Korisnik Posiljaoc { get; set; }
        public int PosiljaocId { get; set; }
        public virtual Korisnik Primaoc { get; set; }
        public int PrimaocId { get; set; }
    }
}