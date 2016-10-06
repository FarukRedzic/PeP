using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinPhoneUI.ViewModels {
    public class KomentarVM {
        public int Id { get; set; }
        public string Sadrzaj { get; set; }
        public string Komentarisao { get; set; }
        public byte[] Slika { get; set; }
        public int KorisnikId { get; set; }
    }
}