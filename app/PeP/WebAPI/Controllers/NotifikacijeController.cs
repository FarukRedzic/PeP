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

namespace WebAPI.Controllers
{
    public class NotifikacijeController : ApiController
    {
        private DBContext db = new DBContext();


        [Route("api/Notifikacije/GetNotifikacijes/{KorisnikId}")]
        public List<Notifikacije> GetNotifikacijes(int KorisnikId) {
            return db.Notifikacije.Where(x => x.KorisnikId == KorisnikId && !x.isNeaktivna).ToList();
        }

        // Ništim notifikaciju nakon što otvorim dolazne zahtjeve
        [Route("api/Notifikacije/GetNotifikacijeDolazniZahtjevi/{KorisnikId}")]
        public List<Notifikacije> GetNotifikacijeDolazniZahtjevi(int KorisnikId) {
            return db.Notifikacije.Where(x => (x.KorisnikId == KorisnikId) && (!x.isNeaktivna) && x.VrstaNotifikacijeId == 1).ToList();
        }

        // Ništim notifikaciju nakon što otvorim aktivne odlazne narudžbe
        [Route("api/Notifikacije/GetNotifikacijeOdlazniPotvrdjeni/{KorisnikId}")]
        public List<Notifikacije> GetNotifikacijeOdlazniZahtjevi(int KorisnikId) {
            return db.Notifikacije.Where(x => (x.KorisnikId == KorisnikId) && (!x.isNeaktivna) && (x.VrstaNotifikacijeId == 2)).ToList();
        }
        
        // GET: api/Notifikacije
        public IQueryable<Notifikacije> GetNotifikacije()
        {
            return db.Notifikacije;
        }

        // GET: api/Notifikacije/5
        [ResponseType(typeof(Notifikacije))]
        public IHttpActionResult GetNotifikacije(int id)
        {
            Notifikacije notifikacije = db.Notifikacije.Find(id);
            if (notifikacije == null)
            {
                return NotFound();
            }

            return Ok(notifikacije);
        }

        [HttpPut]
        // PUT: api/Notifikacije/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNotifikacije(int id, Notifikacije notifikacije)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != notifikacije.Id)
            {
                return BadRequest();
            }

            notifikacije.Korisnik = null;
            notifikacije.Narudzba = null;
            notifikacije.Proizvod = null;
            notifikacije.VrstaNotifikacije = null;
            db.Entry(notifikacije).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotifikacijeExists(id))
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

        // POST: api/Notifikacije
        [ResponseType(typeof(Notifikacije))]
        public IHttpActionResult PostNotifikacije(Notifikacije notifikacije)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Notifikacije.Add(notifikacije);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = notifikacije.Id }, notifikacije);
        }

        // DELETE: api/Notifikacije/5
        [ResponseType(typeof(Notifikacije))]
        public IHttpActionResult DeleteNotifikacije(int id)
        {
            Notifikacije notifikacije = db.Notifikacije.Find(id);
            if (notifikacije == null)
            {
                return NotFound();
            }

            db.Notifikacije.Remove(notifikacije);
            db.SaveChanges();

            return Ok(notifikacije);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NotifikacijeExists(int id)
        {
            return db.Notifikacije.Count(e => e.Id == id) > 0;
        }
    }
}