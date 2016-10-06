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
    public sealed partial class MojeNarudzbe : Page {
        public MojeNarudzbe() {
            this.InitializeComponent();
        }
        WebAPIHelper serviceNarudzbe = new WebAPIHelper("http://localhost:61718/","api/Narudzba");
        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");
        int KorisnikId;
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            KorisnikId = (int)e.Parameter;
            HttpResponseMessage responseDetalji = serviceKorisnik.GetResponse(Global.logiraniKorisnik.Id.ToString());
            Korisnik k;
            if (responseDetalji.IsSuccessStatusCode) {
                k = responseDetalji.Content.ReadAsAsync<Korisnik>().Result;
                Username.Text += k.KorisnickoIme;
                Mail.Text = k.Email;
            }
            HttpResponseMessage response1 = serviceNarudzbe.GetResponseParams("GetBrojZahtjeva", KorisnikId.ToString());
            if (response1.IsSuccessStatusCode)
                BrojZahtjeva.Text += response1.Content.ReadAsAsync<int>().Result.ToString();

            HttpResponseMessage response2 = serviceNarudzbe.GetResponseParams("GetBrojAktivnih", KorisnikId.ToString());
            if (response1.IsSuccessStatusCode)
                BrojAktivnih.Text += response2.Content.ReadAsAsync<int>().Result.ToString();

            HttpResponseMessage response3 = serviceNarudzbe.GetResponseParams("GetBrojOtkazanih", KorisnikId.ToString());
            if (response1.IsSuccessStatusCode)
                BrojOtkazanih.Text += response3.Content.ReadAsAsync<int>().Result.ToString();
        }

 
        private void imgZahtjevi_Tapped(object sender, TappedRoutedEventArgs e) {
            Frame.Navigate(typeof(ZahtjeviNarudzbe), KorisnikId);
        }
        private void tbZahtjevi_Tapped(object sender, TappedRoutedEventArgs e) {
            Frame.Navigate(typeof(ZahtjeviNarudzbe), KorisnikId);
        }
 
        private void imgAktivne_Tapped(object sender, TappedRoutedEventArgs e) {
            Frame.Navigate(typeof(AktivneNarudzbe), KorisnikId);
        }
        private void Aktivne_Tapped(object sender, TappedRoutedEventArgs e) {
            Frame.Navigate(typeof(AktivneNarudzbe), KorisnikId);
        }
        #region Meni
        private void btnNoviProizvod_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(ProizvodAdd));
        }

        private void btnHome_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojProfil), Global.logiraniKorisnik.Id);
        }

        private void btnPoruke_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(Poruke), Global.logiraniKorisnik.Id);
        }
        #endregion

    }
}
