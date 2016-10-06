using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.ViewModels {
    public class LogoviVM {
        public int Id { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public bool Uspjesnost { get; set; }
        public string Korisnik { get; set; }
    }
}