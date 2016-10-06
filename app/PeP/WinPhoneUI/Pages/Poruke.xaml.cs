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
    public sealed partial class Poruke : Page {
        public Poruke() {
            this.InitializeComponent();
        }
        WebAPIHelper servicePoruke = new WebAPIHelper("http://localhost:61718/", "api/Poruka");
        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");

        int KorisnikId;


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            this.KorisnikId = Convert.ToInt32(e.Parameter);

            HttpResponseMessage responseK = serviceKorisnik.GetResponse(KorisnikId.ToString());
            if (responseK.IsSuccessStatusCode) 
            {
                Korisnik k = responseK.Content.ReadAsAsync<Korisnik>().Result;
                Username.Text = k.KorisnickoIme;
                Mail.Text = k.Email;
            }

                HttpResponseMessage response = servicePoruke.GetResponseParams("GetBrojPorukaInbox", KorisnikId.ToString());
            if (response.IsSuccessStatusCode)
                BrojPorukaInbox.Text += response.Content.ReadAsAsync<int>().Result.ToString();

            HttpResponseMessage response2 = servicePoruke.GetResponseParams("GetBrojNeprocitanihInbox", KorisnikId.ToString());
            if (response.IsSuccessStatusCode) { 
                BrojPorukaInbox.Text += "(";
                BrojPorukaInbox.Text += response2.Content.ReadAsAsync<int>().Result.ToString();
                BrojPorukaInbox.Text += ")";
            }

            HttpResponseMessage response3 = servicePoruke.GetResponseParams("GetBrojPorukaOutbox", KorisnikId.ToString());
            if (response.IsSuccessStatusCode)
                BrojPorukaOutbox.Text += response3.Content.ReadAsAsync<int>().Result.ToString();

            HttpResponseMessage response4 = servicePoruke.GetResponseParams("GetBrojProcitanihOutbox", KorisnikId.ToString());
            if (response.IsSuccessStatusCode) {
                BrojPorukaOutbox.Text += "(";
                BrojPorukaOutbox.Text += response4.Content.ReadAsAsync<int>().Result.ToString();
                BrojPorukaOutbox.Text += ")";
            }
        }

        private void imgInbox_Tapped(object sender, TappedRoutedEventArgs e) {
            Frame.Navigate(typeof(Inbox), KorisnikId);
        }

        private void imgOutbox_Tapped(object sender, TappedRoutedEventArgs e) {
            Frame.Navigate(typeof(Outbox), KorisnikId);
        }

        private void tbOutbox_Tapped(object sender, TappedRoutedEventArgs e) {
            Frame.Navigate(typeof(Outbox), KorisnikId);
        }

        private void tbInbox_Tapped(object sender, TappedRoutedEventArgs e) {
            Frame.Navigate(typeof(Inbox), KorisnikId);
        }
        private void btnNoviProizvod_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(ProizvodAdd));
        }

        private void btnHome_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojProfil), Global.logiraniKorisnik.Id);
        }

        private void btnNarudzbe_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojeNarudzbe), Global.logiraniKorisnik.Id);
        }
    }
}
