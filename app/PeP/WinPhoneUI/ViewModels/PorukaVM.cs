using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPhoneUI.ViewModels {
    public class PorukaVM {
        public int Id { get; set; }
        public int KorisnikId { get; set; }
        public byte[] Slika { get; set; }
        public bool chkProcitao { get; set; }
        public string Naslov { get; set; }
        public string Poslao { get; set; }
        public string Primio { get; set; }
    }
}
