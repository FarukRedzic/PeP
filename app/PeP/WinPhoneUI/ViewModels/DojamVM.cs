using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinPhoneUI.ViewModels {

    public class DojamVM {
        public int DojamId { get; set; }
        public string Sadrzaj { get; set; }
        public string OstavioDojam { get; set; }
        public int Ocjena { get; set; }
        public string Proizvod { get; set; }
        public byte[] Slika { get; set; }
        public int KorisnikId { get; set; }
    }
}