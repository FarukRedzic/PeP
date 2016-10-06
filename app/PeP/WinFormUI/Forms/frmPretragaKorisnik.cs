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
using WebAPI.ViewModels;
using WinFormUI.Util;
using WinFormUI.ViewModels;

namespace WinFormUI.Forms {
    public partial class frmPretragaKorisnik : Form {
        WebAPIHelper serviceKorisnici = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");
        List<KorisnikVM> lista = new List<KorisnikVM>();


        public static frmPretragaKorisnik frm = null;

        private frmPretragaKorisnik() { // singleton konstruktor
            InitializeComponent();
        }

        public static frmPretragaKorisnik SingletonInstance() //metoda za otvaranje forme
        {
            if (frm == null)
                frm = new frmPretragaKorisnik();
            return frm;
        }
        private void frmPretragaKorisnik_Load(object sender, EventArgs e) {
            BindStatusi();
        }

        private void BindStatusi() {
            List<StatusiVM> statusi = new List<StatusiVM>();
            statusi.Add(new StatusiVM() { Status = "-Odaberite status-", StatusId = -1 });
            statusi.Add(new StatusiVM() { Status = "Aktivan", StatusId = 1 });
            statusi.Add(new StatusiVM() { Status = "Neaktivan", StatusId = 0 });
            cbxStatus.DataSource = statusi;
            cbxStatus.DisplayMember = "Status";
            cbxStatus.ValueMember = "StatusId";
        }
        private void btnTraziKorisnik_Click(object sender, EventArgs e) {
            string Ime, Prezime;
            if (txtIme.Text.Equals(""))
                Ime = "null";
            else
                Ime = txtIme.Text.Trim();

            if (txtPrezime.Text.Equals(""))
                Prezime = "null";
            else
                Prezime = txtPrezime.Text.Trim();

            HttpResponseMessage response = serviceKorisnici.GetResponseParams("GetKorisnici", new string[] { Ime, Prezime, cbxStatus.SelectedValue.ToString() });
            if (response.IsSuccessStatusCode) {
                lista = response.Content.ReadAsAsync<List<KorisnikVM>>().Result;
                dgvKorisnici.AutoGenerateColumns = false;
                dgvKorisnici.DataSource = lista;
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e) {
            cbxStatus.SelectedIndex = 0;
            dgvKorisnici.DataSource = null;
            dgvKorisnici.Rows.Clear();
            dgvKorisnici.Refresh();
            ClearInput();
            lista.Clear();
        }

        private void ClearInput() {
            txtIme.Text = "";
            txtPrezime.Text = "";
            cbxStatus.SelectedValue = -1;
        }

        private bool ValidacijaSelectedRow() {
            for (int i = 0; i < dgvKorisnici.RowCount; i++) {
                if (dgvKorisnici.Rows[i].Selected) {
                    return true;
                }
            }
            return false;
        }

        private void btnDetalji_Click(object sender, EventArgs e) {
            if (!ValidacijaSelectedRow()) {
                MessageBox.Show("Potrebno je da označite korisnika!", Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                int KorisnikId = Convert.ToInt32(dgvKorisnici.SelectedRows[0].Cells[0].Value);
                dgvKorisnici.DataSource = null;
                dgvKorisnici.Rows.Clear();
                new frmDetaljiKorisnik(KorisnikId).ShowDialog();
            }
        }

        private void btnIspis_Click(object sender, EventArgs e) {
            if (lista.Count == 0) {
                MessageBox.Show("Ne možete ispisati praznu listu!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reports.Reports rpt = new Reports.Reports(lista, "Korisnici");
            rpt.ShowDialog();
        }
    }
}
