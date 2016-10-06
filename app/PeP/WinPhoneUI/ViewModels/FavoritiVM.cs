using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinPhoneUI.ViewModels {
    public class FavoritiVM {
        public int FavoritId { get; set; }
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public byte[] Slika { get; set; }
        public string Kategorija { get; set; }
        public int ProizvodId { get; set; }
    }
}