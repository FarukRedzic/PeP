using PCL.Models;
using PCL.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WinPhoneUI.NotifikacijePhone;
using WinPhoneUI.Pages;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace WinPhoneUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");
        WebAPIHelper serviceLogovi = new WebAPIHelper("http://localhost:61718/", "api/Logovi");

        public static bool ZaboravioLozinkuPage = false;

        public Login()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        private async void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e) {
            Frame frame = Window.Current.Content as Frame;

            if ((Global.logiraniKorisnik == null && !ZaboravioLozinkuPage)) {
                MessageDialog msg = new MessageDialog("Vaša sesija je istekla!", "Greška!");
                e.Handled = true;
                await msg.ShowAsync();
                return;
            }
            if (frame != null) {
                try {
                    Frame.GoBack();
                    e.Handled = true;
                }
                catch (Exception) {
                    MessageDialog msg = new MessageDialog("Došlo je do greške!", "Greška!");
                    e.Handled = true;
                    await msg.ShowAsync();
                    return;
                }
            }

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private async void btnPrijava_Click(object sender, RoutedEventArgs e) {
            HttpResponseMessage response = serviceKorisnik.GetResponseParams("GetKorisnik", new string[] { txtKorisnickoIme.Text });
            if (response.IsSuccessStatusCode) {
                Korisnik k = response.Content.ReadAsAsync<Korisnik>().Result;
                if (UIHelper.GenerateHash(txtLozinka.Password, k.LozinkaSalt) == k.LozinkaHash && k.Aktivan == 1) {
                    Global.logiraniKorisnik = k;
                    NotificationPhone.StartNotificationTimer();
                    ZaboravioLozinkuPage = false;
                    Logovi log = new Logovi() {
                        DatumVrijeme = DateTime.Now,
                        Uspjesnost = true,
                        KorisnikId = k.Id
                    };
                    HttpResponseMessage responseLog = serviceLogovi.PostResponse(log);
                    // -> ispravan password
                    MessageDialog msg = new MessageDialog("Dobrodošli " + k.Ime + " " + k.Prezime + "!", "Poruka");
                    await msg.ShowAsync();
                    InputClear();
                    Frame.Navigate(typeof(MojProfil), Global.logiraniKorisnik.Id);
                }
                else // nije tacan password -> postoji korisnik
                {
                    txtLozinka.Password = "";
                    Logovi log = new Logovi() {
                        DatumVrijeme = DateTime.Now,
                        Uspjesnost = false,
                        KorisnikId = k.Id
                    };
                    HttpResponseMessage responseLog = serviceLogovi.PostResponse(log);
                    MessageDialog msg = new MessageDialog("Korisničko ime ili lozinka nisu ispravni!", "Poruka");
                    await msg.ShowAsync();
                }
            }
            else // nije tacan password -> ne postoji korisnik
            {
                Logovi log = new Logovi() {
                    DatumVrijeme = DateTime.Now,
                    Uspjesnost = false,
                    KorisnikId = null
                };
                HttpResponseMessage responseLog = serviceLogovi.PostResponse(log);
                MessageDialog msg = new MessageDialog("Korisničko ime ili lozinka nisu ispravni!", "Upozorenje");
                await msg.ShowAsync();
            }
        }

        private void btnRegistracija_Click(object sender, RoutedEventArgs e) {
            InputClear();
            Frame.Navigate(typeof(Registracija));
        }

        private void InputClear() {
            txtKorisnickoIme.Text = "";
            txtLozinka.Password = "";
        }

        private void btnZaboravioLozinku_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(ZaboravioLozinku));
        }

        private void btnIzlaz_Click(object sender, RoutedEventArgs e) {
            Application.Current.Exit();
        }
    }
}
