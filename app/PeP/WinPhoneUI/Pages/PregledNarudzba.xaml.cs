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
    public sealed partial class PregledNarudzba : Page {
        public PregledNarudzba() {
            this.InitializeComponent();
        }
        WebAPIHelper serviceNarudzbe = new WebAPIHelper("http://localhost:61718/", "api/Narudzba");
        WebAPIHelper serviceNotifikacije = new WebAPIHelper("http://localhost:61718/", "api/Notifikacije");
        NovaNarudzbaVM nn;
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            nn = (NovaNarudzbaVM)e.Parameter;
            tbPrimaoc.Text += nn.Primaoc;
            tbKreirao.Text += Global.logiraniKorisnik.KorisnickoIme;
            tbProizvod.Text += nn.Proizvod + ", " + nn.Cijena + " KM";
        }

        private async void btnPotvrdi_Click(object sender, RoutedEventArgs e) {
            HttpResponseMessage countResponse = serviceNarudzbe.GetResponseParams("GetDozvola", Global.logiraniKorisnik.Id.ToString(), nn.ProizvodId.ToString());

            if (countResponse.IsSuccessStatusCode) {
                int count = countResponse.Content.ReadAsAsync<int>().Result;
                if (count > 0) {
                    MessageDialog msg = new MessageDialog("Traženi artikal niste u mogućnosti naručiti više puta!", "Upozorenje");
                    await msg.ShowAsync();
                    Frame.Navigate(typeof(MojProfil), Global.logiraniKorisnik.Id);
                    return;
                }

                Narudzba n = new Narudzba() { BrojNarudzbe = nn.BrojNarudzbe, DatumVrijeme = nn.DatumVrijeme, KorisnikId = Global.logiraniKorisnik.Id, ProizvodId = nn.ProizvodId, NapomenaPosiljaoc = txtNapomena.Text };
                HttpResponseMessage response = serviceNarudzbe.PostResponse(n);
                if (response.IsSuccessStatusCode) {
                    n = response.Content.ReadAsAsync<Narudzba>().Result;
                    HttpResponseMessage responseGet = serviceNarudzbe.GetResponse(n.Id.ToString());
                    if (responseGet.IsSuccessStatusCode) {
                        n = responseGet.Content.ReadAsAsync<Narudzba>().Result;
                        Notifikacije notifikacija = new Notifikacije() { NarudzbaId = n.Id, VrstaNotifikacijeId = 1, KorisnikId = n.Proizvod.KorisnikId };
                        HttpResponseMessage responseN = serviceNotifikacije.PostResponse(notifikacija);
                        if (responseN.IsSuccessStatusCode) {
                            MessageDialog msgNarudzba = new MessageDialog("Uspješno ste kreirali zahtjev za narudžbu!\nNakon što korisnik pregleda Vašu narudžbu dobit ćete odgovor.", "Poruka");
                            await msgNarudzba.ShowAsync();
                            Frame.Navigate(typeof(ProizvodDetalji), nn.ProizvodId);
                            return;
                        }
                    }
                }
            }
        }
    }
}
