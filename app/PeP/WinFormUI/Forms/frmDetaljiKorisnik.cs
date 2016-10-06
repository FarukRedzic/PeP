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
using WebAPI.Util;
using WebAPI.ViewModels;
using WinFormUI.Util;

namespace WinFormUI.Forms {
    public partial class frmDetaljiKorisnik : Form {
        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");
        WebAPIHelper serviceProizvodi = new WebAPIHelper("http://localhost:61718/", "api/Proizvod");
        WebAPIHelper serviceProizvodiKategorije = new WebAPIHelper("http://localhost:61718/", "api/Kategorija");
        WebAPIHelper serviceNarudzbe = new WebAPIHelper("http://localhost:61718/", "api/Narudzba");
        WebAPIHelper serviceFavoriti = new WebAPIHelper("http://localhost:61718/", "api/Favoriti");
        WebAPIHelper serviceDojmovi = new WebAPIHelper("http://localhost:61718/", "api/Dojam");
        List<ProizvodVM> listaProizvoda = new List<ProizvodVM>();
        List<ProizvodVM> listaProizvodi = new List<ProizvodVM>();
        List<NarudzbaVM> listaNarudzbe = new List<NarudzbaVM>();
        List<NarudzbaVM> listaProdao = new List<NarudzbaVM>();
        List<FavoritiVM> listaFavoriti = new List<FavoritiVM>();
        List<DojamVM> listaDojmovi = new List<DojamVM>();

        int KorisnikId;
        public frmDetaljiKorisnik(int KorisnikId) {
            InitializeComponent();
            this.KorisnikId = KorisnikId;
        }

