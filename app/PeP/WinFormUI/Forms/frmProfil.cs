using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI.Models;
using WinFormUI.Util;
using WinFormUI.ViewModels;

namespace WinFormUI.Forms {
    public partial class frmProfil : Form {
        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");
        private SlikaVM Slika { get; set; }
        private Korisnik k;
        #region singleton
        public static frmProfil frm = null;
        private frmProfil() // private konstruktor
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        public static frmProfil SingletonInstance() //metoda za otvaranje forme
        {
            if (frm == null)
                frm = new frmProfil();
            return frm;
        }
        #endregion

        private void frmProfil_Load(object sender, EventArgs e) {
            BindOpstine();
            HttpResponseMessage response = serviceKorisnik.GetResponse(Global.logiraniKorisnik.Id.ToString());
            if (response.IsSuccessStatusCode) {
                k = response.Content.ReadAsAsync<Korisnik>().Result;
                txtIme.Text = k.Ime;
                txtPrezime.Text = k.Prezime;
                txtEmail.Text = k.Email;
                txtTelefon.Text = k.Telefon;
                cbxOpstina.SelectedValue = k.OpstinaId;
                txtUsername.Text = k.KorisnickoIme;
                Slika = new SlikaVM();
                Slika.Slika = k.Slika;
                MemoryStream ms = new MemoryStream(k.Slika);
                pictureBox.Image = Image.FromStream(ms);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void BindOpstine() {
            HttpResponseMessage response = serviceKorisnik.GetResponse("GetOpstine");
            if (response.IsSuccessStatusCode) {
                List<Opstina> opstine = response.Content.ReadAsAsync<List<Opstina>>().Result;
                cbxOpstina.DataSource = opstine;
                cbxOpstina.DisplayMember = "Naziv";
                cbxOpstina.ValueMember = "Id";
            }
        }

        private void btnPretraziSliku_Click(object sender, EventArgs e) {
            txtSlikaInput.Enabled = false;
            openFileDialog.ShowDialog();
            txtSlikaInput.Text = openFileDialog.FileName;
            if (openFileDialog.FileName != "")
                Slika = new SlikaVM();

            int WidthMin = Convert.ToInt32(ConfigurationManager.AppSettings["WidthMin"]);
            int HeightMin = Convert.ToInt32(ConfigurationManager.AppSettings["HeightMin"]);

            try {
                Image image = Image.FromFile(openFileDialog.FileName);
                MemoryStream ms = new MemoryStream();
                if (!(image.Width > WidthMin || image.Height > HeightMin)) {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    Slika.Slika = ms.ToArray(); // Slika (niz bajtova)

                    pictureBox.Image = image;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else {
                    MessageBox.Show("Potrebno je da odaberete sliku dimenzija većih od" + " " + WidthMin + "x" + HeightMin + ".", Global.GetMessage("warning"),
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSlikaInput.Clear();
                }
            }
            catch (OutOfMemoryException) // ne koristim ex.Message
            {
                MessageBox.Show(Owner, Global.GetMessage("pictureFormat_err"), Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSlikaInput.Clear();
            }
            catch (FileNotFoundException) {
                txtSlikaInput.Clear();
            }
            catch (ArgumentException) {
                txtSlikaInput.Clear();
            }
        }

        private void btnSnimiKorisnik_Click(object sender, EventArgs e) {
            if (this.ValidateChildren()) {
                k.Ime = txtIme.Text;
                k.Prezime = txtPrezime.Text;
                k.Email = txtEmail.Text;
                k.Telefon = txtTelefon.Text;
                k.OpstinaId = Convert.ToInt32(cbxOpstina.SelectedValue);
                k.KorisnickoIme = txtUsername.Text;
                k.Slika = Slika.Slika;
                HttpResponseMessage response = serviceKorisnik.PutResponse(Global.logiraniKorisnik.Id,
                    k);
                if (response.IsSuccessStatusCode) {
                    MessageBox.Show(Owner, "Uspješno ste izmijenili vaše podatke!", Global.GetMessage("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        #region Validacija
        private void txtIme_Validating(object sender, CancelEventArgs e) {
            if (String.IsNullOrEmpty(txtIme.Text)) {
                e.Cancel = true;
                errorProvider.SetError(txtIme, Global.GetMessage("fname_req"));
            }
            else {
                errorProvider.SetError(txtIme, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(txtEmail.Text)) {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Global.GetMessage("email_req"));
            }
            else {
                try {
                    MailAddress mail = new MailAddress(txtEmail.Text);
                    errorProvider.SetError(txtEmail, "");
                }
                catch (Exception) {
                    e.Cancel = true;
                    errorProvider.SetError(txtEmail, Global.GetMessage("emailRegex_err"));
                }
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e) {
            if (String.IsNullOrEmpty(txtPrezime.Text)) {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, Global.GetMessage("lname_req"));
            }
            else
                errorProvider.SetError(txtPrezime, "");
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e) {
            if (!txtTelefon.Text.Any(char.IsDigit)) {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, Global.GetMessage("phone_req"));
            }
            else {
                int space = txtTelefon.Text.Count(x => x == ' ');
                if (space > 1) {
                    e.Cancel = true;
                    errorProvider.SetError(txtTelefon, Global.GetMessage("phoneLength_err"));
                }
                else
                    errorProvider.SetError(txtTelefon, "");
            }
        }

        private void cbxOpstina_Validating(object sender, CancelEventArgs e) {
            if (Convert.ToInt32(cbxOpstina.SelectedValue) == 0) {
                e.Cancel = true;
                errorProvider.SetError(cbxOpstina, Global.GetMessage("opstina_req"));
            }
            else
                errorProvider.SetError(cbxOpstina, "");
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(txtUsername.Text)) {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, Global.GetMessage("username_req"));
            }
            else if (txtUsername.Text.Length < 4) {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, Global.GetMessage("usernameMinLength_err"));
            }
            else if (txtUsername.Text.Length > 20) {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, Global.GetMessage("usernameMaxLength_err"));
            }
            else
                errorProvider.SetError(txtUsername, "");
        }


        #endregion

        private void btnDeaktivirajSe_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) {
                k.Aktivan = 0;
                HttpResponseMessage response = serviceKorisnik.PutResponse(Global.logiraniKorisnik.Id,
                    k);
                if (response.IsSuccessStatusCode) {
                    MessageBox.Show(Owner, "Vaš administratorski račun je deaktiviran!", Global.GetMessage("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Global.frmMain.Close();
                    RunningForm.OpenForm = new Form();
                    new frmLogin().Show();
                }
            }
            else return;
        }

        private void btnPromjenaLozinke_Click(object sender, EventArgs e) {
            new frmPromjenaLozinke().ShowDialog();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e) {
            HttpResponseMessage response = serviceKorisnik.GetResponse(Global.logiraniKorisnik.Id.ToString());
            if (response.IsSuccessStatusCode) {
                k = response.Content.ReadAsAsync<Korisnik>().Result;
                txtIme.Text = k.Ime;
                txtPrezime.Text = k.Prezime;
                txtEmail.Text = k.Email;
                txtTelefon.Text = k.Telefon;
                cbxOpstina.SelectedValue = k.OpstinaId;
                txtUsername.Text = k.KorisnickoIme;
                Slika = new SlikaVM();
                Slika.Slika = k.Slika;
                MemoryStream ms = new MemoryStream(k.Slika);
                pictureBox.Image = Image.FromStream(ms);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
