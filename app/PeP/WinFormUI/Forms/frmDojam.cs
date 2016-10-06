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
    public partial class frmDojam : Form {
        WebAPIHelper serviceDojmovi = new WebAPIHelper("http://localhost:61718/", "api/Dojam");
        int DojamId;
        public frmDojam(int DojamId) {
            InitializeComponent();
            this.DojamId = DojamId;
        }

        private void frmDojam_Load(object sender, EventArgs e) {
            HttpResponseMessage response = serviceDojmovi.GetResponse(DojamId.ToString());
            if (response.IsSuccessStatusCode) {
                Dojam d = response.Content.ReadAsAsync<Dojam>().Result;
                lblOstavioDojam.Text = d.Narudzba.Korisnik.Ime + " " + d.Narudzba.Korisnik.Prezime;
                rtxtSadrzaj.Text = d.Sadrzaj;
                lblOcjenaDojam.Text = d.Ocjena.ToString();
                lblProizvodDojam.Text = d.Narudzba.Proizvod.Naziv;
                lblProizvodId.Text = d.Narudzba.Proizvod.Id.ToString();
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void lblProizvodDojam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new frmProizvodDetaljno(Convert.ToInt32(lblProizvodId.Text)).ShowDialog();
        }
    }
}
