using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI.Models;
using WebAPI.ViewModels;
using WinFormUI.Util;
using WinFormUI.ViewModels;
using System.Web.Http;
using System.Net;
using System.Net.Mail;

namespace WinFormUI.Forms
{
    public partial class frmNoviAdmin : Form
    {
        WebAPIHelper webAPI = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");

        private SlikaVM Slika { get; set; }
        #region singleton
        public static frmNoviAdmin frm = null;
        private frmNoviAdmin() // private konstruktor
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        public static frmNoviAdmin SingletonInstance() //metoda za otvaranje forme
        {
            if (frm == null)
                frm = new frmNoviAdmin();
            return frm;
        }
        #endregion

        private void btnSnimiAdmin_Click(object sender, EventArgs e)
        {
            if (chkIsTrgovina.Checked && chkKorisnickiNalog.Checked == false) {
                MessageBox.Show(Global.GetMessage("isTrgovina_err"), Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lblFocus.Focus();
            if (this.ValidateChildren())
            {
                KorisnikVM k = new KorisnikVM();
                k.Ime = txtIme.Text;
                k.Prezime = txtPrezime.Text;
                k.Telefon = txtTelefon.Text;
                k.KorisnickoIme = txtUsername.Text;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(txtLozinka.Text, k.LozinkaSalt);
                k.OpstinaId = Convert.ToInt32(cbxOpstina.SelectedValue);
                k.UlogaId = 1;
                k.Email = txtEmail.Text;
                k.chkKorisnickiNalog = chkKorisnickiNalog.Checked;
                k.IsTrgovina = chkIsTrgovina.Checked;
                try
                {
                    k.Slika = Slika.Slika;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show(Global.GetMessage("picture_err"), Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                HttpResponseMessage response = webAPI.PostResponse("PostKorisnik", k);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Owner, "Administrator je uspješno dodan! ID: " + response.Content.ReadAsAsync<Korisnik>().Result.Id, Global.GetMessage("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Greška: " + response.StatusCode + Environment.NewLine +
                        "Poruka: " + response.ReasonPhrase, Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void ClearInput()
        {
            txtIme.Text = txtPrezime.Text = txtTelefon.Text = txtUsername.Text = txtLozinka.Text = txtEmail.Text = "";
            cbxOpstina.SelectedValue = 0;
            pictureBox.Image = null;
            openFileDialog.FileName = "";
            txtSlikaInput.Clear();
            chkIsTrgovina.Checked = false;
            chkKorisnickiNalog.Checked = false;
        }

        private void frmNoviAdmin_Load(object sender, EventArgs e)
        {
            BindOpstine();
        }

        private void BindOpstine()
        {
            HttpResponseMessage response = webAPI.GetResponse("GetOpstine");
            if (response.IsSuccessStatusCode)
            {
                List<Opstina> opstine = response.Content.ReadAsAsync<List<Opstina>>().Result;
                cbxOpstina.DataSource = opstine;
                cbxOpstina.DisplayMember = "Naziv";
                cbxOpstina.ValueMember = "Id";
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            ClearInput();
        }

        private void btnPretraziSliku_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            txtSlikaInput.Enabled = false;
            openFileDialog.ShowDialog();
            txtSlikaInput.Text = openFileDialog.FileName;
            if (openFileDialog.FileName != "")
                Slika = new SlikaVM();

            int WidthMin = Convert.ToInt32(ConfigurationManager.AppSettings["WidthMin"]);
            int HeightMin = Convert.ToInt32(ConfigurationManager.AppSettings["HeightMin"]);

            try
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                MemoryStream ms = new MemoryStream();
                if (!(image.Width < WidthMin || image.Height < HeightMin))
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    Slika.Slika = ms.ToArray(); // Slika (niz bajtova)

                    pictureBox.Image = image;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
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
            catch (FileNotFoundException)
            {
                txtSlikaInput.Clear();
            }
            catch (ArgumentException)
            {
                txtSlikaInput.Clear();
            }
        }
        #region Validacija
        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, Global.GetMessage("fname_req"));
            }
            else
            {
                errorProvider.SetError(txtIme, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Global.GetMessage("email_req"));
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(txtEmail.Text);
                    errorProvider.SetError(txtEmail, "");
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtEmail, Global.GetMessage("emailRegex_err"));
                }
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, Global.GetMessage("lname_req"));
            }
            else
                errorProvider.SetError(txtPrezime, "");
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (!txtTelefon.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, Global.GetMessage("phone_req"));
            }
            else
            {
                int space = txtTelefon.Text.Count(x => x == ' ');
                if (space > 1) {
                    e.Cancel = true;
                    errorProvider.SetError(txtTelefon, Global.GetMessage("phoneLength_err"));
                }
                else
                    errorProvider.SetError(txtTelefon, "");
            }
        }

        private void cbxOpstina_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(cbxOpstina.SelectedValue) == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cbxOpstina, Global.GetMessage("opstina_req"));
            }
            else
                errorProvider.SetError(cbxOpstina, "");
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, Global.GetMessage("username_req"));
            }
            else if (txtUsername.Text.Length < 4)
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, Global.GetMessage("usernameMinLength_err"));
            }
            else if (txtUsername.Text.Length > 20)
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, Global.GetMessage("usernameMaxLength_err"));
            }
            else
                errorProvider.SetError(txtUsername, "");
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLozinka.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Global.GetMessage("passw_req"));
            }
            else if (txtLozinka.Text.Length < 5)
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Global.GetMessage("passwMin_err"));
            }
            else
                errorProvider.SetError(txtLozinka, "");
        }
        #endregion

    }
}
