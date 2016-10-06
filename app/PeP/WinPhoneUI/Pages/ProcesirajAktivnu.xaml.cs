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
    public sealed partial class ProcesirajAktivnu : Page {
        public ProcesirajAktivnu() {
            this.InitializeComponent();
        }
        WebAPIHelper serviceNarudzbe = new WebAPIHelper("http://localhost:61718/", "api/Narudzba");
        WebAPIHelper serviceNotifikacije = new WebAPIHelper("http://localhost:61718/", "api/Notifikacije");


        int NarudzbaId;
        Narudzba n;
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            NarudzbaId = (int)e.Parameter;

            HttpResponseMessage response = serviceNarudzbe.GetResponseParams(NarudzbaId.ToString());
            if (response.IsSuccessStatusCode) {
                n = response.Content.ReadAsAsync<Narudzba>().Result;
                tbPrimaoc.Text += n.Proizvod.Korisnik.KorisnickoIme;
                tbKreirao.Text += n.Korisnik.KorisnickoIme;
                txtNapomena.Text = n.NapomenaPosiljaoc;
                tbProizvod.Text += n.Proizvod.Naziv + ", " + n.Proizvod.Cijena.ToString() + " KM";
                if (Global.logiraniKorisnik.Id == n.KorisnikId) {
                    btnOtkazi.Visibility = Visibility.Collapsed;
                }
                else {
                    btnZakljuci.Visibility = Visibility.Collapsed;
                }
            }
        }

        private async void btnOtkazi_Click(object sender, RoutedEventArgs e) {
            n.isUToku = false;
            n.isOtkazana = true;

            HttpResponseMessage response = serviceNarudzbe.PutResponse(n.Id, n);
            if (response.IsSuccessStatusCode) {
                Notifikacije not = new Notifikacije() { KorisnikId = n.KorisnikId, NarudzbaId = n.Id, VrstaNotifikacijeId = 3 };
                HttpResponseMessage responseNot = serviceNotifikacije.PostResponse(not);
                if (responseNot.IsSuccessStatusCode) {
                    MessageDialog msg = new MessageDialog("Uspješno ste otkazali narudžbu!", "Poruka");
                    await msg.ShowAsync();
                    Frame.Navigate(typeof(MojeNarudzbe), Global.logiraniKorisnik.Id);
                    return;
                }
                else {
                    MessageDialog msg = new MessageDialog("GREŠKA!", "Upozorenje");
                    await msg.ShowAsync();
                    Frame.Navigate(typeof(MojeNarudzbe), Global.logiraniKorisnik.Id);
                    return;
                }
            }
        }


        private void btnZakljuci_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(OstaviDojam), n);
        }
    }
}
