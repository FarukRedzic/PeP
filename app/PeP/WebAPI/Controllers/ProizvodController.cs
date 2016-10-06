using PCL.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.DAL;
using WebAPI.Models;
using WebAPI.Util;
using WebAPI.ViewModels;

namespace WebAPI.Controllers {
    public class ProizvodController : ApiController {
        private DBContext db = new DBContext();

        // GET: api/Proizvod
        public IQueryable<Proizvod> GetProizvod() {
            return db.Proizvod;
        }

        //Recommender
        [Route("api/Proizvod/GetPreporuceniProizvodi/{ProizvodId}/{LogiraniId}")]
        public List<Proizvod> GetPreporuceniProizvodi(int ProizvodId, int LogiraniId) {
            Recommender r = new Recommender();
            return r.GetSlicneProizvode(ProizvodId, LogiraniId);
        }


        [Route("api/Proizvod/GetSlicniProizvodiObicniKorisnik/{KategorijaId}/{LogiraniKorisnikId}/{ProizvodId}")]
        public List<Proizvod> GetSlicniProizvodiObicniKorisnik(int KategorijaId, int LogiraniKorisnikId, int ProizvodId) {
            List<Proizvod> lista = new List<Proizvod>();
            Proizvod proizvod;
            using (SqlConnection cn = Connection.getConnection()) {

                SqlCommand cmd = new SqlCommand("usp_GetSlicniProizvodiObicniKorisnik", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@KategorijaID", KategorijaId);
                cmd.Parameters.AddWithValue("@LogiraniKorisnikID", LogiraniKorisnikId);
                cmd.Parameters.AddWithValue("@PosmatraniID", ProizvodId);

                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    proizvod = new Proizvod();
                    proizvod.Id = Convert.ToInt32(reader["Id"]);
                    proizvod.Naziv = reader["Naziv"].ToString();
                    proizvod.Cijena = (double)reader["Cijena"];
                    proizvod.Slika = (byte[])reader["Slika"];
                    proizvod.isAktivan = (bool)reader["isAktivan"];
                    proizvod.Opis = (string)reader["Opis"];
                    proizvod.KorisnikId = (int)reader["KorisnikId"];
                    proizvod.KategorijaId = (int)reader["KategorijaId"];
                    proizvod.isDeleted = (bool)reader["isDeleted"];
                    proizvod.Postavio = (DateTime)reader["Postavio"];
                    proizvod.Koristen = (bool)reader["Koristen"];
                    lista.Add(proizvod);
                }
                return lista;
            }
        }



        [Route("api/Proizvod/GetLast/{LogiraniId}")]
        public List<ProizvodVM> GetLast(int LogiraniId) {
            return db.Proizvod.Where(x => x.KorisnikId != LogiraniId && x.isAktivan).OrderByDescending(x => x.Id).Take(50).Select(x => new ProizvodVM() { Id = x.Id, Naziv = x.Naziv, Cijena = x.Cijena, Kategorija = x.Kategorija.Naziv, Slika = x.Slika }).ToList();
        }

        [Route("api/Proizvod/GetProizvodiByParams/{Naziv}/{KategorijaId}/{LogiraniId}")]
        public List<ProizvodVM> GetProizvodiByParams(string Naziv, int KategorijaId, int LogiraniId ) {
            return db.Proizvod.OrderByDescending(x => x.Id).Where(x => x.KorisnikId != LogiraniId && x.isAktivan && (x.KategorijaId == KategorijaId || KategorijaId == 0) && (x.Naziv.Contains(Naziv) || Naziv == "null")).Select(x => new ProizvodVM() { Id = x.Id, Naziv = x.Naziv, Cijena = x.Cijena, Kategorija = x.Kategorija.Naziv, Slika = x.Slika }).ToList();
        }

