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
using WebAPI.ViewModels;
using WinFormUI.Util;

namespace WinFormUI.Forms {
    public partial class frmKomentariProizvod : Form {
        WebAPIHelper serviceKomentari = new WebAPIHelper("http://localhost:61718/", "api/Komentar");

        int ProizvodId;
        public frmKomentariProizvod(int ProizvodId) {
            InitializeComponent();
            this.ProizvodId = ProizvodId;
        }

        private void btnTrazi_Click(object sender, EventArgs e) {
            string Ime, Prezime;
            Ime = Prezime = string.Empty;
            if (txtIme.Text == "")
                Ime = "null";
            else
                Ime = txtIme.Text;
            if (txtPrezime.Text == "")
                Prezime = "null";
            else
                Prezime = txtPrezime.Text;

            HttpResponseMessage responseKomentar = serviceKomentari.GetResponseParams("GetKomentari", ProizvodId.ToString(), Ime, Prezime);
            if (responseKomentar.IsSuccessStatusCode) {
                dgvKomentari.AutoGenerateColumns = false;
                dgvKomentari.RowTemplate.Height = 80;
                ((DataGridViewImageColumn)dgvKomentari.Columns[3]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                List<KomentarVM> lista = responseKomentar.Content.ReadAsAsync<List<KomentarVM>>().Result;
                dgvKomentari.DataSource = lista;
            }
        }

        //private void dgvKomentari_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
        //    int KomentarId = Convert.ToInt32(dgvKomentari.SelectedRows[0].Cells[0].Value);
        //    new frmKomentarDetaljno(KomentarId).ShowDialog();
        //}

        private void btnZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dgvKomentari_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            int KomentarId = Convert.ToInt32(dgvKomentari.SelectedRows[0].Cells[0].Value);
            new frmKomentarDetaljno(KomentarId).ShowDialog();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e) {
            txtPrezime.Text = "";
            txtIme.Text = "";
            dgvKomentari.DataSource = null;
            dgvKomentari.Rows.Clear();
            dgvKomentari.Refresh();
        }
    }
}
