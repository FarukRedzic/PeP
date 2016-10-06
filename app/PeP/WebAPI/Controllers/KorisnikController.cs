using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Routing;
using WebAPI.DAL;
using WebAPI.Models;
using WebAPI.Util;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    public class KorisnikController : ApiController
    {
        
        private DBContext db = new DBContext();

        [Route("api/Korisnik/GetKorisnik/{username}")]
        public IHttpActionResult GetKorisnik(string username)
        {
            Korisnik korisnik = db.Korisnik.Where(x => x.KorisnickoIme.Equals(username)).FirstOrDefault();
            if (korisnik == null || korisnik.KorisnickoIme != username)
            {
                return NotFound();
            }
            return Ok(korisnik);
        }

        [Route("api/Korisnik/GetDetaljiAdmin/{AdminId}")]
        public IHttpActionResult GetDetaljiAdmin(int AdminId)
        {
            Korisnik korisnik = db.Korisnik.Find(AdminId);
            if (korisnik == null)
            {
                return NotFound();
            }

            return Ok(korisnik);
        }
        [Route("api/Korisnik/GetDetaljiKorisnik/{KorisnikId}")]
        public IHttpActionResult GetDetaljiKorisnik(int KorisnikId) {
            Korisnik korisnik = db.Korisnik.Find(KorisnikId);
            if (korisnik == null) {
                return NotFound();
            }

            return Ok(korisnik);
        }

        [Route("api/Korisnik/GetOpstine")]
        public List<Opstina> GetOpstine()
        {
            Opstina item = new Opstina()
            {
                Id = 0,
                Naziv = "-Odaberite opštinu-"
            };
            List<Opstina> lista = db.Opstina.ToList();
            lista.Insert(0, item);
            return lista;
        }

        [Route("api/Korisnik/GetOpstinePhone")]
        public List<Opstina> GetOpstinePhone() {
            return db.Opstina.ToList();
        }

        // GET: api/Korisnik
        public List<Korisnik> GetKorisnik()
        {
            return db.Korisnik.ToList();
        }

        //Procedura...
        [Route("api/Korisnik/GetKorisniciByParams/{Naziv}/{IsTrgovina}/{LogiraniId}")]
        public List<KorisnikVM> GetKorisniciByParams(string Naziv, bool? IsTrgovina, int LogiraniId) {
            List<KorisnikVM> lista = new List<KorisnikVM>();
            KorisnikVM korisnik;

            using (SqlConnection cn = Connection.getConnection()) {

                SqlCommand cmd = new SqlCommand("usp_GetKorisniciByParams", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Naziv", Naziv);
                cmd.Parameters.AddWithValue("@IsTrgovina", IsTrgovina);
                cmd.Parameters.AddWithValue("@LogiraniId", LogiraniId);

                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    korisnik = new KorisnikVM();
                    korisnik.Id = Convert.ToInt32(reader["Id"]); // tostring?
                    korisnik.Slika = (byte[])reader["Slika"];
                    korisnik.ImePrezime = reader["ImePrezime"].ToString();
                    korisnik.KorisnickoIme = reader["KorisnickoIme"].ToString();
                    korisnik.Popularnost = reader["Popularnost"].ToString();
                    lista.Add(korisnik);
                }
                return lista;
            }
        }

        [Route("api/Korisnik/GetAdmin/{Ime}/{Prezime}/{StatusId}")]
        public List<KorisnikVM> GetAdmin(string Ime, string Prezime, int StatusId)
        {
            List<KorisnikVM> lista = (from k in db.Korisnik
                                          join o in db.Opstina
                                          on k.OpstinaId equals o.Id
                                          join ku in db.KorisniciUloge
                                          on k.Id equals ku.KorisnikId
                                          join u in db.Uloga
                                          on ku.UlogaId equals u.Id
                                          where (u.Naziv == "Admin" && (k.Ime.Contains(Ime) || Ime == "null") && (k.Prezime.Contains(Prezime) || Prezime == "null") && (k.Aktivan == StatusId || StatusId == -1))
                                          select new KorisnikVM() { Id = k.Id, Ime = k.Ime, Prezime = k.Prezime, Email = k.Email, KorisnickoIme = k.KorisnickoIme, Telefon = k.Telefon, Opstina = o.Naziv, Aktivan = k.Aktivan }).ToList();
            return lista;
        }
        [Route("api/Korisnik/GetKorisnici/{Ime}/{Prezime}/{StatusId}")]
        public List<KorisnikVM> GetKorisnici(string Ime, string Prezime, int StatusId) {
            List<KorisnikVM> lista = (from k in db.Korisnik
                                      join o in db.Opstina
                                      on k.OpstinaId equals o.Id
                                      join ku in db.KorisniciUloge
                                      on k.Id equals ku.KorisnikId
                                      join u in db.Uloga
                                      on ku.UlogaId equals u.Id
                                      where (u.Naziv == "Korisnik" && (k.Ime.Contains(Ime) || Ime == "null") && (k.Prezime.Contains(Prezime) || Prezime == "null") && (k.Aktivan == StatusId || StatusId == -1))
                                      select new KorisnikVM() { Id = k.Id, Ime = k.Ime, Prezime = k.Prezime, Email = k.Email, KorisnickoIme = k.KorisnickoIme, Telefon = k.Telefon, Opstina = o.Naziv, Aktivan = k.Aktivan }).ToList();
            return lista;
        }

        // POST: api/Korisnik 
        [Route("api/Korisnik/PostKorisnik")]
        public IHttpActionResult PostKorisnik(KorisnikVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Korisnik k = new Korisnik() {
                Email = model.Email,
                Ime = model.Ime,
                Prezime = model.Prezime,
                LozinkaHash = model.LozinkaHash,
                LozinkaSalt = model.LozinkaSalt,
                OpstinaId = model.OpstinaId,
                Aktivan = 1, // Aktivan(1)
                Telefon = model.Telefon,
                KorisnickoIme = model.KorisnickoIme,
                Slika = model.Slika,
                IsTrgovina = model.IsTrgovina,
                Adresa = model.Adresa,
            };
            db.Korisnik.Add(k);
            try
            {
                db.SaveChanges();
            }

            catch (DbUpdateException ex)
            {
                throw CustomException(Util.MessagesHandler.GetMessage(Util.ExceptionHandler.HandleSQLException(ex)), HttpStatusCode.Conflict);
            }

            KorisniciUloge ku = new KorisniciUloge();
            ku.KorisnikId = k.Id;
            ku.UlogaId = model.UlogaId; // Admin ili korisnik
            db.KorisniciUloge.Add(ku);
            if (model.chkKorisnickiNalog == true)
            {
                KorisniciUloge ku2 = new KorisniciUloge()
                {
                    KorisnikId = k.Id,
                    UlogaId = 2 // Obicni korisnik (Klijent)
                };
                db.KorisniciUloge.Add(ku2);
            }
            db.SaveChanges();

            return Ok(k);
            //return CreatedAtRoute("DefaultApi", new { id = k.Id }, k);
        }

        private HttpResponseException CustomException(string reason, HttpStatusCode status)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                StatusCode = status,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };
            return new HttpResponseException(msg);
        }

        // GET: api/Korisnik/5
        [ResponseType(typeof(Korisnik))]
        public IHttpActionResult GetKorisnik(int id)
        {
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return NotFound();
            }

            return Ok(korisnik);
        }

        // PUT: api/Korisnik/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnik(int id, Korisnik korisnik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != korisnik.Id)
            {
                return BadRequest();
            }

            korisnik.Opstina = null; /*db.Opstina.Find(korisnik.OpstinaId);*/
            db.Entry(korisnik).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisnikExists(id))
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

        // POST: api/Korisnik
        [ResponseType(typeof(Korisnik))]
        public IHttpActionResult PostKorisnik(Korisnik korisnik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Korisnik.Add(korisnik);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = korisnik.Id }, korisnik);
        }

        // DELETE: api/Korisnik/5
        [ResponseType(typeof(Korisnik))]
        public IHttpActionResult DeleteKorisnik(int id)
        {
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return NotFound();
            }

            db.Korisnik.Remove(korisnik);
            db.SaveChanges();

            return Ok(korisnik);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KorisnikExists(int id)
        {
            return db.Korisnik.Count(e => e.Id == id) > 0;
        }
    }
}