using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI.Models;
using WinFormUI.Util;

namespace WinFormUI.Forms {
    public partial class frmZaboravioLozinku : Form {

        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");

        public frmZaboravioLozinku() {
            InitializeComponent();
        }

        private void btnPosalji_Click(object sender, EventArgs e) {
            HttpResponseMessage response = serviceKorisnik.GetResponseParams("GetKorisnik", new string[] { txtUsername.Text.Trim() });
            if (response.IsSuccessStatusCode) {
                Korisnik k = response.Content.ReadAsAsync<Korisnik>().Result;
                string HostMail = "PePMailing@gmail.com";
                string HostPassword = "pep2015/2016";
                SmtpClient client = new SmtpClient {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(HostMail, HostPassword),
                    Timeout = 10000
                };
                string newPassword = CreateRandomPassword(8);
                string subject = "Oporavak lozinke";
                string body = "Poštovani, <b>" + k.Ime + " " + k.Prezime + "</b>.<br/>" + "Vaša nova lozinka je: <b>" + newPassword + "</b><br/>Molimo da prilikom sljedećeg logiranja promijenite lozinku!";
                MailMessage mm = new MailMessage(HostMail, k.Email, subject, body);
                mm.IsBodyHtml = true;
                client.Send(mm);
                MessageBox.Show("Molimo provjerite vaš email račun!", Global.GetMessage("Information"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                k.LozinkaSalt = Util.UIHelper.GenerateSalt();
                k.LozinkaHash = Util.UIHelper.GenerateHash(newPassword, k.LozinkaSalt);
                HttpResponseMessage responsePut = serviceKorisnik.PutResponse(k.Id,k);
                this.Close();
            }
            else {
                MessageBox.Show("Oporavak lozinke nije moguće izvršiti!",Global.GetMessage("warning"),MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            
        }
        private static string CreateRandomPassword(int passwordLength) {
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_-";
            char[] chars = new char[passwordLength];
            Random rd = new Random();

            for (int i = 0; i < passwordLength; i++) {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }

        private void btnOdustani_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
