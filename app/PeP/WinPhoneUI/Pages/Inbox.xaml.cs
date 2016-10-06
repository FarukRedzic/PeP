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
using WinPhoneUI.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace WinPhoneUI.Pages {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Inbox : Page {
        public Inbox() {
            this.InitializeComponent();
        }
        WebAPIHelper servicePoruke = new WebAPIHelper("http://localhost:61718/", "api/Poruka");
        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");
        WebAPIHelper serviceNotifikacije = new WebAPIHelper("http://localhost:61718/", "api/Notifikacije");
        int KorisnikId;
        Poruka p;
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            this.KorisnikId = Convert.ToInt32(e.Parameter);

            HttpResponseMessage responseK = serviceKorisnik.GetResponse(KorisnikId.ToString());
            if (responseK.IsSuccessStatusCode) {
                Korisnik k = responseK.Content.ReadAsAsync<Korisnik>().Result;
                Username.Text = k.KorisnickoIme;
                Mail.Text = k.Email;
            }
            HttpResponseMessage responsePoruke = servicePoruke.GetResponseParams("GetDolazne", KorisnikId.ToString());
            if (responsePoruke.IsSuccessStatusCode) {
                lvInbox.ItemsSource = responsePoruke.Content.ReadAsAsync<List<PorukaVM>>().Result;
            }

            HttpResponseMessage responseNotifikacija = serviceNotifikacije.GetResponseParams("GetNotifikacijeDolaznaPoruka", Global.logiraniKorisnik.Id.ToString());
            if (responseNotifikacija.IsSuccessStatusCode) {
                List<Notifikacije> lista = responseNotifikacija.Content.ReadAsAsync<List<Notifikacije>>().Result;
                for (int i = 0; i < lista.Count; i++) {
                    lista[i].isNeaktivna = true;
                    HttpResponseMessage responsePut = serviceNotifikacije.PutResponse(lista[i].Id, lista[i]);
                }
            }
        }

        private void lvInbox_ItemClick(object sender, ItemClickEventArgs e) {
            Frame.Navigate(typeof(PregledPoruka), ((PorukaVM)e.ClickedItem).Id);
        }

        private async void lvInbox_Holding(object sender, HoldingRoutedEventArgs e) {
            if (Global.logiraniKorisnik.Id == KorisnikId) {
                FrameworkElement element = (FrameworkElement)e.OriginalSource;
                if (element.DataContext != null && element.DataContext is PorukaVM) {
                    int PorukaId = ((PorukaVM)element.DataContext).Id;
                    HttpResponseMessage responsePoruka = servicePoruke.GetResponse(PorukaId.ToString());
                    if (responsePoruka.IsSuccessStatusCode) {
                        p = responsePoruka.Content.ReadAsAsync<Poruka>().Result;
                        p.isDeletedPrimljena = true;
                        HttpResponseMessage response = servicePoruke.PutResponse(PorukaId, p);
                        if (response.IsSuccessStatusCode) {
                            MessageDialog msg = new MessageDialog("Uspješno ste izbrisali poruku!", "Poruka");
                            try {
                                await msg.ShowAsync();
                            }
                            catch (Exception) {
                                Frame.Navigate(typeof(Poruke), KorisnikId);
                            }
                        }
                    }
                }
            }
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

        private void NoviProizvod_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(ProizvodAdd));
        }
    }
}
