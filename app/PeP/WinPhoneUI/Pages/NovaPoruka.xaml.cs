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
    public sealed partial class NovaPoruka : Page {
        public NovaPoruka() {
            this.InitializeComponent();
        }
        WebAPIHelper servicePoruke = new WebAPIHelper("http://localhost:61718/", "api/Poruka");
        WebAPIHelper serviceKorisnici = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");
        WebAPIHelper serviceNotifikacije = new WebAPIHelper("http://localhost:61718/", "api/Notifikacije");

        int PrimaocId;
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            this.PrimaocId = Convert.ToInt32(e.Parameter);

            HttpResponseMessage response = serviceKorisnici.GetResponse(PrimaocId.ToString());
            if (response.IsSuccessStatusCode) {
                Korisnik k = response.Content.ReadAsAsync<Korisnik>().Result;
                tbPrimaoc.Text += k.KorisnickoIme;
            }
        }


        private async void btnPosalji_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(txtNaslov.Text)) {
                MessageDialog msg = new MessageDialog("Naslov ne može biti prazan!", "Upozorenje");
                await msg.ShowAsync();
                txtNaslov.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            if (string.IsNullOrEmpty(txtNaslov.Text)) {
                MessageDialog msg = new MessageDialog("Sadržaj poruke ne može biti prazan!", "Upozorenje");
                await msg.ShowAsync();
                txtNaslov.BorderBrush = null;
                txtSadrzaj.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            txtNaslov.BorderBrush = null;
            txtSadrzaj.BorderBrush = null;
            Poruka p = new Poruka() { DatumVrijeme = DateTime.Now, PosiljaocId = Global.logiraniKorisnik.Id, PrimaocId = this.PrimaocId, Sadrzaj = txtSadrzaj.Text.Trim(), Naslov = txtNaslov.Text  };
            HttpResponseMessage response = servicePoruke.PostResponse(p);
            if (response.IsSuccessStatusCode) {
                Notifikacije not = new Notifikacije() { KorisnikId = PrimaocId, VrstaNotifikacijeId = 6, PoslaoPoruku = Global.logiraniKorisnik.KorisnickoIme };
                HttpResponseMessage responseNot = serviceNotifikacije.PostResponse(not);
                MessageDialog msg = new MessageDialog("Poruka je uspješno poslana!", "Poruka");
                await msg.ShowAsync();
                Frame.Navigate(typeof(MojProfil), Global.logiraniKorisnik.Id);
                return;
            }
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(ProizvodAdd));
        }

        private void btnHome_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojProfil), Global.logiraniKorisnik.Id);
        }

        private void btnPoruke_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(Poruke), Global.logiraniKorisnik.Id);
        }

        private void btnNarudzbe_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojeNarudzbe), Global.logiraniKorisnik.Id);
        }
    }
}
