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
    public class KomentarController : ApiController
    {
        private DBContext db = new DBContext();

        [Route("api/Komentar/GetKomentari/{ProizvodId}/{Ime}/{Prezime}")]
        public List<KomentarVM> GetKomentari(int ProizvodId, string Ime, string Prezime) {
            List<KomentarVM> list = db.Komentar.Where(x => (x.ProizvodId == ProizvodId) && (x.Korisnik.Ime.Contains(Ime) || Ime == "null") && (x.Korisnik.Prezime.Contains(Prezime) || Prezime == "null")).Select(x => new KomentarVM() { Id = x.Id, Sadrzaj = x.Sadrzaj, Komentarisao = x.Korisnik.Ime + " " + x.Korisnik.Prezime, Slika = x.Korisnik.Slika }).ToList();
            return list;
        }

        //Phone
        [Route("api/Komentar/GetKomentari/{ProizvodId}")]
        public List<KomentarVM> GetKomentari(int ProizvodId) {
            return db.Komentar.Where(x => x.ProizvodId == ProizvodId).Select(x => new KomentarVM() { KorisnikId = x.KorisnikId, Id = x.Id, Komentarisao = x.Korisnik.Ime + " " + x.Korisnik.Prezime, Sadrzaj = x.Sadrzaj, Slika = x.Korisnik.Slika }).ToList();
        }

        //Phone
        [Route("api/Komentar/GetBrojKomentara/{ProizvodId}")]
        public int GetBrojKomentara(int ProizvodId) {
            return db.Komentar.Where(x => x.ProizvodId == ProizvodId).Count();
        }

        // GET: api/Komentar
        public IQueryable<Komentar> GetKomentar()
        {
            return db.Komentar;
        }

        // GET: api/Komentar/5
        [ResponseType(typeof(Komentar))]
        public IHttpActionResult GetKomentar(int id)
        {
            Komentar komentar = db.Komentar.Find(id);
            if (komentar == null)
            {
                return NotFound();
            }

            return Ok(komentar);
        }

        // PUT: api/Komentar/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKomentar(int id, Komentar komentar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != komentar.Id)
            {
                return BadRequest();
            }
            komentar.Proizvod = null;
            komentar.Korisnik = null;
            db.Entry(komentar).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KomentarExists(id))
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

        // POST: api/Komentar
        [ResponseType(typeof(Komentar))]
        public IHttpActionResult PostKomentar(Komentar komentar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Komentar.Add(komentar);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = komentar.Id }, komentar);
        }

        // DELETE: api/Komentar/5
        [ResponseType(typeof(Komentar))]
        public IHttpActionResult DeleteKomentar(int id)
        {
            Komentar komentar = db.Komentar.Find(id);
            if (komentar == null)
            {
                return NotFound();
            }

            db.Komentar.Remove(komentar);
            db.SaveChanges();

            return Ok(komentar);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KomentarExists(int id)
        {
            return db.Komentar.Count(e => e.Id == id) > 0;
        }
    }
}