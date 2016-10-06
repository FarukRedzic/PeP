using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.DAL;
using WebAPI.Models;
using WebAPI.Util;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    public class NarudzbaController : ApiController
    {
        private DBContext db = new DBContext();

        [Route("api/Narudzba/GetDozvola/{KorisnikId}/{ProizvodId}")]
        public int GetDozvola(int KorisnikId, int ProizvodId)
        {
            try {
                return db.Narudzba.Where(x => (x.KorisnikId == KorisnikId && x.ProizvodId == ProizvodId) && (!x.Proizvod.Korisnik.IsTrgovina)).Count();
            }
            catch (Exception) {

                return 0;
            }
        }

        [Route("api/Narudzba/GetUnique")]
        public int GetUnique() {
            try {
                return db.Narudzba.Max(x => x.Id);
            }
            catch (Exception) {
                return 0;
            }
        }

        [Route("api/Narudzba/GetBrojZahtjeva/{KorisnikId}")]
        public int GetBrojZahtjeva(int KorisnikId) {
            try {
                return db.Narudzba.Where(x => (x.Proizvod.KorisnikId == KorisnikId || x.KorisnikId == KorisnikId) && (x.isUToku == false && x.isOtkazana == false && x.isZakljucena == false)).Count();
            }
            catch (Exception) {
                return 0;
            }
        }

        [Route("api/Narudzba/GetBrojZahtjevaDolaznih/{KorisnikId}")]
        public int GetBrojZahtjevaDolaznih(int KorisnikId) {
            try {
                return db.Narudzba.Where(x => (x.Proizvod.KorisnikId == KorisnikId) && (x.isUToku == false && x.isOtkazana == false && x.isZakljucena == false)).Count();
            }
            catch (Exception) {
                return 0;
            }
        }


        [Route("api/Narudzba/GetBrojZahtjevaOdlaznih/{KorisnikId}")]
        public int GetBrojZahtjevaOdlaznih(int KorisnikId) {
            try {
                return db.Narudzba.Where(x => (x.KorisnikId == KorisnikId) && (x.isUToku == false && x.isOtkazana == false && x.isZakljucena == false)).Count();
            }
            catch (Exception) {
                return 0;
            }
        }



        [Route("api/Narudzba/GetBrojAktivnih/{KorisnikId}")]
        public int GetBrojAktivnih(int KorisnikId) {
            try {
                return db.Narudzba.Where(x => (x.Proizvod.KorisnikId == KorisnikId || x.KorisnikId == KorisnikId) && x.isUToku).Count();
            }
            catch (Exception) {
                return 0;
            }
        }

        [Route("api/Narudzba/GetBrojAktivnihDolaznih/{KorisnikId}")]
        public int GetBrojAktivnihDolaznih(int KorisnikId) {
            try {
                return db.Narudzba.Where(x => (x.Proizvod.KorisnikId == KorisnikId) && x.isUToku).Count();
            }
            catch (Exception) {
                return 0;
            }
        }


        [Route("api/Narudzba/GetBrojAktivnihOdlaznih/{KorisnikId}")]
        public int GetBrojAktivnihOdlaznih(int KorisnikId) {
            try {
                return db.Narudzba.Where(x => (x.KorisnikId == KorisnikId) && x.isUToku).Count();
            }
            catch (Exception) {
                return 0;
            }
        }


        [Route("api/Narudzba/GetAktivneDolazne/{KorisnikId}")]
        public List<NarudzbaVM> GetAktivneDolazne(int KorisnikId) {
                return db.Narudzba.Where(x => (x.Proizvod.KorisnikId == KorisnikId) && x.isUToku).Select(x=> new NarudzbaVM() { NarudzbaId = x.Id, Kupac = x.Korisnik.KorisnickoIme, Proizvod = x.Proizvod.Naziv, DatumVrijeme = x.DatumVrijeme, Slika = x.Proizvod.Slika }).ToList();
        }

        [Route("api/Narudzba/GetAktivneOdlazne/{KorisnikId}")]
        public List<NarudzbaVM> GetAktivneOdlazne(int KorisnikId) {
                return db.Narudzba.Where(x => (x.KorisnikId == KorisnikId) && x.isUToku).Select(x => new NarudzbaVM() { NarudzbaId = x.Id, Prodavac = x.Proizvod.Korisnik.KorisnickoIme, Proizvod = x.Proizvod.Naziv, DatumVrijeme = x.DatumVrijeme, Slika = x.Proizvod.Slika }).ToList();
        }

        [Route("api/Narudzba/GetDolazniZahtjevi/{KorisnikId}")]
        public List<NarudzbaVM> GetDolazniZahtjevi(int KorisnikId) {
            return db.Narudzba.Where(x => (x.Proizvod.KorisnikId == KorisnikId) && (x.isUToku == false && x.isOtkazana == false && x.isZakljucena == false)).Select(x => new NarudzbaVM() { NarudzbaId = x.Id, Kupac = x.Korisnik.KorisnickoIme, Proizvod = x.Proizvod.Naziv, DatumVrijeme = x.DatumVrijeme, Slika = x.Proizvod.Slika }).ToList();
        }


        [Route("api/Narudzba/GetOdlazniZahtjevi/{KorisnikId}")]
        public List<NarudzbaVM> GetOdlazniZahtjevi(int KorisnikId) {
            return db.Narudzba.Where(x => (x.KorisnikId == KorisnikId) && (x.isUToku == false && x.isOtkazana == false && x.isZakljucena == false)).Select(x => new NarudzbaVM() { NarudzbaId = x.Id, Prodavac = x.Proizvod.Korisnik.KorisnickoIme, DatumVrijeme = x.DatumVrijeme, Proizvod = x.Proizvod.Naziv, Slika = x.Proizvod.Slika }).ToList();
        }

        [Route("api/Narudzba/GetBrojOtkazanih/{KorisnikId}")]
        public int GetBrojOtkazanih(int KorisnikId) {
            try {
                return db.Narudzba.Where(x => (x.Proizvod.KorisnikId == KorisnikId || x.KorisnikId == KorisnikId) && x.isOtkazana).Count();
            }
            catch (Exception) {
                return 0;
            }
        }

        [Route("api/Narudzba/GetNarudzbeByParams/{KorisnikId}/{BrojNarudzbe}/{KategorijaId}/{OD}/{DO}")]
        public List<NarudzbaVM> GetNarudzbeByParams(int KorisnikId, string BrojNarudzbe, int KategorijaId, string OD, string DO) {
            DateTime ODDatum = OD.ApiToDateTime(); 
            DateTime DODatum = DO.ApiToDateTime();
            List<NarudzbaVM> narudzbe = db.Narudzba.Where(x => (x.KorisnikId == KorisnikId) && (x.BrojNarudzbe.Contains(BrojNarudzbe) || BrojNarudzbe == "null") && (x.Proizvod.KategorijaId == KategorijaId || KategorijaId == -1) && (x.DatumVrijeme >= ODDatum && x.DatumVrijeme <= DODatum)).Select(x => new NarudzbaVM() { NaslovReport = x.Korisnik.Ime + " "  + x.Korisnik.Prezime , NarudzbaId = x.Id, BrojNarudzbe = x.BrojNarudzbe, DatumVrijeme = x.DatumVrijeme,Proizvod = x.Proizvod.Naziv, Otkazana = x.isOtkazana, Zakljucena = x.isZakljucena, UToku = x.isUToku, Cijena = x.Proizvod.Cijena.ToString(), Slika = x.Proizvod.Slika, ProizvodId = x.ProizvodId }).ToList();
            return narudzbe;
        }

        //Phone-Kupio
        [HttpGet]
        [Route("api/Narudzba/GetKupljeneByParams/{KorisnikId}/{KategorijaId}")]
        public List<NarudzbaVM> GetNarudzbeByParams(int KorisnikId, int KategorijaId) {
            List<NarudzbaVM> narudzbe = db.Narudzba.Where(x =>  ( x.isZakljucena == true && x.Proizvod.isDeleted == false) &&(x.KorisnikId == KorisnikId) && (x.Proizvod.KategorijaId == KategorijaId || KategorijaId == -1  || KategorijaId == 0)).Select(x => new NarudzbaVM() { NarudzbaId = x.Id, BrojNarudzbe = x.BrojNarudzbe, DatumVrijeme = x.DatumVrijeme, Proizvod = x.Proizvod.Naziv, Otkazana = x.isOtkazana, Zakljucena = x.isZakljucena, UToku = x.isUToku, Cijena = x.Proizvod.Cijena.ToString(), Slika = x.Proizvod.Slika, ProizvodId = x.ProizvodId }).ToList();
            return narudzbe;
        }

        [HttpGet]
        [Route("api/Narudzba/GetHistorijaKupljenih/{KorisnikId}")]
        public List<int> GetHistorijaKupljenih(int KorisnikId) {
            List<int> historija = db.Narudzba.Where(x => (x.isZakljucena == true && x.Proizvod.isDeleted == false) && (x.KorisnikId == KorisnikId)).Select(x => x.ProizvodId).ToList();
            return historija;
        }

        [Route("api/Narudzba/GetNarudzbeByParams/{BrojNarudzbe}/{KategorijaId}/{OD}/{DO}")]
        public List<NarudzbaVM> GetNarudzbeByParams(string BrojNarudzbe, int KategorijaId, string OD, string DO) {
            DateTime ODDatum = OD.ApiToDateTime();
            DateTime DODatum = DO.ApiToDateTime();
            List<NarudzbaVM> narudzbe = db.Narudzba.Where(x => (x.BrojNarudzbe.Contains(BrojNarudzbe) || BrojNarudzbe == "null") && (x.Proizvod.KategorijaId == KategorijaId || KategorijaId == -1) && (x.DatumVrijeme >= ODDatum && x.DatumVrijeme <= DODatum)).Select(x => new NarudzbaVM() { NarudzbaId = x.Id, BrojNarudzbe = x.BrojNarudzbe, DatumVrijeme = x.DatumVrijeme, Proizvod = x.Proizvod.Naziv, Otkazana = x.isOtkazana, Zakljucena = x.isZakljucena, UToku = x.isUToku }).ToList();
            return narudzbe;
        }

        [Route("api/Narudzba/GetProdaneByParams/{KorisnikId}/{BrojNarudzbe}/{KategorijaId}/{OD}/{DO}")]
        public List<NarudzbaVM> GetProdaneByParams(int KorisnikId, string BrojNarudzbe, int KategorijaId, string OD, string DO) {
            DateTime ODDatum = OD.ApiToDateTime();
            DateTime DODatum = DO.ApiToDateTime();
            List<NarudzbaVM> narudzbe = db.Narudzba.Where(x => (x.Proizvod.KorisnikId == KorisnikId && x.isZakljucena && x.Proizvod.isDeleted == false) && (x.BrojNarudzbe.Contains(BrojNarudzbe) || BrojNarudzbe == "null") && (x.Proizvod.KategorijaId == KategorijaId || KategorijaId == -1 || KategorijaId == 0) && (x.DatumVrijeme >= ODDatum && x.DatumVrijeme <= DODatum)).Select(x => new NarudzbaVM() { NaslovReport = x.Proizvod.Korisnik.Ime + " " + x.Proizvod.Korisnik.Prezime , NarudzbaId = x.Id, BrojNarudzbe = x.BrojNarudzbe, DatumVrijeme = x.DatumVrijeme, Proizvod = x.Proizvod.Naziv,Zakljucena = x.isZakljucena, Kupac = x.Korisnik.Ime + " " + x.Korisnik.Prezime, Slika = x.Proizvod.Slika, ProizvodId = x.ProizvodId }).ToList();
            return narudzbe;
        }
        // GET: api/Narudzba
        public IQueryable<Narudzba> GetNarudzba()
        {
            return db.Narudzba;
        }

        // GET: api/Narudzba/5
        [ResponseType(typeof(Narudzba))]
        public IHttpActionResult GetNarudzba(int id)
        {
            Narudzba narudzba = db.Narudzba.Find(id);
            if (narudzba == null)
            {
                return NotFound();
            }

            return Ok(narudzba);
        }

        // PUT: api/Narudzba/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNarudzba(int id, Narudzba narudzba)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != narudzba.Id)
            {
                return BadRequest();
            }

            narudzba.Korisnik = null;
            narudzba.Proizvod = null;
            db.Entry(narudzba).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NarudzbaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Narudzba
        [ResponseType(typeof(Narudzba))]
        public IHttpActionResult PostNarudzba(Narudzba narudzba)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Narudzba.Add(narudzba);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = narudzba.Id }, narudzba);
        }

        // DELETE: api/Narudzba/5
        [ResponseType(typeof(Narudzba))]
        public IHttpActionResult DeleteNarudzba(int id)
        {
            Narudzba narudzba = db.Narudzba.Find(id);
            if (narudzba == null)
            {
                return NotFound();
            }

            db.Narudzba.Remove(narudzba);
            db.SaveChanges();

            return Ok(narudzba);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NarudzbaExists(int id)
        {
            return db.Narudzba.Count(e => e.Id == id) > 0;
        }
    }
}