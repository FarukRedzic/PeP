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
    public sealed partial class NoviKomentar : Page {
        public NoviKomentar() {
            this.InitializeComponent();
        }

        WebAPIHelper serviceKomentari = new WebAPIHelper("http://localhost:61718/", "api/Komentar");
        WebAPIHelper serviceNotifikacije = new WebAPIHelper("http://localhost:61718/", "api/Notifikacije");
        WebAPIHelper serviceProizvodi = new WebAPIHelper("http://localhost:61718/", "api/Proizvod");
        int ProizvodId;
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            this.ProizvodId = Convert.ToInt32(e.Parameter);
        }

        private async void btnPotvrdi_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(txtKomentar.Text)) {
                MessageDialog msg = new MessageDialog("Komentar ne može biti prazan!", "Upozorenje");
                await msg.ShowAsync();
                return;
            }
            Komentar k = new Komentar() {
                KorisnikId = Global.logiraniKorisnik.Id,
                ProizvodId = this.ProizvodId,
                Sadrzaj = txtKomentar.Text
            };
            HttpResponseMessage response = serviceKomentari.PostResponse(k);
                if (response.IsSuccessStatusCode) {
                    HttpResponseMessage responseProizvod = serviceProizvodi.GetResponse(ProizvodId.ToString());
                    if (response.IsSuccessStatusCode) {
                        Proizvod p = responseProizvod.Content.ReadAsAsync<Proizvod>().Result;
                    if (p.KorisnikId != Global.logiraniKorisnik.Id) {
                        Notifikacije not = new Notifikacije() { ProizvodId = ProizvodId, KorisnikId = p.KorisnikId, VrstaNotifikacijeId = 5, KomentarisaoProizvod = Global.logiraniKorisnik.KorisnickoIme };
                        HttpResponseMessage responseNot = serviceNotifikacije.PostResponse(not);
                    }
                }
                MessageDialog msg = new MessageDialog("Uspješno ste komentarisali proizvod!", "Poruka");
                await msg.ShowAsync();
                ClearInput();
                Frame.Navigate(typeof(ProizvodDetalji), ProizvodId);
            }

        }

        private void ClearInput() {
            txtKomentar.Text = "";
        }

        private void btnHome_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojProfil), Global.logiraniKorisnik.Id);
        }

        private void btnNoviProizvod_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(ProizvodAdd));
        }

        private void btnPoruke_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(Poruke), Global.logiraniKorisnik.Id);
        }

        private void btnNarudzbe_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojeNarudzbe), Global.logiraniKorisnik.Id);
        }
    }
}
