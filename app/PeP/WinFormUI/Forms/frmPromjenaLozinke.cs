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
    public partial class frmPromjenaLozinke : Form {
        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");

        public frmPromjenaLozinke() {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSnimi_Click(object sender, EventArgs e) {
            if (this.ValidateChildren()) {
                HttpResponseMessage response = serviceKorisnik.GetResponseParams("GetKorisnik", new string[] { Global.logiraniKorisnik.KorisnickoIme });
                if (response.IsSuccessStatusCode) {
                    Korisnik k = response.Content.ReadAsAsync<Korisnik>().Result;
                    if (UIHelper.GenerateHash(txtStaraLozinka.Text, k.LozinkaSalt) == k.LozinkaHash && txtNovaLozinkaPotvrda.Text.Trim() == txtNovaLozinka.Text.Trim()) {
                        k.LozinkaSalt = Util.UIHelper.GenerateSalt();
                        k.LozinkaHash = Util.UIHelper.GenerateHash(txtNovaLozinka.Text.Trim(), k.LozinkaSalt);
                        HttpResponseMessage responsePut = serviceKorisnik.PutResponse(k.Id, k);
                        MessageBox.Show("Lozinka je uspješno promijenjena!", Global.GetMessage("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInput();
                        this.Close();
                    }
                    else if (UIHelper.GenerateHash(txtStaraLozinka.Text, k.LozinkaSalt) != k.LozinkaHash) {
                        MessageBox.Show("Stara lozinka nije ispravna!", Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txtNovaLozinkaPotvrda.Text.Trim() != txtNovaLozinka.Text.Trim()) {
                        MessageBox.Show("Potvrda lozinke se ne podudara sa novom lozinkom!", Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void ClearInput() {
            txtNovaLozinka.Text = "";
            txtNovaLozinkaPotvrda.Text = "";
            txtStaraLozinka.Text = "";
        }

        private void txtNovaLozinka_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(txtNovaLozinka.Text)) {
                e.Cancel = true;
                errorProvider.SetError(txtNovaLozinka, "Nova lozinka je obavezno polje!");
            }
            else if (txtNovaLozinka.Text.Length < 5) {
                e.Cancel = true;
                errorProvider.SetError(txtNovaLozinka, Global.GetMessage("passwMin_err"));
            }
            else
                errorProvider.SetError(txtNovaLozinka, "");
        }
    }
}
