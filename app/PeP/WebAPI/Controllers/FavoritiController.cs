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
    public class FavoritiController : ApiController
    {
        private DBContext db = new DBContext();

        [Route("api/Favoriti/GetFavoritiByParams/{KorisnikId}/{Naziv}/{KategorijaId}/{CijenaOD}/{CijenaDO}")]
        public List<FavoritiVM> GetProizvodiByParameters(int KorisnikId, string Naziv, int KategorijaId, double CijenaOD, double CijenaDO) {
            List<FavoritiVM> favoriti = db.Favoriti.Where(x => (x.KorisnikId == KorisnikId) && (x.Proizvod.Naziv.Contains(Naziv) || Naziv == "null") && (x.Proizvod.KategorijaId == KategorijaId || KategorijaId == -1)&& x.Proizvod.Cijena >= CijenaOD && x.Proizvod.Cijena <= CijenaDO).Select(x => new FavoritiVM() { NaslovReport = x.Korisnik.Ime + " " + x.Korisnik.Prezime , FavoritId = x.Id, Cijena = x.Proizvod.Cijena, Kategorija = x.Proizvod.Kategorija.Naziv, Naziv = x.Proizvod.Naziv, Slika = x.Proizvod.Slika, Vlasnik = x.Proizvod.Korisnik.Ime + " " + x.Proizvod.Korisnik.Prezime}).ToList();
            return favoriti;
        }

        [Route("api/Favoriti/GetFavoritiByParams/{KorisnikId}/{KategorijaId}")]
        public List<FavoritiVM> GetProizvodiByParameters(int KorisnikId, int KategorijaId) {
            List<FavoritiVM> favoriti = db.Favoriti.Where(x => (x.KorisnikId == KorisnikId && x.Proizvod.isDeleted == false) && (x.Proizvod.KategorijaId == KategorijaId || KategorijaId == -1 || KategorijaId == 0)).Select(x => new FavoritiVM() { FavoritId = x.Id, Cijena = x.Proizvod.Cijena, Kategorija = x.Proizvod.Kategorija.Naziv, Naziv = x.Proizvod.Naziv, Slika = x.Proizvod.Slika, ProizvodId = x.ProizvodId, Vlasnik = x.Proizvod.Korisnik.Ime + " " + x.Proizvod.Korisnik.Prezime }).ToList();
            return favoriti;
        }


        // GET: api/Favoriti
        public IQueryable<Favoriti> GetFavoriti()
        {
            return db.Favoriti;
        }

        // GET: api/Favoriti/5
        [ResponseType(typeof(Favoriti))]
        public IHttpActionResult GetFavoriti(int id)
        {
            Favoriti favoriti = db.Favoriti.Find(id);
            if (favoriti == null)
            {
                return NotFound();
            }

            return Ok(favoriti);
        }

        // PUT: api/Favoriti/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFavoriti(int id, Favoriti favoriti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != favoriti.Id)
            {
                return BadRequest();
            }

            favoriti.Korisnik = null;
            favoriti.Proizvod = null;
            db.Entry(favoriti).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoritiExists(id))
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

        // POST: api/Favoriti
        [ResponseType(typeof(Favoriti))]
        public IHttpActionResult PostFavoriti(Favoriti favoriti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Favoriti.Add(favoriti);
            try {
                db.SaveChanges();
            }
            catch (DbUpdateException ex) {
                throw CustomException(Util.MessagesHandler.GetMessage(Util.ExceptionHandler.HandleSQLException(ex)), HttpStatusCode.Conflict);
            }

            return CreatedAtRoute("DefaultApi", new { id = favoriti.Id }, favoriti);
        }

        private HttpResponseException CustomException(string reason, HttpStatusCode status) {
            HttpResponseMessage msg = new HttpResponseMessage() {
                StatusCode = status,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };
            return new HttpResponseException(msg);
        }

        // DELETE: api/Favoriti/5
        [ResponseType(typeof(Favoriti))]
        public IHttpActionResult DeleteFavoriti(int id)
        {
            Favoriti favoriti = db.Favoriti.Find(id);
            if (favoriti == null)
            {
                return NotFound();
            }

            db.Favoriti.Remove(favoriti);
            db.SaveChanges();

            return Ok(favoriti);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FavoritiExists(int id)
        {
            return db.Favoriti.Count(e => e.Id == id) > 0;
        }
    }
}