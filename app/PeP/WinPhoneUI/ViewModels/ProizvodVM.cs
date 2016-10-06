using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinPhoneUI.ViewModels {
    public class ProizvodVM {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public byte[] Slika { get; set; }
        public string Kategorija { get; set; }
        public bool Aktivan { get; set; }
        public bool Obrisan { get; set; }
        public string Vlasnik { get; set; }
        public DateTime Postavio { get; set; }
        public bool Koristen { get; set; }
    }
}