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
    public sealed partial class OstaviDojam : Page {
        public OstaviDojam() {
            this.InitializeComponent();
        }
        WebAPIHelper serviceProizvodi = new WebAPIHelper("http://localhost:61718/", "api/Proizvod");
        WebAPIHelper serviceNarudzbe = new WebAPIHelper("http://localhost:61718/", "api/Narudzba");
        WebAPIHelper serviceNotifikacije = new WebAPIHelper("http://localhost:61718/", "api/Notifikacije");
        WebAPIHelper serviceDojmovi = new WebAPIHelper("http://localhost:61718/", "api/Dojam");
        Narudzba n;
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            this.n = (Narudzba)e.Parameter;
            cbxBindOcjene();
        }

        private void cbxBindOcjene() {
            List<OcjenaVM> ocjene = new List<OcjenaVM>();
            OcjenaVM ocjena;
            ocjena = new OcjenaVM() { Id = 1, Ocjena = "1" };
            ocjene.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 2, Ocjena = "2" };
            ocjene.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 3, Ocjena = "3" };
            ocjene.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 4, Ocjena = "4" };
            ocjene.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 5, Ocjena = "5" };
            ocjene.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 6, Ocjena = "6" };
            ocjene.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 7, Ocjena = "7" };
            ocjene.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 8, Ocjena = "8" };
            ocjene.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 9, Ocjena = "9" };
            ocjene.Add(ocjena);
            ocjena = new OcjenaVM() { Id = 10, Ocjena = "10" };
            ocjene.Add(ocjena);

            cbxOcjene.ItemsSource = ocjene;
            cbxOcjene.DisplayMemberPath = "Ocjena";
        }

        private async void btnPotvrdi_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(txtDojam.Text)) {
                MessageDialog msg = new MessageDialog("Dojam ne može biti prazan!", "Upozorenje");
                await msg.ShowAsync();
                return;
            }
            if (cbxOcjene.SelectedIndex == -1) {
                MessageDialog msg = new MessageDialog("Ocjena je obavezna!", "Upozorenje");
                await msg.ShowAsync();
                return;
            }
            Dojam dojam = new Dojam() { NarudzbaId = n.Id, Sadrzaj = txtDojam.Text, Ocjena = ((OcjenaVM)cbxOcjene.SelectedValue).Id, KorisnikId = n.Proizvod.KorisnikId  };
            HttpResponseMessage responseDojam = serviceDojmovi.PostResponse(dojam);
            if (!responseDojam.IsSuccessStatusCode) {
                MessageDialog msg = new MessageDialog("Nije moguće ostaviti više dojmova za jednu narudžbu!", "Upozorenje");
                await msg.ShowAsync();
                Frame.Navigate(typeof(MojeNarudzbe), Global.logiraniKorisnik.Id);
                return;
            }
            // Ostavio dojam, sada slijedi izmjena statusa narudzbe, postavljanje proizvoda na neaktivan(ako nije trgovina), te insert notifikacije
            n.isUToku = false;
            n.isZakljucena = true;
            HttpResponseMessage response = serviceNarudzbe.PutResponse(n.Id, n);
            if (response.IsSuccessStatusCode) {
                if (!n.Proizvod.Korisnik.IsTrgovina) {
                    HttpResponseMessage responseProizvod = serviceProizvodi.GetResponse(n.ProizvodId.ToString());
                    if (responseProizvod.IsSuccessStatusCode) {
                        Proizvod p = responseProizvod.Content.ReadAsAsync<Proizvod>().Result;
                        p.isAktivan = false;
                        HttpResponseMessage responseNeaktivan = serviceProizvodi.PutResponse(p.Id, p); // Proizvod je neaktivan(jer je prodan)
                    }
                }
                Notifikacije not = new Notifikacije() { KorisnikId = n.Proizvod.KorisnikId, NarudzbaId = n.Id, VrstaNotifikacijeId = 4, ProizvodId = n.ProizvodId };
                HttpResponseMessage responseNot = serviceNotifikacije.PostResponse(not);
                if (responseNot.IsSuccessStatusCode) {
                    MessageDialog msg = new MessageDialog("Uspješno ste zaključili narudžbu!", "Poruka");
                    await msg.ShowAsync();
                    Frame.Navigate(typeof(MojeNarudzbe), Global.logiraniKorisnik.Id);
                    return;
                }
            }
        }
    }
}
