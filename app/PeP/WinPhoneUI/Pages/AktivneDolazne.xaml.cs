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
using WinPhoneUI.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace WinPhoneUI.Pages {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AktivneDolazne : Page {
        public AktivneDolazne() {
            this.InitializeComponent();
        }
        WebAPIHelper serviceNarudzbe = new WebAPIHelper("http://localhost:61718/", "api/Narudzba");
        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");
        WebAPIHelper serviceNotifikacije = new WebAPIHelper("http://localhost:61718/", "api/Notifikacije");

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            HttpResponseMessage responseDetalji = serviceKorisnik.GetResponse(Global.logiraniKorisnik.Id.ToString());
            Korisnik k;
            if (responseDetalji.IsSuccessStatusCode) {
                k = responseDetalji.Content.ReadAsAsync<Korisnik>().Result;
                Username.Text += k.KorisnickoIme;
                Mail.Text = k.Email;
            }
            HttpResponseMessage response = serviceNarudzbe.GetResponseParams("GetAktivneDolazne", Global.logiraniKorisnik.Id.ToString());
            if (response.IsSuccessStatusCode) {
                lvAktivneDolazne.ItemsSource = response.Content.ReadAsAsync<List<NarudzbaVM>>().Result;
            }
        }

        private void lvAktivneDolazne_ItemClick(object sender, ItemClickEventArgs e) {
            Frame.Navigate(typeof(ProcesirajAktivnu) ,((NarudzbaVM)e.ClickedItem).NarudzbaId);
        }
        private void btnNoviProizvod_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(ProizvodAdd));
        }

        private void btnHome_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojProfil), Global.logiraniKorisnik.Id);
        }

        private void btnPoruke_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(Poruke), Global.logiraniKorisnik.Id);
        }
    }
}
