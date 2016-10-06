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
using WebAPI.Util;
using WebAPI.ViewModels;
using WinFormUI.Util;

namespace WinFormUI.Forms {
    public partial class frmPregledNarudzbe : Form {
        WebAPIHelper serviceNarudzbe = new WebAPIHelper("http://localhost:61718/", "api/Narudzba");
        WebAPIHelper serviceKategorije = new WebAPIHelper("http://localhost:61718/", "api/Kategorija");
        List<NarudzbaVM> listaNarudzbe = new List<NarudzbaVM>();
        #region singleton
        public static frmPregledNarudzbe frm = null;
        private frmPregledNarudzbe() // private konstruktor
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        public static frmPregledNarudzbe SingletonInstance() //metoda za otvaranje forme
        {
            if (frm == null)
                frm = new frmPregledNarudzbe();
            return frm;
        }
        #endregion

        private void frmPregledNarudzbe_Load(object sender, EventArgs e) {
            HttpResponseMessage responseKategorije = serviceKategorije.GetResponse("GetKategorije");
            if (responseKategorije.IsSuccessStatusCode) {
                List<Kategorija> lista = responseKategorije.Content.ReadAsAsync<List<Kategorija>>().Result;
                cbxKategorijaProizvodaNarudzbe.DataSource = lista;
                cbxKategorijaProizvodaNarudzbe.DisplayMember = "Naziv";
                cbxKategorijaProizvodaNarudzbe.ValueMember = "Id";
            }
        }

        private void btnTraziNarudzbe_Click(object sender, EventArgs e) {
            if (dtpOD.Value > dtpDO.Value) {
                MessageBox.Show("\"Početni datum\" ne može biti poslije \"Krajnji datum\".", Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string BrojNarudzbe = string.Empty;
            if (txtBrojNarudzbe.Text == "")
                BrojNarudzbe = "null";
            else
                BrojNarudzbe = txtBrojNarudzbe.Text;
            HttpResponseMessage responseNarudzba = serviceNarudzbe.GetResponseParams("GetNarudzbeByParams", new string[] { BrojNarudzbe.Trim(),
                Convert.ToInt32(cbxKategorijaProizvodaNarudzbe.SelectedValue).ToString(),
                dtpOD.Value.ToApiDateTime(),
                dtpDO.Value.ToApiDateTime() });
            if (responseNarudzba.IsSuccessStatusCode) {
                dgvNarudzbe.AutoGenerateColumns = false;
                listaNarudzbe = responseNarudzba.Content.ReadAsAsync<List<NarudzbaVM>>().Result;
                dgvNarudzbe.DataSource = listaNarudzbe;
            }
        }

        private void btnOsvjeziNarudzbe_Click(object sender, EventArgs e) {
            ClearInputNarudzbe();
            dgvNarudzbe.DataSource = null;
            dgvNarudzbe.Rows.Clear();
            dgvNarudzbe.Refresh();
            listaNarudzbe.Clear();

        }
        private void ClearInputNarudzbe() {
            txtBrojNarudzbe.Text = "";
            cbxKategorijaProizvodaNarudzbe.SelectedIndex = 0;
            dtpOD.Value = dtpOD.MinDate;
            dtpDO.Value = dtpDO.MaxDate;
        }

        private void btnIspis_Click(object sender, EventArgs e) {
            if (listaNarudzbe.Count == 0) {
                MessageBox.Show("Ne možete ispisati praznu listu!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reports.Reports rpt = new Reports.Reports(listaNarudzbe, "Narudzbe");
            rpt.ShowDialog();
        }
    }
}
