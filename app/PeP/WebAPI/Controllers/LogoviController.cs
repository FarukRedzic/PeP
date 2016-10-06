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
    public class LogoviController : ApiController
    {
        private DBContext db = new DBContext();

        
        [Route("api/Logovi/GetLogoviByParams/{Ime}/{Prezime}/{cbxUspjesnost}/{dtpOD}/{dtpDO}")]
        public List<LogoviVM> GetLogoviByParams(string Ime, string Prezime, string cbxUspjesnost, string dtpOD, string dtpDO) {
            DateTime ODDatum = dtpOD.ApiToDateTime();
            DateTime DODatum = dtpDO.ApiToDateTime();

            if (cbxUspjesnost != "null") {
                bool _cbxUspjesnost = Convert.ToBoolean(cbxUspjesnost);
                List<LogoviVM> lista = db.Logovi.Where(x => (x.DatumVrijeme >= ODDatum && x.DatumVrijeme <= DODatum) && (x.Uspjesnost == _cbxUspjesnost) && (x.Korisnik.Ime.Contains(Ime) || Ime == "null") && (x.Korisnik.Prezime.Contains(Prezime) || Prezime == "null")).Select(x => new LogoviVM() { Id = x.Id, DatumVrijeme = x.DatumVrijeme, Uspjesnost = x.Uspjesnost, Korisnik = x.Korisnik.Ime + " " + x.Korisnik.Prezime }).ToList();
                return lista;
            }
            else { 
                List<LogoviVM> lista = db.Logovi.Where(x => (x.DatumVrijeme >= ODDatum && x.DatumVrijeme <= DODatum) && (x.Korisnik.Ime.Contains(Ime) || Ime == "null") && (x.Korisnik.Prezime.Contains(Prezime) || Prezime == "null")).Select(x => new LogoviVM() { Id = x.Id, DatumVrijeme = x.DatumVrijeme, Uspjesnost = x.Uspjesnost, Korisnik = x.Korisnik.Ime + " " + x.Korisnik.Prezime }).ToList();
                return lista;
            }
        }


        // GET: api/Logovi
        public IQueryable<Logovi> GetLogovi()
        {
            return db.Logovi;
        }

        // GET: api/Logovi/5
        [ResponseType(typeof(Logovi))]
        public IHttpActionResult GetLogovi(int id)
        {
            Logovi logovi = db.Logovi.Find(id);
            if (logovi == null)
            {
                return NotFound();
            }

            return Ok(logovi);
        }


       // PUT: api/Logovi/5
       [ResponseType(typeof(void))]
        public IHttpActionResult PutLogovi(int id, Logovi logovi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != logovi.Id)
            {
                return BadRequest();
            }
            logovi.Korisnik = null;
            db.Entry(logovi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LogoviExists(id))
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

        // POST: api/Logovi
        [ResponseType(typeof(Logovi))]
        public IHttpActionResult PostLogovi(Logovi logovi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Logovi.Add(logovi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = logovi.Id }, logovi);
        }

        // DELETE: api/Logovi/5
        [ResponseType(typeof(Logovi))]
        public IHttpActionResult DeleteLogovi(int id)
        {
            Logovi logovi = db.Logovi.Find(id);
            if (logovi == null)
            {
                return NotFound();
            }

            db.Logovi.Remove(logovi);
            db.SaveChanges();

            return Ok(logovi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LogoviExists(int id)
        {
            return db.Logovi.Count(e => e.Id == id) > 0;
        }
    }
}