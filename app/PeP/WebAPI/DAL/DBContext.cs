using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.DAL
{
    public class DBContext : DbContext
    {
        public DBContext() : base("name=connString"){}

        public DbSet<Dojam> Dojam { get; set; }
        public DbSet<Favoriti> Favoriti { get; set; }
        public DbSet<Kategorija> Kategorija { get; set; }
        public DbSet<Komentar> Komentar { get; set; }
        public DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Logovi> Logovi { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<Poruka> Poruka { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<Uloga> Uloga { get; set; }
        public DbSet<Opstina> Opstina { get; set; }
        public DbSet<Notifikacije> Notifikacije { get; set; }
        public DbSet<VrstaNotifikacije> VrstaNotifikacije { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}