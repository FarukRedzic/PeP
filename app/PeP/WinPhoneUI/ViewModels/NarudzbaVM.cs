using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinPhoneUI.ViewModels {
    public class NarudzbaVM {

        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public string Proizvod { get; set; }
        public bool Zakljucena { get; set; }
        public bool Otkazana { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public bool UToku { get; internal set; }
        public string Kupac { get; set; }
        public string Cijena { get; set; }
        public byte[] Slika { get; set;}
        public int ProizvodId { get; set; }
        public string Prodavac { get; set; }
    }
}