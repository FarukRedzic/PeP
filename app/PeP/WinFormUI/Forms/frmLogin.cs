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

namespace WinFormUI.Forms
{
    public partial class frmLogin : Form
    {
        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");
        WebAPIHelper serviceLogovi = new WebAPIHelper("http://localhost:61718/", "api/Logovi");

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            lblFocus.Focus();
            HttpResponseMessage response = serviceKorisnik.GetResponseParams("GetKorisnik", new string[] { txtUsername.Text });
            if (response.IsSuccessStatusCode)
            {
                Korisnik k = response.Content.ReadAsAsync<Korisnik>().Result;
                if (UIHelper.GenerateHash(txtLozinka.Text, k.LozinkaSalt) == k.LozinkaHash && k.Aktivan == 1)
                {
                    Global.logiraniKorisnik = k;
                    Logovi log = new Logovi()
                    {
                        DatumVrijeme = DateTime.Now,
                        Uspjesnost = true,
                        KorisnikId = k.Id
                    };
                    HttpResponseMessage responseLog = serviceLogovi.PostResponse(log);
                    this.Hide();
                    Global.frmMain = new frmMain();
                    Global.frmMain.Show();
                }
                else // nije tacan password -> postoji korisnik
                {
                    txtLozinka.Text = "";
                    lblFocus.Focus();
                    Logovi log = new Logovi()
                    {
                        DatumVrijeme = DateTime.Now,
                        Uspjesnost = false,
                        KorisnikId = k.Id
                    };
                    HttpResponseMessage responseLog = serviceLogovi.PostResponse(log);
                    MessageBox.Show(Global.GetMessage("login_err"), Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else // nije tacan password -> ne postoji korisnik
            {
                txtLozinka.Text = "";
                lblFocus.Focus();
                Logovi log = new Logovi()
                {
                    DatumVrijeme = DateTime.Now,
                    Uspjesnost = false,
                    KorisnikId = null
                };
                HttpResponseMessage responseLog = serviceLogovi.PostResponse(log);
                MessageBox.Show(Global.GetMessage("login_err"), Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblFocus.Focus();
        }

        private void lnkLozinka_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new frmZaboravioLozinku().ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void label10_Click(object sender, EventArgs e) {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e) {

        }

        private void txtLozinka_TextChanged(object sender, EventArgs e) {

        }

        private void lblFocus_Click(object sender, EventArgs e) {

        }
    }
}
