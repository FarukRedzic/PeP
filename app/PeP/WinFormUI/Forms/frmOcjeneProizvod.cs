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

namespace WinFormUI.Forms {
    public partial class frmOcjeneProizvod : Form {
        int ProizvodId;
        public frmOcjeneProizvod(int ProizvodId) {
            InitializeComponent();
            this.ProizvodId = ProizvodId;
        }

        WebAPIHelper serviceDojmovi = new WebAPIHelper("http://localhost:61718/", "api/Dojam");
        private void BindcbxOcjene() {
            List<OcjenaVM> ocjene1 = new List<OcjenaVM>();
            List<OcjenaVM> ocjene2 = new List<OcjenaVM>();
            OcjenaVM ocjena = new OcjenaVM() { Id = 0, Ocjena = "-Odaberite ocjenu-" };
            ocjene1.Add(ocjena);
            ocjene2.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 5, Ocjena = "5" };
            ocjene1.Add(ocjena);
            ocjene2.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 6, Ocjena = "6" };
            ocjene1.Add(ocjena);
            ocjene2.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 7, Ocjena = "7" };
            ocjene1.Add(ocjena);
            ocjene2.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 8, Ocjena = "8" };
            ocjene1.Add(ocjena);
            ocjene2.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 9, Ocjena = "9" };
            ocjene1.Add(ocjena);
            ocjene2.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 10, Ocjena = "10" };
            ocjene1.Add(ocjena);
            ocjene2.Add(ocjena);

            cbxOcjenaOD.DataSource = ocjene1;
            cbxOcjenaOD.DisplayMember = "Ocjena";
            cbxOcjenaOD.ValueMember = "Id";

            cbxOcjenaDO.DataSource = ocjene2;
            cbxOcjenaDO.DisplayMember = "Ocjena";
            cbxOcjenaDO.ValueMember = "Id";
        }
        private void btnTrazi_Click(object sender, EventArgs e) {

            string Ime_Dojam, Prezime_Dojam;
            Ime_Dojam = Prezime_Dojam = string.Empty;
            if (txtIme.Text == "")
                Ime_Dojam = "null";
            else
                Ime_Dojam = txtIme.Text;
            if (txtPrezime.Text == "")
                Prezime_Dojam = "null";
            else
                Prezime_Dojam = txtPrezime.Text;

            int OcjenaOD, OcjenaDO;
            OcjenaOD = OcjenaDO = -1;
            if (cbxOcjenaOD.SelectedIndex == 0 && cbxOcjenaDO.SelectedIndex == 0) {
                OcjenaOD = int.MinValue;
                OcjenaDO = int.MaxValue;
            }
            else if ((cbxOcjenaOD.SelectedIndex == 0 && cbxOcjenaDO.SelectedIndex != 0) || (cbxOcjenaOD.SelectedIndex != 0 && cbxOcjenaDO.SelectedIndex == 0)) {
                MessageBox.Show("Potrebno je da odaberete minimalnu i maksimalnu ocjenu!", Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Convert.ToInt32(cbxOcjenaOD.SelectedValue) > Convert.ToInt32(cbxOcjenaDO.SelectedValue))
                MessageBox.Show("Minimalna ocjena ne može biti veća od maksimalne!", Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else {
                OcjenaOD = Convert.ToInt32(cbxOcjenaOD.SelectedValue);
                OcjenaDO = Convert.ToInt32(cbxOcjenaDO.SelectedValue);
            }

            HttpResponseMessage responseOcjene = serviceDojmovi.GetResponseParams("GetOcjeneByParams", new string[] { ProizvodId.ToString(), Ime_Dojam.Trim(), Prezime_Dojam.Trim(), OcjenaOD.ToString(), OcjenaDO.ToString() });
            if (responseOcjene.IsSuccessStatusCode) {
                dgvOcjene.AutoGenerateColumns = false;
                dgvOcjene.DataSource = responseOcjene.Content.ReadAsAsync<List<OcjeneProizvodVM>>().Result;
            }
        }

        private void frmOcjeneProizvod_Load(object sender, EventArgs e) {
            BindcbxOcjene();
            HttpResponseMessage prosjecnaOcjenaResponse = serviceDojmovi.GetResponseParams("GetProsjecnaOcjena", new string[] { ProizvodId.ToString() });
            if (prosjecnaOcjenaResponse.IsSuccessStatusCode) {
                lblProsjecnaOcj.Text = prosjecnaOcjenaResponse.Content.ReadAsAsync<string>().Result;
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e) {
            ClearInput();
            dgvOcjene.DataSource = null;
            dgvOcjene.Rows.Clear();
            dgvOcjene.Refresh();
        }

        private void ClearInput() {
            cbxOcjenaOD.SelectedIndex = 0;
            cbxOcjenaDO.SelectedIndex = 0;
            txtIme.Text = "";
            txtPrezime.Text = "";
        }

        private void dgvOcjene_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            new frmOcjenaKomentar(Convert.ToString(dgvOcjene.SelectedRows[0].Cells[1].Value)).ShowDialog();
        }

        private void btnZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}