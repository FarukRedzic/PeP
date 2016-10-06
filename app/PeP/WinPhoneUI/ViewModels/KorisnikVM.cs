using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPhoneUI.ViewModels
{
    public class KorisnikVM
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public string Opstina { get; set; }
        public byte[] Slika { get; set; }
        public int Aktivan { get; set; }
        public bool? chkKorisnickiNalog { get; set; }
        public int OpstinaId { get; set; }
        public int UlogaId { get; set; }
        public bool? IsTrgovina { get; set; }
        public string Adresa { get; set; }
        public string ImePrezime { get; set; }
        public string Popularnost { get; set; }
    }
}