        private void frmDetaljiKorisnik_Load(object sender, EventArgs e) {
            HttpResponseMessage response = serviceKorisnik.GetResponseParams("GetDetaljiKorisnik", new string[] { KorisnikId.ToString() });
            if (response.IsSuccessStatusCode) {
                Korisnik k = response.Content.ReadAsAsync<Korisnik>().Result;
                lblIme.Text = k.Ime;
                lblPrezime.Text = k.Prezime;
                lblUsername.Text = k.KorisnickoIme;
                lblEmail.Text = k.Email;
                lblTelefon.Text = k.Telefon;
                lblOpstina.Text = k.Opstina.Naziv;
                if (k.Aktivan == 1) { 
                    lblStatus.Text = "Aktivan";
                    btnAktivirajProfil.Visible = false;
                    btnDeaktivirajProfil.Visible = true;
                }
                else { 
                    lblStatus.Text = "Neaktivan";
                    btnAktivirajProfil.Visible = true;
                    btnDeaktivirajProfil.Visible = false;
                }
                MemoryStream ms = new MemoryStream(k.Slika);
                pbSlika.Image = Image.FromStream(ms);
                pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            HttpResponseMessage responseProizvodiKategorije = serviceProizvodiKategorije.GetResponse("GetKategorije");
            if (responseProizvodiKategorije.IsSuccessStatusCode) {
                List<Kategorija> lista = responseProizvodiKategorije.Content.ReadAsAsync<List<Kategorija>>().Result;
                cbxKategorijaProizvoda.DataSource = lista;
                cbxKategorijaProizvoda.DisplayMember = "Naziv";
                cbxKategorijaProizvoda.ValueMember = "Id";

                cbxKategorijaProizvodaNarudzbe.DataSource = lista;
                cbxKategorijaProizvodaNarudzbe.DisplayMember = "Naziv";
                cbxKategorijaProizvodaNarudzbe.ValueMember = "Id";

                cbxKategorijaProizvoda_Favoriti.DataSource = lista;
                cbxKategorijaProizvoda_Favoriti.DisplayMember = "Naziv";
                cbxKategorijaProizvoda_Favoriti.ValueMember = "Id";

                cbxKategorijaProdao.DataSource = lista;
                cbxKategorijaProdao.DisplayMember = "Naziv";
                cbxKategorijaProdao.ValueMember = "Id";
            }
            HttpResponseMessage pouzdanostResponse = serviceDojmovi.GetResponseParams("GetPouzdanost", new string[] { KorisnikId.ToString() });
            if (pouzdanostResponse.IsSuccessStatusCode) {
                lblPouzdanost.Text = pouzdanostResponse.Content.ReadAsAsync<string>().Result;
                lblPouzdanost.Text += "/10";
            }
            BindcbxOCjene();
        }

        private void BindcbxOCjene() {
            List<OcjenaVM> ocjene1 = new List<OcjenaVM>();
            List<OcjenaVM> ocjene2 = new List<OcjenaVM>();
            OcjenaVM ocjena = new OcjenaVM() { Id = 0, Ocjena = "-Odaberite ocjenu-" };
            ocjene1.Add(ocjena);
            ocjene2.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 1, Ocjena = "1" };
            ocjene1.Add(ocjena);
            ocjene2.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 2, Ocjena = "2" };
            ocjene1.Add(ocjena);
            ocjene2.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 3, Ocjena = "3" };
            ocjene1.Add(ocjena);
            ocjene2.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 4, Ocjena = "4" };
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

        private bool IznosInputValidacija(string start, string end) {
            double OD = 0, DO = 0;
            if (start == "" && end == "")
                return true;
            if ((start != "" && end == "") || (start == "" && end != ""))
                return false;
            if (double.TryParse(start, out OD) && double.TryParse(end, out DO))
                if ((OD >= 0 && DO >= 0) && (OD <= DO))
                    return true;
            return false;
        }

        private void btnTraziProizvode_Click(object sender, EventArgs e) {
            if (!IznosInputValidacija(txtCijenaOD.Text, txtCijenaDO.Text)) {
                MessageBox.Show("Neispravan opseg vrijednosti za cijenu!", Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string NazivProizvoda, CijenaOD, CijenaDO;
            NazivProizvoda = CijenaOD = CijenaDO = string.Empty;
            if (txtNazivProizvoda.Text == "")
                NazivProizvoda = "null";
            else
                NazivProizvoda = txtNazivProizvoda.Text;
            if (txtCijenaOD.Text == "")
                CijenaOD = int.MinValue.ToString();
            else
                CijenaOD = txtCijenaOD.Text;
            if (txtCijenaDO.Text == "")
                CijenaDO = int.MaxValue.ToString();
            else
                CijenaDO = txtCijenaDO.Text;

            HttpResponseMessage responseProizvod = serviceProizvodi.GetResponseParams("GetProizvodiByParameters", new string[] { KorisnikId.ToString(), NazivProizvoda.Trim(), Convert.ToInt32(cbxKategorijaProizvoda.SelectedValue).ToString(), CijenaOD.Trim(), CijenaDO.Trim() });
            if (responseProizvod.IsSuccessStatusCode) {
                dgvProizvodi.RowTemplate.Height = 80;
                ((DataGridViewImageColumn)dgvProizvodi.Columns[4]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                dgvProizvodi.AutoGenerateColumns = false;
                listaProizvoda = responseProizvod.Content.ReadAsAsync<List<ProizvodVM>>().Result;
                dgvProizvodi.DataSource = listaProizvoda;
            }
        }

        private void dgvProizvodi_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int ProizvodId = Convert.ToInt32(dgvProizvodi.SelectedRows[0].Cells[0].Value);
            new frmProizvodDetaljno(ProizvodId).ShowDialog();
        }

        private void btnOsvjeziProizvod_Click(object sender, EventArgs e) {
            ClearInputProizvodi();
            dgvProizvodi.DataSource = null;
            dgvProizvodi.Rows.Clear();
            dgvProizvodi.Refresh();
            listaProizvodi.Clear();
        }

        private void ClearInputProizvodi() {
            txtCijenaDO.Text = "";
            txtCijenaOD.Text = "";
            txtNazivProizvoda.Text = "";
            cbxKategorijaProizvoda.SelectedValue = -1;
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
            HttpResponseMessage responseNarudzba = serviceNarudzbe.GetResponseParams("GetNarudzbeByParams", new string[] { KorisnikId.ToString(),
                BrojNarudzbe.Trim(),
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

        private void btnTraziFavorite_Click(object sender, EventArgs e) {
            if (!IznosInputValidacija(txtCijenaOD_Favoriti.Text, txtCijenaDO_Favoriti.Text)) {
                MessageBox.Show("Neispravan opseg vrijednosti za cijenu!", Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string NazivProizvoda_Favoriti, CijenaOD_Favoriti, CijenaDO_Favoriti;
            NazivProizvoda_Favoriti = CijenaOD_Favoriti = CijenaDO_Favoriti = string.Empty;
            if (txtNazivProizvoda_Favoriti.Text == "")
                NazivProizvoda_Favoriti = "null";
            else
                NazivProizvoda_Favoriti = txtNazivProizvoda_Favoriti.Text;
            if (txtCijenaOD_Favoriti.Text == "")
                CijenaOD_Favoriti = int.MinValue.ToString();
            else
                CijenaOD_Favoriti = txtCijenaOD_Favoriti.Text;
            if (txtCijenaDO_Favoriti.Text == "")
                CijenaDO_Favoriti = int.MaxValue.ToString();
            else
                CijenaDO_Favoriti = txtCijenaDO_Favoriti.Text;

            HttpResponseMessage responseFavoriti = serviceFavoriti.GetResponseParams("GetFavoritiByParams", new string[] { KorisnikId.ToString(), NazivProizvoda_Favoriti.Trim(), Convert.ToInt32(cbxKategorijaProizvoda_Favoriti.SelectedValue).ToString(), CijenaOD_Favoriti.Trim(), CijenaDO_Favoriti.Trim() });
            if (responseFavoriti.IsSuccessStatusCode) {
                dgvFavoriti.RowTemplate.Height = 80;
                ((DataGridViewImageColumn)dgvFavoriti.Columns[4]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                dgvFavoriti.AutoGenerateColumns = false;
                listaFavoriti = responseFavoriti.Content.ReadAsAsync<List<FavoritiVM>>().Result;
                dgvFavoriti.DataSource = listaFavoriti;
            }
        }

        private void dgvFavoriti_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int FavoritId = Convert.ToInt32(dgvFavoriti.SelectedRows[0].Cells[0].Value);
            new frmFavoritDetaljno(FavoritId).ShowDialog();
        }

        private void btnTraziDojam_Click(object sender, EventArgs e) {
            string Ime_Dojam, Prezime_Dojam;
            Ime_Dojam = Prezime_Dojam = string.Empty;
            if (txtImeDojam.Text == "")
                Ime_Dojam = "null";
            else
                Ime_Dojam = txtImeDojam.Text;
            if (txtPrezimeDojam.Text == "")
                Prezime_Dojam = "null";
            else
                Prezime_Dojam = txtPrezimeDojam.Text;

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
            HttpResponseMessage responseDojam = serviceDojmovi.GetResponseParams("GetDojmoviByParams", new string[] { KorisnikId.ToString(), Ime_Dojam.Trim(), Prezime_Dojam.Trim(), OcjenaOD.ToString(), OcjenaDO.ToString()});
            if (responseDojam.IsSuccessStatusCode) {
                dgvDojmovi.AutoGenerateColumns = false;
                listaDojmovi = responseDojam.Content.ReadAsAsync<List<DojamVM>>().Result;
                dgvDojmovi.DataSource = listaDojmovi;
            }
        }

        private void dgvDojmovi_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int DojamId = Convert.ToInt32(dgvDojmovi.SelectedRows[0].Cells[0].Value);
            new frmDojam(DojamId).ShowDialog();
        }

        private void btnAktivirajProfil_Click(object sender, EventArgs e) {
            HttpResponseMessage response = serviceKorisnik.GetResponseParams("GetDetaljiKorisnik", new string[] { KorisnikId.ToString() });
            if (response.IsSuccessStatusCode) {
                Korisnik k = response.Content.ReadAsAsync<Korisnik>().Result;
                if (k.Aktivan == 1) {
                    MessageBox.Show("Korisnik je trenutno aktivan!", Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    k.Aktivan = 1;
                    HttpResponseMessage response2 = serviceKorisnik.PutResponse(KorisnikId, k);
                    if (response.IsSuccessStatusCode) {
                        MessageBox.Show("Korisnik je uspješno aktiviran!", Global.GetMessage("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void btnDeaktivirajProfil_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                HttpResponseMessage response = serviceKorisnik.GetResponseParams("GetDetaljiKorisnik", new string[] { KorisnikId.ToString() });
                if (response.IsSuccessStatusCode) {
                    Korisnik k = response.Content.ReadAsAsync<Korisnik>().Result;
                    if (k.Aktivan == 0) {
                        MessageBox.Show("Korisnik je trenutno neaktivan!", Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        k.Aktivan = 0;
                        HttpResponseMessage response2 = serviceKorisnik.PutResponse(KorisnikId, k);
                        if (response.IsSuccessStatusCode) {
                            MessageBox.Show("Korisnik je uspješno deaktiviran!", Global.GetMessage("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            else return;

        }

        private void btnOsvjeziDojam_Click(object sender, EventArgs e) {
            ClearInputDojmovi();
            dgvDojmovi.DataSource = null;
            dgvDojmovi.Rows.Clear();
            dgvDojmovi.Refresh();
            listaDojmovi.Clear();
        }

        private void ClearInputDojmovi() {
            cbxOcjenaOD.SelectedIndex = 0;
            cbxOcjenaDO.SelectedIndex = 0;
            txtImeDojam.Text = "";
            txtPrezimeDojam.Text = "";
        }

        private void btnOsvjeziFavorite_Click(object sender, EventArgs e) {
            ClearInputFavoriti();
            dgvFavoriti.DataSource = null;
            dgvFavoriti.Rows.Clear();
            dgvFavoriti.Refresh();
            listaFavoriti.Clear();
        }

        private void ClearInputFavoriti() {
            txtNazivProizvoda_Favoriti.Text = "";
            cbxKategorijaProizvoda_Favoriti.SelectedIndex = 0;
            txtCijenaOD_Favoriti.Text = "";
            txtCijenaDO_Favoriti.Text = "";
        }

        private void btnTraziProdao_Click(object sender, EventArgs e) {
            if (dtpODProdoa.Value > dtpDOProdao.Value) {
                MessageBox.Show("\"Početni datum\" ne može biti poslije \"Krajnji datum\".", Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string BrojNarudzbe = string.Empty;
            if (txtBrojNarudzbeProdao.Text == "")
                BrojNarudzbe = "null";
            else
                BrojNarudzbe = txtBrojNarudzbeProdao.Text;
            HttpResponseMessage responseNarudzba = serviceNarudzbe.GetResponseParams("GetProdaneByParams", new string[] { KorisnikId.ToString(),
                BrojNarudzbe.Trim(),
                Convert.ToInt32(cbxKategorijaProdao.SelectedValue).ToString(),
                dtpODProdoa.Value.ToApiDateTime(),
                dtpDOProdao.Value.ToApiDateTime() });
            if (responseNarudzba.IsSuccessStatusCode) {
                dgvProdao.AutoGenerateColumns = false;
                listaProdao = responseNarudzba.Content.ReadAsAsync<List<NarudzbaVM>>().Result;
                dgvProdao.DataSource = listaProdao;
            }
        }

        private void btnOsvjeziProdao_Click(object sender, EventArgs e) {
            ClearInputProdao();
            dgvProdao.DataSource = null;
            dgvProdao.Rows.Clear();
            dgvProdao.Refresh();
            listaProdao.Clear();
        }

        private void ClearInputProdao() {
            txtBrojNarudzbeProdao.Text = "";
            cbxKategorijaProdao.SelectedIndex = 0;
            dtpDOProdao.Value = dtpOD.MinDate;
            dtpDOProdao.Value = dtpDO.MaxDate;
        }

        private void btnIspis_Click(object sender, EventArgs e) {
            if (listaProizvoda.Count == 0) {
                MessageBox.Show("Ne možete ispisati praznu listu!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reports.Reports rpt = new Reports.Reports(listaProizvoda, "metroProizvodi");
            rpt.ShowDialog();
        }

        private void btnIspisDojmovi_Click(object sender, EventArgs e) {
            if (listaDojmovi.Count == 0) {
                MessageBox.Show("Ne možete ispisati praznu listu!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reports.Reports rpt = new Reports.Reports(listaDojmovi, "metroDojmovi");
            rpt.ShowDialog();
        }

        private void btnIspisFavoriti_Click(object sender, EventArgs e) {
            if (listaFavoriti.Count == 0) {
                MessageBox.Show("Ne možete ispisati praznu listu!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reports.Reports rpt = new Reports.Reports(listaFavoriti, "metroFavoriti");
            rpt.ShowDialog();
        }

        private void btnIspisProdao_Click(object sender, EventArgs e) {
            if (listaProdao.Count == 0) {
                MessageBox.Show("Ne možete ispisati praznu listu!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reports.Reports rpt = new Reports.Reports(listaProdao, "metroProdao");
            rpt.ShowDialog();
        }

        private void btnIspisNarudzbe_Click(object sender, EventArgs e) {
            if (listaNarudzbe.Count == 0) {
                MessageBox.Show("Ne možete ispisati praznu listu!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Reports.Reports rpt = new Reports.Reports(listaNarudzbe, "metroNarudzbe");
            rpt.ShowDialog();
        }
    }
}
