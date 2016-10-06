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

namespace WinFormUI.Forms 
{
    public partial class frmProizvodDetaljno : Form 
    {

        WebAPIHelper serviceProizvod = new WebAPIHelper("http://localhost:61718/", "api/Proizvod");
        int ProizvodId;
        public frmProizvodDetaljno(int ProizvodId)
        {
            InitializeComponent();
            this.ProizvodId = ProizvodId;
        }

        private void frmProizvodDetaljno_Load(object sender, EventArgs e) {
            HttpResponseMessage response = serviceProizvod.GetResponse(ProizvodId.ToString());
            if (response.IsSuccessStatusCode) {
                Proizvod p = response.Content.ReadAsAsync<Proizvod>().Result;
                lblNazivProizvod.Text = p.Naziv;
                lblCijenaProizvod.Text = p.Cijena.ToString();
                chkAktivanProizvod.Checked = p.isAktivan;
                chkAktivanProizvod.Enabled = false;
                rtxtOpisProizvod.Text = p.Opis;
                MemoryStream ms;
                try {
                    ms = new MemoryStream(p.Slika);
                    pbProizvodSlika.Image = Image.FromStream(ms);
                }
                catch (ArgumentNullException) { }
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnObrisiProizvod_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                HttpResponseMessage response = serviceProizvod.GetResponse(ProizvodId.ToString());
                if (response.IsSuccessStatusCode) {
                    Proizvod p = response.Content.ReadAsAsync<Proizvod>().Result;
                    if (p.isDeleted) {
                        MessageBox.Show("Proizvod je već označen kao obrisan!", Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    p.isDeleted = true;
                    HttpResponseMessage update = serviceProizvod.PutResponse(ProizvodId, p);
                    if (update.IsSuccessStatusCode) {
                        MessageBox.Show("Proizvod " + p.Naziv + " je uspješno obrisan!", Global.GetMessage("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else return;
        }

        private void btnKomentari_Click(object sender, EventArgs e) {
            new frmKomentariProizvod(ProizvodId).ShowDialog();

        }

        private void btnOcjene_Click(object sender, EventArgs e) {
            new frmOcjeneProizvod(ProizvodId).ShowDialog();

        }
    }
}
