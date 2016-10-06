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
    public class PorukaController : ApiController
    {
        private DBContext db = new DBContext();

        // GET: api/Poruka
        public IQueryable<Poruka> GetPoruka()
        {
            return db.Poruka;
        }

        [Route("api/Poruka/GetBrojPorukaInbox/{KorisnikId}")]
        public int GetBrojPorukaInbox(int KorisnikId) {
            return db.Poruka.Where(x => x.PrimaocId == KorisnikId && !x.isDeletedPrimljena).Count();
        }

        [Route("api/Poruka/GetBrojNeprocitanihInbox/{KorisnikId}")]
        public int GetBrojNeprocitanihInbox(int KorisnikId) {
            return db.Poruka.Where(x => x.PrimaocId == KorisnikId && !x.Procitana && !x.isDeletedPrimljena).Count();
        }

        [Route("api/Poruka/GetBrojPorukaOutbox/{KorisnikId}")]
        public int GetBrojPorukaOutbox(int KorisnikId) {
            return db.Poruka.Where(x => x.PosiljaocId == KorisnikId && !x.isDeletedPoslana).Count();
        }

        [Route("api/Poruka/GetBrojProcitanihOutbox/{KorisnikId}")]
        public int GetBrojNeprocitanihOutbox(int KorisnikId) {
            return db.Poruka.Where(x => x.PosiljaocId == KorisnikId && x.Procitana && !x.isDeletedPoslana).Count();
        }


        [Route("api/Poruka/GetDolazne/{KorisnikId}")]
        public List<PorukaVM> GetDolazne(int KorisnikId) {
            return db.Poruka.Where(x => x.PrimaocId == KorisnikId && !x.isDeletedPrimljena).Select(x => new PorukaVM() { Id = x.Id, KorisnikId = x.PosiljaocId, Naslov = x.Naslov, Poslao = x.Posiljaoc.KorisnickoIme, chkProcitao = x.Procitana, Slika = x.Posiljaoc.Slika }).ToList();
        }

        [Route("api/Poruka/GetPoslane/{KorisnikId}")]
        public List<PorukaVM> GetPoslane(int KorisnikId) {
            return db.Poruka.Where(x => x.PosiljaocId == KorisnikId && !x.isDeletedPoslana).Select(x => new PorukaVM() { Id = x.Id, KorisnikId = x.PosiljaocId, Naslov = x.Naslov, Primio = x.Primaoc.KorisnickoIme, chkProcitao = x.Procitana, Slika = x.Primaoc.Slika }).ToList();
        }

        // GET: api/Poruka/5
        [ResponseType(typeof(Poruka))]
        public IHttpActionResult GetPoruka(int id)
        {
            Poruka poruka = db.Poruka.Find(id);
            if (poruka == null)
            {
                return NotFound();
            }

            return Ok(poruka);
        }

        // PUT: api/Poruka/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPoruka(int id, Poruka poruka)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != poruka.Id)
            {
                return BadRequest();
            }
            poruka.Posiljaoc = null;
            poruka.Primaoc = null;
            db.Entry(poruka).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PorukaExists(id))
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

        // POST: api/Poruka
        [ResponseType(typeof(Poruka))]
        public IHttpActionResult PostPoruka(Poruka poruka)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Poruka.Add(poruka);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = poruka.Id }, poruka);
        }

        // DELETE: api/Poruka/5
        [ResponseType(typeof(Poruka))]
        public IHttpActionResult DeletePoruka(int id)
        {
            Poruka poruka = db.Poruka.Find(id);
            if (poruka == null)
            {
                return NotFound();
            }

            db.Poruka.Remove(poruka);
            db.SaveChanges();

            return Ok(poruka);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PorukaExists(int id)
        {
            return db.Poruka.Count(e => e.Id == id) > 0;
        }
    }
}