using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPhoneUI.ViewModels {
    public class NovaNarudzbaVM 
    {
        public int Id { get; set; }
        public string BrojNarudzbe { get; set; }
        public DateTime DatumVrijeme { get; set; }

        public string NapomenaPosiljaoc { get; set; }
        public string NapomenaPrimaoc { get; set; }
        public int PosiljaocId { get; set; }
        public string Primaoc { get; set; }
        public int ProizvodId { get; set; }
        public string Proizvod { get; set; }
        public string Cijena { get; set; }
    }
}
