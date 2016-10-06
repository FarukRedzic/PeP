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
using WebAPI.Util;
using WebAPI.ViewModels;
using WinFormUI.Util;

namespace WinFormUI.Forms {
    public partial class frmPregledLogovi : Form {
        WebAPIHelper serviceLogovi = new WebAPIHelper("http://localhost:61718/", "api/Logovi");
        List<LogoviVM> listaLogovi = new List<LogoviVM>();

        #region singleton
        public static frmPregledLogovi frm = null;
        private frmPregledLogovi() // private konstruktor
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        public static frmPregledLogovi SingletonInstance() //metoda za otvaranje forme
        {
            if (frm == null)
                frm = new frmPregledLogovi();
            return frm;
        }
        #endregion

        private void frmPregledLogovi_Load(object sender, EventArgs e) {
            cbxLoad();
        }

        private void cbxLoad() {
            List<boolCBXVM> lista = new List<boolCBXVM>();
            boolCBXVM item = new boolCBXVM() { Id = null, Text = "-Odaberite uspjeh-" };
            lista.Add(item);
            item = new boolCBXVM() { Id = true, Text = "Uspješno" };
            lista.Add(item);
            item = new boolCBXVM() { Id = false, Text = "Neuspješno" };
            lista.Add(item);
            cbxUspjesnost.DataSource = lista;
            cbxUspjesnost.ValueMember = "Id";
            cbxUspjesnost.DisplayMember = "Text";
        }

        private void btnTrazi_Click(object sender, EventArgs e) {
            if (dtpOD.Value > dtpDO.Value) {
                MessageBox.Show("\"Početni datum\" ne može biti poslije \"Krajnji datum\".", Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Ime, Prezime, _cbxUspjesnost;
            Ime = Prezime = _cbxUspjesnost = string.Empty;
            if (txtIme.Text == "")
                Ime = "null";
            else
                Ime = txtIme.Text;
            if (txtPrezime.Text == "")
                Prezime = "null";
            else
                Prezime = txtPrezime.Text;

            try {
                _cbxUspjesnost = cbxUspjesnost.SelectedValue.ToString();
            }
            catch (NullReferenceException) {

                _cbxUspjesnost = "null";
            }


            HttpResponseMessage responseLogovi = serviceLogovi.GetResponseParams("GetLogoviByParams", new string[] { Ime.Trim(),Prezime.Trim(),
                _cbxUspjesnost.Trim(),
                dtpOD.Value.ToApiDateTime(),
                dtpDO.Value.ToApiDateTime() });
            if (responseLogovi.IsSuccessStatusCode) {
                dgvLogovi.AutoGenerateColumns = false;
                listaLogovi = responseLogovi.Content.ReadAsAsync<List<LogoviVM>>().Result;
                dgvLogovi.DataSource = listaLogovi;
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e) {
            ClearInputNarudzbe();
            dgvLogovi.DataSource = null;
            dgvLogovi.Rows.Clear();
            dgvLogovi.Refresh();
            listaLogovi.Clear();
        }
        private void ClearInputNarudzbe() {
            txtIme.Text = "";
            txtPrezime.Text = "";
            cbxUspjesnost.SelectedIndex = 0;
            dtpOD.Value = dtpOD.MinDate;
            dtpDO.Value = dtpDO.MaxDate;
        }

        private void btnIspis_Click(object sender, EventArgs e) {
            if (listaLogovi.Count == 0) {
                MessageBox.Show("Ne možete ispisati praznu listu!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reports.Reports rpt = new Reports.Reports(listaLogovi, "Logovi");
            rpt.ShowDialog();
        }
    }
}

