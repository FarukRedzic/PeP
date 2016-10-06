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
using WinFormUI.Reports;
using WinFormUI.Util;

namespace WinFormUI.Forms {
    public partial class frmPregledProizvodi : Form {
        WebAPIHelper serviceProizvodi = new WebAPIHelper("http://localhost:61718/", "api/Proizvod");
        WebAPIHelper serviceKategorije = new WebAPIHelper("http://localhost:61718/", "api/Kategorija");

        #region singleton
        public static frmPregledProizvodi frm = null;
        private frmPregledProizvodi() // private konstruktor
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        public static frmPregledProizvodi SingletonInstance() //metoda za otvaranje forme
        {
            if (frm == null)
                frm = new frmPregledProizvodi();
            return frm;
        }
        #endregion
        private void frmPregledProizvodi_Load(object sender, EventArgs e) {
            cbxLoad();
        }

        List<ProizvodVM> listaProizvodi = new List<ProizvodVM>();

        private void cbxLoad() {
            List<boolCBXVM> lista = new List<boolCBXVM>();
            boolCBXVM item = new boolCBXVM() { Id = null, Text = "-Odaberite status-" };
            lista.Add(item);
            item = new boolCBXVM() { Id = true, Text = "DA" };
            lista.Add(item);
            item = new boolCBXVM() { Id = false, Text = "NE" };
            lista.Add(item);

            List<boolCBXVM> lista1 = new List<boolCBXVM>();
            item = new boolCBXVM() { Id = null, Text = "-Odaberite status-" };
            lista1.Add(item);
            item = new boolCBXVM() { Id = true, Text = "DA" };
            lista1.Add(item);
            item = new boolCBXVM() { Id = false, Text = "NE" };
            lista1.Add(item);

            cbxAktivan.DataSource = lista;
            cbxAktivan.ValueMember = "Id";
            cbxAktivan.DisplayMember = "Text";

            cbxObrisan.DataSource = lista1;
            cbxObrisan.ValueMember = "Id";
            cbxObrisan.DisplayMember = "Text";

            HttpResponseMessage responseKategorije = serviceKategorije.GetResponse("GetKategorije");
            if (responseKategorije.IsSuccessStatusCode) {
                cbxKategorije.DataSource = responseKategorije.Content.ReadAsAsync<List<Kategorija>>().Result;
                cbxKategorije.ValueMember = "Id";
                cbxKategorije.DisplayMember = "Naziv";
            }
        }

        private void btnTraziProizvod_Click(object sender, EventArgs e) {

            string NazivProizvoda = string.Empty;
            string _cbxAktivan, _cbxObrisan;
            int _cbxKategorija;


            if (txtNaziv.Text == "")
                NazivProizvoda = "null";
            else
                NazivProizvoda = txtNaziv.Text;

            try {
                _cbxAktivan = cbxAktivan.SelectedValue.ToString();
            }
            catch (NullReferenceException) {

                _cbxAktivan = "null";
            }
            try {
                _cbxObrisan = cbxObrisan.SelectedValue.ToString();
            }
            catch (NullReferenceException) {

                _cbxObrisan = "null";
            }
            _cbxKategorija = Convert.ToInt32(cbxKategorije.SelectedValue);


            HttpResponseMessage responseProizvod = serviceProizvodi.GetResponseParams("GetProizvodiByParameters", new string[] { NazivProizvoda.Trim(), _cbxAktivan, _cbxObrisan, _cbxKategorija.ToString()});
            if (responseProizvod.IsSuccessStatusCode) {
                dgvProizvodi.RowTemplate.Height = 80;
                ((DataGridViewImageColumn)dgvProizvodi.Columns[7]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                dgvProizvodi.AutoGenerateColumns = false;
                listaProizvodi = responseProizvod.Content.ReadAsAsync<List<ProizvodVM>>().Result;
                dgvProizvodi.DataSource = listaProizvodi;
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e) {
            ClearInput();
        }

        private void ClearInput() {
            cbxAktivan.SelectedIndex = 0;
            cbxObrisan.SelectedIndex = 0;
            cbxKategorije.SelectedIndex = 0;
            txtNaziv.Text = "";
            dgvProizvodi.DataSource = null;
            dgvProizvodi.Rows.Clear();
            dgvProizvodi.Refresh();
            listaProizvodi.Clear();
        }

        //private void dgvProizvodi_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
        //    int ProizvodId = Convert.ToInt32(dgvProizvodi.SelectedRows[0].Cells[0].Value);
        //    new frmProizvodDetaljno(ProizvodId).ShowDialog();
        //    ClearInput();
        //}

        private void dgvProizvodi_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            int ProizvodId = Convert.ToInt32(dgvProizvodi.SelectedRows[0].Cells[0].Value);
            new frmProizvodDetaljno(ProizvodId).ShowDialog();
            ClearInput();
        }

        private void btnIspis_Click(object sender, EventArgs e) {
            if (listaProizvodi.Count == 0) {
                MessageBox.Show("Ne možete ispisati praznu listu!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reports.Reports rpt = new Reports.Reports(listaProizvodi, "Proizvodi");
            rpt.ShowDialog();
        }
    }
}