        // Proizvodi u MetroTabu
        [Route("api/Proizvod/GetProizvodiByParameters/{KorisnikId}/{Naziv}/{KategorijaId}/{CijenaOD}/{CijenaDO}")]
        public List<ProizvodVM> GetProizvodiByParameters(int KorisnikId, string Naziv, int KategorijaId, double CijenaOD, double CijenaDO) {
            List<ProizvodVM> proizvodi = (from p in db.Proizvod
                                          join k in db.Kategorija
                                          on p.KategorijaId equals k.Id
                                          where (p.KorisnikId == KorisnikId) && (p.Naziv.Contains(Naziv) || Naziv == "null") && (p.KategorijaId == KategorijaId || KategorijaId == -1) && (p.Cijena >= CijenaOD && p.Cijena <= CijenaDO)
                                          select new ProizvodVM() { NaslovReport = p.Korisnik.Ime + " " + p.Korisnik.Prezime , Id = p.Id, Cijena = p.Cijena, Kategorija = k.Naziv, Naziv = p.Naziv, Aktivan = p.isAktivan, Obrisan = p.isDeleted, Slika = p.Slika }).ToList();
            return proizvodi;
        }
        //Phone
        [Route("api/Proizvod/GetAktivneByParams/{KorisnikId}/{KategorijaId}")]
        public List<ProizvodVM> GetAktivneByParams(int KorisnikId, int KategorijaId) {
            List<ProizvodVM> proizvodi = (from p in db.Proizvod
                                          join k in db.Kategorija
                                          on p.KategorijaId equals k.Id
                                          where ((p.KorisnikId == KorisnikId && p.isDeleted == false) && (p.KategorijaId == KategorijaId || KategorijaId == -1 || KategorijaId == 0) && (p.isAktivan == true))
                                          select new ProizvodVM() { Id = p.Id, Cijena = p.Cijena, Kategorija = k.Naziv, Naziv = p.Naziv, Aktivan = p.isAktivan, Obrisan = p.isDeleted, Slika = p.Slika }).ToList();
            return proizvodi;
        }
        [Route("api/Proizvod/GetNeaktivneByParams/{KorisnikId}/{KategorijaId}")]
        public List<ProizvodVM> GetNeaktivneByParams(int KorisnikId, int KategorijaId) {
            List<ProizvodVM> lista = new List<ProizvodVM>();
            ProizvodVM proizvod;
            using (SqlConnection cn = Connection.getConnection()) {

                SqlCommand cmd = new SqlCommand("usp_GetNeaktivneProizvode", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@KorisnikId", KorisnikId);
                cmd.Parameters.AddWithValue("@KategorijaId", KategorijaId);

                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    proizvod = new ProizvodVM();
                    proizvod.Id = Convert.ToInt32(reader["Id"]);
                    proizvod.Cijena = (double)reader["Cijena"];
                    proizvod.Kategorija = reader["Kategorija"].ToString();
                    proizvod.Slika = (byte[])reader["Slika"];
                    proizvod.Naziv = reader["Naziv"].ToString();
                    proizvod.Aktivan = (bool)reader["Aktivan"];
                    proizvod.Obrisan = (bool)reader["Obrisan"];
                    lista.Add(proizvod);
                }
                return lista;
            }
        }

