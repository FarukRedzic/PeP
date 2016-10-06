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
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    public class DojamController : ApiController
    {
        private DBContext db = new DBContext();
        
        [Route("api/Dojam/GetDojmoviByParams/{KorisnikId}/{Ime}/{Prezime}/{OcjenaOD}/{OcjenaDO}")]
        public List<DojamVM> GetDojmoviByParams(int KorisnikId, string Ime, string Prezime, int OcjenaOD, int OcjenaDO) {
            List<DojamVM> dojmovi = db.Dojam.Where(x => (x.Narudzba.Proizvod.KorisnikId == KorisnikId) && (OcjenaOD <= x.Ocjena && OcjenaDO >= x.Ocjena) && (x.Narudzba.Korisnik.Ime.Contains(Ime) || Ime == "null") && (x.Narudzba.Korisnik.Prezime.Contains(Prezime) || Prezime == "null")).Select(x => new DojamVM() { NaslovReport = x.Narudzba.Proizvod.Korisnik.Ime + " " + x.Narudzba.Proizvod.Korisnik.Prezime, DojamId = x.Id, OstavioDojam = x.Narudzba.Korisnik.Ime + " " + x.Narudzba.Korisnik.Prezime, Ocjena = x.Ocjena, Sadrzaj = x.Sadrzaj, Proizvod = x.Narudzba.Proizvod.Naziv}).ToList();
            return dojmovi;
        }

        //Phone
        [Route("api/Dojam/GetDojmoviByParams/{KorisnikId}/{Ocjena}")]
        public List<DojamVM> GetDojmoviByParams(int KorisnikId, int Ocjena) {
            List<DojamVM> dojmovi = db.Dojam.Where(x => (x.Narudzba.Proizvod.KorisnikId == KorisnikId && x.Narudzba.Proizvod.isDeleted == false) && (Ocjena == x.Ocjena || Ocjena == -1 || Ocjena == 0)).Select(x => new DojamVM() { DojamId = x.Id, OstavioDojam = x.Narudzba.Korisnik.Ime + " " + x.Narudzba.Korisnik.Prezime, Ocjena = x.Ocjena, Sadrzaj = x.Sadrzaj, Proizvod = x.Narudzba.Proizvod.Naziv, Slika = x.Narudzba.Korisnik.Slika, KorisnikId = x.Narudzba.KorisnikId }).ToList();
            return dojmovi;
        }

        [Route("api/Dojam/GetOcjeneByParams/{ProizvodId}/{Ime}/{Prezime}/{OcjenaOD}/{OcjenaDO}")]
        public List<OcjeneProizvodVM> GetOcjeneByParams(int ProizvodId, string Ime, string Prezime, int OcjenaOD, int OcjenaDO) {
            List<OcjeneProizvodVM> ocjene = db.Dojam.Where(x => (x.Narudzba.Proizvod.Id == ProizvodId) && (OcjenaOD <= x.Ocjena && OcjenaDO >= x.Ocjena) && (x.Narudzba.Korisnik.Ime.Contains(Ime) || Ime == "null") && (x.Narudzba.Korisnik.Prezime.Contains(Prezime) || Prezime == "null")).Select(x => new OcjeneProizvodVM() { Ocijenio = x.Narudzba.Korisnik.Ime + " " + x.Narudzba.Korisnik.Prezime, Ocjena = (double)x.Ocjena, Komentar = x.Sadrzaj, Proizvod = x.Narudzba.Proizvod.Naziv }).ToList();
            return ocjene;
        }
        [Route("api/Dojam/GetPouzdanost/{KorisnikId}")]
        public string GetPouzdanost(int KorisnikId) {
            try {
                double pouzdanost = db.Dojam.Where(x => x.Narudzba.Proizvod.KorisnikId == KorisnikId).Average(x => x.Ocjena);
                return Math.Round(pouzdanost,2).ToString();
            }
            catch (InvalidOperationException) {
                return "-";
            }
        }

        [Route("api/Dojam/GetProsjecnaOcjena/{ProizvodId}")]
        public string GetProsjecnaOcjena(int ProizvodId) {
            try {
                string pouzdanost = db.Dojam.Where(x => x.Narudzba.Proizvod.Id == ProizvodId).Average(x => x.Ocjena).ToString();
                return pouzdanost;
            }
            catch (InvalidOperationException) {
                return "-";
            }
        }


        // GET: api/Dojam
        public IQueryable<Dojam> GetDojam()
        {
            return db.Dojam;
        }

        // GET: api/Dojam/5
        [ResponseType(typeof(Dojam))]
        public IHttpActionResult GetDojam(int id)
        {
            Dojam dojam = db.Dojam.Find(id);
            if (dojam == null)
            {
                return NotFound();
            }

            return Ok(dojam);
        }

        // PUT: api/Dojam/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDojam(int id, Dojam dojam)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dojam.Id)
            {
                return BadRequest();
            }

            dojam.Narudzba = null;
            dojam.Korisnik = null;
            db.Entry(dojam).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DojamExists(id))
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

        // POST: api/Dojam
        [ResponseType(typeof(Dojam))]
        public IHttpActionResult PostDojam(Dojam dojam)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Dojam.Add(dojam);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dojam.Id }, dojam);
        }

        // DELETE: api/Dojam/5
        [ResponseType(typeof(Dojam))]
        public IHttpActionResult DeleteDojam(int id)
        {
            Dojam dojam = db.Dojam.Find(id);
            if (dojam == null)
            {
                return NotFound();
            }

            db.Dojam.Remove(dojam);
            db.SaveChanges();

            return Ok(dojam);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DojamExists(int id)
        {
            return db.Dojam.Count(e => e.Id == id) > 0;
        }
    }
}