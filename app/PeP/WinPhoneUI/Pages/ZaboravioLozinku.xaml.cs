using PCL.Models;
using PCL.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Email;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace WinPhoneUI.Pages {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ZaboravioLozinku : Page {

        public ZaboravioLozinku() {
            this.InitializeComponent();
            Login.ZaboravioLozinkuPage = true;
        }
        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
        }

        private async void btnPosalji_Click(object sender, RoutedEventArgs e) {
            HttpResponseMessage response = serviceKorisnik.GetResponseParams("GetKorisnik", new string[] { txtKorisnickoIme.Text.Trim() });
            if (response.IsSuccessStatusCode) {
                Korisnik k = response.Content.ReadAsAsync<Korisnik>().Result;

                EmailRecipient primaoc = new EmailRecipient() 
                {
                    Name = k.Ime + " " + k.Prezime,
                    Address = k.Email
                };
                string newPassword = CreateRandomPassword(8);

                EmailMessage email = new EmailMessage() {
                    Subject = "Oporavak lozinke",
                    Body = "Poštovani, " + k.Ime + " " + k.Prezime + "\nVaša nova lozinka je: " + newPassword + "\nMolimo da prilikom sljedećeg logiranja promijenite lozinku!\n",

                };

                email.To.Add(primaoc);
                await EmailManager.ShowComposeNewEmailAsync(email);

                MessageDialog msg = new MessageDialog("Molimo provjerite vaš email račun!", "Poruka");
                await msg.ShowAsync();
                txtKorisnickoIme.Text = "";
                k.LozinkaSalt = PCL.Util.UIHelper.GenerateSalt();
                k.LozinkaHash = PCL.Util.UIHelper.GenerateHash(newPassword, k.LozinkaSalt);
                HttpResponseMessage responsePut = serviceKorisnik.PutResponse(k.Id, k);
            }
            else {
                MessageDialog msg = new MessageDialog("Oporavak lozinke nije moguće izvršiti!", "Poruka");
                await msg.ShowAsync();
                return;
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
    }
}
