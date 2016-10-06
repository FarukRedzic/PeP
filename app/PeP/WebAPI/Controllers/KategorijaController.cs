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
    public class KategorijaController : ApiController
    {
        private DBContext db = new DBContext();

        // GET: api/Kategorija
        [Route("api/Kategorija/GetKategorije")]
        public List<Kategorija> GetKategorije()
        {
            List<Kategorija> lista = db.Kategorija.ToList();
            Kategorija temp = new Kategorija() {
                Id = -1,
                Naziv = "-Odaberite kategoriju-",
                Opis = ""
            };
            lista.Insert(0, temp);
            return lista;
        }
        [Route("api/Kategorija/GetKategorijePhone")]
        public List<Kategorija> GetKategorijePhone() {
            Kategorija temp = new Kategorija() {
                Id = -1,
                Naziv = "Sve kategorije",
                Opis = ""
            };
            List<Kategorija> lista = db.Kategorija.ToList();
            lista.Insert(0, temp);
            return lista;
        }

        [Route("api/Kategorija/GetKategorijePhoneAdd")]
        public List<Kategorija> GetKategorijePhoneAdd() {
            return db.Kategorija.ToList();
        }

        // GET: api/Kategorija/5
        [ResponseType(typeof(Kategorija))]
        public IHttpActionResult GetKategorija(int id)
        {
            Kategorija kategorija = db.Kategorija.Find(id);
            if (kategorija == null)
            {
                return NotFound();
            }

            return Ok(kategorija);
        }

        // PUT: api/Kategorija/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKategorija(int id, Kategorija kategorija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kategorija.Id)
            {
                return BadRequest();
            }

            db.Entry(kategorija).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KategorijaExists(id))
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

        // POST: api/Kategorija
        [ResponseType(typeof(Kategorija))]
        public IHttpActionResult PostKategorija(Kategorija kategorija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kategorija.Add(kategorija);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kategorija.Id }, kategorija);
        }

        // DELETE: api/Kategorija/5
        [ResponseType(typeof(Kategorija))]
        public IHttpActionResult DeleteKategorija(int id)
        {
            Kategorija kategorija = db.Kategorija.Find(id);
            if (kategorija == null)
            {
                return NotFound();
            }

            db.Kategorija.Remove(kategorija);
            db.SaveChanges();

            return Ok(kategorija);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KategorijaExists(int id)
        {
            return db.Kategorija.Count(e => e.Id == id) > 0;
        }
    }
}