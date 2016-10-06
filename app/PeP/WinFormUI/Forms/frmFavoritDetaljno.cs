using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI.Models;
using WinFormUI.Util;

namespace WinFormUI.Forms {
    public partial class frmFavoritDetaljno : Form {
        WebAPIHelper serviceFavorit = new WebAPIHelper("http://localhost:61718/", "api/Favoriti");
        int FavoritId;
        public frmFavoritDetaljno(int FavoritId) {
            InitializeComponent();
            this.FavoritId = FavoritId;
        }

        private void frmFavoritDetaljno_Load(object sender, EventArgs e) {
            HttpResponseMessage response = serviceFavorit.GetResponse(FavoritId.ToString());
            if (response.IsSuccessStatusCode) {
                Favoriti p = response.Content.ReadAsAsync<Favoriti>().Result;
                lblNazivFavorit.Text = p.Proizvod.Naziv;
                lblCijenaFavorit.Text = p.Proizvod.Cijena.ToString();
                chkAktivanFavorit.Checked = p.Proizvod.isAktivan;
                chkAktivanFavorit.Enabled = false;
                rtxtOpisFavorit.Text = p.Proizvod.Opis;
                lblVlasnikFavorit.Text = p.Proizvod.Korisnik.Ime + " " + p.Proizvod.Korisnik.Prezime;
                MemoryStream ms;
                try {
                    ms = new MemoryStream(p.Proizvod.Slika);
                    pbProizvodSlika.Image = Image.FromStream(ms);
                    pbProizvodSlika.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (ArgumentNullException) { }
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
