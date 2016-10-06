using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.ViewModels {
    public class VrsteDojamVM {
        public int Id { get; set; }
        public string Dojam { get; set; }
    }
    public class DojamVM {
        public static List<VrsteDojamVM> VrsteDojam = new List<VrsteDojamVM>();
        public int DojamId { get; set; }
        public string Sadrzaj { get; set; }
        public string OstavioDojam { get; set; }
        public int Ocjena { get; set; }
        public string Proizvod { get; set; }
        public byte[] Slika { get; set; }
        public int KorisnikId { get; set; }

        public string NaslovReport { get; set; }
    }
}