        [Route("api/Proizvod/GetNeaktivneByParamsTrgovina/{KorisnikId}/{KategorijaId}")]
        public List<ProizvodVM> GetNeaktivneByParamsTrgovina(int KorisnikId, int KategorijaId) {
            return  db.Proizvod.Where(x => x.KorisnikId == KorisnikId && (x.KategorijaId == KategorijaId || KategorijaId == -1) && !x.isDeleted && !x.isAktivan).Select(x => new ProizvodVM() { Id = x.Id, Cijena = x.Cijena, Kategorija = x.Kategorija.Naziv, Naziv = x.Naziv, Slika = x.Slika }).ToList();
        }
        //Phone
        [Route("api/Proizvod/GetProizvod/{ProizvodId}")]
        public Proizvod GetAktivneByParams(int ProizvodId) {
            return db.Proizvod.Find(ProizvodId);
        }
        // Proizvodi na MainMeni
        [Route("api/Proizvod/GetProizvodiByParameters/{Naziv}/{isAKtivan}/{isObrisan}/{KategorijaId}")]
        public List<ProizvodVM> GetProizvodiByParameters(string Naziv, string isAKtivan, string isObrisan, int KategorijaId) {
            if (isAKtivan == "null" && isObrisan != "null") {
                bool _isObrisan = Convert.ToBoolean(isObrisan);
                List<ProizvodVM> lista = db.Proizvod.Where(x => (x.Naziv.Contains(Naziv) || Naziv == "null") && (x.isDeleted == _isObrisan) && (x.KategorijaId == KategorijaId || KategorijaId == -1)).Select(x => new ProizvodVM() { Id = x.Id, Aktivan = x.isAktivan, Cijena = x.Cijena, Kategorija = x.Kategorija.Naziv, Naziv = x.Naziv, Obrisan = x.isDeleted, Vlasnik = x.Korisnik.Ime + " " + x.Korisnik.Prezime, Slika = x.Slika }).ToList();
                return lista;
            }
            else if (isAKtivan != "null" && isObrisan == "null") {
                bool _isAktivan = Convert.ToBoolean(isAKtivan);
                List<ProizvodVM> lista = db.Proizvod.Where(x => (x.Naziv.Contains(Naziv) || Naziv == "null") && (x.isAktivan == _isAktivan) && (x.KategorijaId == KategorijaId || KategorijaId == -1)).Select(x => new ProizvodVM() { Id = x.Id, Aktivan = x.isAktivan, Cijena = x.Cijena, Kategorija = x.Kategorija.Naziv, Naziv = x.Naziv, Obrisan = x.isDeleted, Vlasnik = x.Korisnik.Ime + " " + x.Korisnik.Prezime, Slika = x.Slika }).ToList();
                return lista;
            }
            else if (isAKtivan != "null" && isObrisan != "null") {
                bool _isAktivan = Convert.ToBoolean(isAKtivan);
                bool _isObrisan = Convert.ToBoolean(isObrisan);
                List<ProizvodVM> lista = db.Proizvod.Where(x => (x.Naziv.Contains(Naziv) || Naziv == "null") && (x.isAktivan == _isAktivan && x.isDeleted == _isObrisan) && (x.KategorijaId == KategorijaId || KategorijaId == -1)).Select(x => new ProizvodVM() { Id = x.Id, Aktivan = x.isAktivan, Cijena = x.Cijena, Kategorija = x.Kategorija.Naziv, Naziv = x.Naziv, Obrisan = x.isDeleted, Vlasnik = x.Korisnik.Ime + " " + x.Korisnik.Prezime, Slika = x.Slika }).ToList();
                return lista;
            }
            else {
                List<ProizvodVM> lista = db.Proizvod.Where(x => (x.Naziv.Contains(Naziv) || Naziv == "null") && (x.KategorijaId == KategorijaId || KategorijaId == -1)).Select(x => new ProizvodVM() { Id = x.Id, Aktivan = x.isAktivan, Cijena = x.Cijena, Kategorija = x.Kategorija.Naziv, Naziv = x.Naziv, Obrisan = x.isDeleted, Vlasnik = x.Korisnik.Ime + " " + x.Korisnik.Prezime, Slika = x.Slika }).ToList();
                return lista;
            }
        }

        // GET: api/Proizvod/5
        [ResponseType(typeof(Proizvod))]
        public IHttpActionResult GetProizvod(int id) {
            Proizvod proizvod = db.Proizvod.Find(id);
            if (proizvod == null) {
                return NotFound();
            }

            return Ok(proizvod);
        }

        // PUT: api/Proizvod/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProizvod(int id, Proizvod proizvod) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != proizvod.Id) {
                return BadRequest();
            }

            proizvod.Kategorija = null;
            proizvod.Korisnik = null;
            db.Entry(proizvod).State = EntityState.Modified;

            try {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException) {
                if (!ProizvodExists(id)) {
                    return NotFound();
                }
                else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Proizvod
        [ResponseType(typeof(Proizvod))]
        public IHttpActionResult PostProizvod(Proizvod proizvod) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Proizvod.Add(proizvod);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = proizvod.Id }, proizvod);
        }

        // DELETE: api/Proizvod/5
        [ResponseType(typeof(Proizvod))]
        public IHttpActionResult DeleteProizvod(int id) {
            Proizvod proizvod = db.Proizvod.Find(id);
            if (proizvod == null) {
                return NotFound();
            }

            db.Proizvod.Remove(proizvod);
            db.SaveChanges();

            return Ok(proizvod);
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProizvodExists(int id) {
            return db.Proizvod.Count(e => e.Id == id) > 0;
        }
    }
}