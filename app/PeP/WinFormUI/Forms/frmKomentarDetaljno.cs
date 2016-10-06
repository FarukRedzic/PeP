using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI.Models;
using WinFormUI.Util;

namespace WinFormUI.Forms {
    public partial class frmKomentarDetaljno : Form {

        WebAPIHelper serviceKomentari = new WebAPIHelper("http://localhost:61718/", "api/Komentar");
        WebAPIHelper serviceKorisniciUloge = new WebAPIHelper("http://localhost:61718/", "api/KorisniciUloge");

        int KomentarId;
        public frmKomentarDetaljno(int KomentarId) {
            InitializeComponent();
            this.KomentarId = KomentarId;
        }

        private void frmKomentarDetaljno_Load(object sender, EventArgs e) {
            HttpResponseMessage responseKomentar = serviceKomentari.GetResponse(KomentarId.ToString());
            if (responseKomentar.IsSuccessStatusCode) {
                Komentar k = responseKomentar.Content.ReadAsAsync<Komentar>().Result;
                rtxtSadrzaj.Text = k.Sadrzaj;
                linkLabelKorisnik.Text = k.Korisnik.Ime + " " + k.Korisnik.Prezime;
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void linkLabelKorisnik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            HttpResponseMessage responseKomentar = serviceKomentari.GetResponse(KomentarId.ToString());
            if (responseKomentar.IsSuccessStatusCode) {
                Komentar k = responseKomentar.Content.ReadAsAsync<Komentar>().Result;
                HttpResponseMessage responseKorisniciUloge = serviceKorisniciUloge.GetResponseParams("GetUloga", new string[] { k.KorisnikId.ToString() });
                if (responseKorisniciUloge.IsSuccessStatusCode) {
                    string uloga = responseKorisniciUloge.Content.ReadAsAsync<string>().Result;
                    if (uloga == "Admin")
                        new frmDetaljiAdmin(k.KorisnikId).ShowDialog();
                    else
                        new frmDetaljiKorisnik(k.KorisnikId).ShowDialog();
                }

            }

        }
    }
}
