using PCL.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using WebAPI.DAL;
using WebAPI.Models;
using WebAPI.ViewModels;

namespace WebAPI.Util {
    public class Recommender 
    {
        WebAPIHelper serviceNarudzbe = new WebAPIHelper("http://localhost:61718/", "api/Narudzba");
        WebAPIHelper serviceProizvodi = new WebAPIHelper("http://localhost:61718/", "api/Proizvod");
        DBContext db = new DBContext();
        //Ostali proizvodi
        Dictionary<int, List<Dojam>> proizvodi = new Dictionary<int, List<Dojam>>();
        public int LogiraniId;

        public List<Proizvod> GetSlicneProizvode(int ProizvodId, int LogiraniId) 
        {
            this.LogiraniId = LogiraniId;
            UcitajOstaleProizvode(ProizvodId);
            List<Dojam> ocjenePosmatranogProizvoda = db.Dojam.Where(x => x.Narudzba.ProizvodId == ProizvodId).OrderBy(x => x.Narudzba.KorisnikId).ToList();

            List<Dojam> zajednickeOcjenePosmatrani = new List<Dojam>();
            List<Dojam> zajednickeOcjeneDrugi = new List<Dojam>();
            List<Proizvod> preporuceniProizvodi = new List<Proizvod>();

            foreach (var p in proizvodi)
            {
                foreach (Dojam d in ocjenePosmatranogProizvoda) 
                {
                    if (p.Value.Where(x => x.Narudzba.KorisnikId == d.Narudzba.KorisnikId).Count() > 0) 
                    {
                        zajednickeOcjenePosmatrani.Add(d);
                        zajednickeOcjeneDrugi.Add(p.Value.Where(x => x.Narudzba.KorisnikId == d.Narudzba.KorisnikId).First());
                    }
                }
                double slicnost = GetSlicnost(zajednickeOcjenePosmatrani, zajednickeOcjeneDrugi);
                double Threshold = 0.5;

                if (slicnost > Threshold) 
                {
                    HttpResponseMessage responseProizvod = serviceProizvodi.GetResponse(p.Key.ToString());
                    if (responseProizvod.IsSuccessStatusCode)
                        preporuceniProizvodi.Add(responseProizvod.Content.ReadAsAsync<Proizvod>().Result);

                    zajednickeOcjenePosmatrani.Clear();
                    zajednickeOcjeneDrugi.Clear();
                }
            }

            // Pokupiti, preko procedure, proizvode iste kategorije posmatranog proizvoda, da je aktivan i da proizvod ne pripada trgovini(tj. da pripada obicnom korisniku)
            // Filtrirati rezultate tako da uzmemo proizvode od korisnika samo ciji je prosjecni dojam > 7.5 (procedura)

            List<Proizvod> proizvodiObicniKorisnici;
            HttpResponseMessage response = serviceProizvodi.GetResponse(ProizvodId.ToString());
            Proizvod posmatraniProizvod = response.Content.ReadAsAsync<Proizvod>().Result;
            HttpResponseMessage responseProizvodi = serviceProizvodi.GetResponseParams("GetSlicniProizvodiObicniKorisnik", new string[] { posmatraniProizvod.KategorijaId.ToString(), LogiraniId.ToString(), ProizvodId.ToString() });
            proizvodiObicniKorisnici = responseProizvodi.Content.ReadAsAsync<List<Proizvod>>().Result;

            // Balans preporucenih proizvoda izmedju trgovine i korisnika
            int brTrgovina = preporuceniProizvodi.Count;
            int brKorisnik = proizvodiObicniKorisnici.Count;
            List<Proizvod> preporuka = new List<Proizvod>();

            if (brTrgovina >= 5 && brKorisnik >= 5) {
                for (int i = 0; i < 5; i++) {
                    preporuka.Add(preporuceniProizvodi[i]);
                    preporuka.Add(proizvodiObicniKorisnici[i]);
                }
                return preporuka;
            }
            else if (brTrgovina < 5 && brKorisnik < 5) {
                foreach (Proizvod item in preporuceniProizvodi)
                    preporuka.Add(item);
                foreach (Proizvod item in proizvodiObicniKorisnici)
                    preporuka.Add(item);
                return preporuka;
            }

            else if (brTrgovina + brKorisnik >= 10) {
                for (int i = 0; i < 10; i++) {
                    if (brTrgovina > 0) {
                        preporuka.Add(preporuceniProizvodi[i]);
                        brTrgovina--;
                    }
                    if (brKorisnik > 0) {
                        preporuka.Add(proizvodiObicniKorisnici[i]);
                        brKorisnik--;
                    }
                }
                return preporuka;
            }
            else {
                for (int i = 0; i < brTrgovina + brKorisnik; i++) {
                    if (brTrgovina > 0) {
                        preporuka.Add(preporuceniProizvodi[i]);
                        brTrgovina--;
                    }
                    if (brKorisnik > 0) {
                        preporuka.Add(proizvodiObicniKorisnici[i]);
                        brKorisnik--;
                    }
                    return preporuka;
                }
            }
            return preporuka;
        }

        private double GetSlicnost(List<Dojam> zajednickeOcjenePosmatrani, List<Dojam> zajednickeOcjeneDrugi)
        {
            if (zajednickeOcjenePosmatrani.Count != zajednickeOcjeneDrugi.Count)
                return 0;

            int brojnik = 0;
            double nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < zajednickeOcjenePosmatrani.Count; i++) 
            {
                brojnik = zajednickeOcjenePosmatrani[i].Ocjena * zajednickeOcjeneDrugi[i].Ocjena;   // unakrsno mnozenje
                nazivnik1 += zajednickeOcjenePosmatrani[i].Ocjena * zajednickeOcjenePosmatrani[i].Ocjena; //euklidska udaljenost
                nazivnik2 += zajednickeOcjeneDrugi[i].Ocjena * zajednickeOcjeneDrugi[i].Ocjena; // euklidska udaljenost
            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);

            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return nazivnik;
            return brojnik / nazivnik;
        }

        private void UcitajOstaleProizvode(int proizvodId)
        {
            List<Dojam> ocjene;
            List<Proizvod> aktivniProizvodi = db.Proizvod.Where(x => x.Id != proizvodId && x.isAktivan && x.KorisnikId != LogiraniId).ToList();
            
            //Historija kupljenih artikala trenutno logiranog, kako se oni ne bi našli u preporuci
            HttpResponseMessage responseHistorija = serviceNarudzbe.GetResponseParams("GetHistorijaKupljenih", new string[] { LogiraniId.ToString()});
            List<int> historijaKupljenih = responseHistorija.Content.ReadAsAsync<List<int>>().Result;

            for (int i = 0; i < aktivniProizvodi.Count; i++) {
                for (int j = 0; j < historijaKupljenih.Count; j++) {
                    if (aktivniProizvodi[i].Id == historijaKupljenih[j])
                        aktivniProizvodi.Remove(aktivniProizvodi[i]);
                }
            }


            foreach (Proizvod p in aktivniProizvodi) {
                ocjene = db.Dojam.Where(x => x.Narudzba.ProizvodId == p.Id).OrderBy(x => x.Narudzba.KorisnikId).ToList();
                if (ocjene.Count > 0)
                    proizvodi.Add(p.Id, ocjene);
            }
        }
    }
}