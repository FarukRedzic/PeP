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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using WinPhoneUI.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace WinPhoneUI.Pages {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProizvodDetalji : Page {

        WebAPIHelper serviceProizvodi = new WebAPIHelper("http://localhost:61718/", "api/Proizvod");
        WebAPIHelper serviceKomentari = new WebAPIHelper("http://localhost:61718/", "api/Komentar");
        WebAPIHelper serviceFavoriti = new WebAPIHelper("http://localhost:61718/", "api/Favoriti");
        WebAPIHelper serviceNarudzbe = new WebAPIHelper("http://localhost:61718/", "api/Narudzba");
        WebAPIHelper serviceNotifikacije = new WebAPIHelper("http://localhost:61718/", "api/Notifikacije");

        public ProizvodDetalji() {
            this.InitializeComponent();
        }
        int ProizvodId;
        Proizvod p;
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e) {
            this.ProizvodId = Convert.ToInt32(e.Parameter);

            HttpResponseMessage responsePreporuka = serviceProizvodi.GetResponseParams("GetPreporuceniProizvodi", new string[] { ProizvodId.ToString(), Global.logiraniKorisnik.Id.ToString() });
            if (responsePreporuka.IsSuccessStatusCode) 
                lvPreporuka.ItemsSource = responsePreporuka.Content.ReadAsAsync<List<Proizvod>>().Result;


            HttpResponseMessage responseProizvod = serviceProizvodi.GetResponseParams("GetProizvod", ProizvodId.ToString());
            if (responseProizvod.IsSuccessStatusCode) {
                 p = responseProizvod.Content.ReadAsAsync<Proizvod>().Result;
                if (Global.logiraniKorisnik.Id == p.KorisnikId) {
                    spDrugiProfil.Visibility = Visibility.Collapsed;
                }
                else {
                    spMojProfil.Visibility = Visibility.Collapsed;
                }
                tbNaziv.Text += p.Naziv.ToString();
                tbCijena.Text += p.Cijena.ToString();
                tbCijena.Text += " KM";
                tbOpstina.Text += p.Korisnik.Opstina.Naziv;
                tbTelefon.Text += p.Korisnik.Telefon;
                chkKoristeno.IsChecked = p.Koristen;
                tbAdresa.Text += p.Korisnik.Adresa;
                tbKategorija.Text += p.Kategorija.Naziv;
                if (p.Slika != null) { 
                    MemoryStream ms = new MemoryStream(p.Slika);
                    BitmapImage img = new BitmapImage();
                    await img.SetSourceAsync(ms.AsRandomAccessStream());
                pbProizvod.Source = img;
                }
                txtOpis.Text = p.Opis;

                HttpResponseMessage responseKomentari = serviceKomentari.GetResponseParams("GetKomentari", ProizvodId.ToString());
                if (responseKomentari.IsSuccessStatusCode) {
                    lvKomentari.ItemsSource = responseKomentari.Content.ReadAsAsync<List<KomentarVM>>().Result;
                }

            }
            HttpResponseMessage responseBrK = serviceKomentari.GetResponseParams("GetBrojKomentara", ProizvodId.ToString());
            if (responseBrK.IsSuccessStatusCode) {
                brKomentara.Text += responseBrK.Content.ReadAsAsync<int>().Result.ToString();
            }

            #region Sistem preporuke

            #endregion


        }

        private void lvKomentari_ItemClick(object sender, ItemClickEventArgs e) {
            Frame.Navigate(typeof(MojProfil), ((KomentarVM)e.ClickedItem).KorisnikId);
        }

        private void btnProfil1_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojProfil), p.KorisnikId);
        }

        private void btnProfil2_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojProfil), p.KorisnikId);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(ProizvodEdit), ProizvodId);
        }

        private void btnKomentarisi_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(NoviKomentar), ProizvodId);
        }

        private async void btnFavorit_Click(object sender, RoutedEventArgs e) {
            Favoriti f = new Favoriti() { KorisnikId = Global.logiraniKorisnik.Id, ProizvodId = ProizvodId };
            HttpResponseMessage response = serviceFavoriti.PostResponse(f);
            if (response.IsSuccessStatusCode) {
                MessageDialog msg = new MessageDialog("Uspješno ste spremili proizvod u favorite!", "Poruka");
                await msg.ShowAsync();
                return;
            }
            else {
                MessageDialog msg = new MessageDialog("Proizvod je već u vašim favoritima!", "Upozorenje");
                await msg.ShowAsync();
                return;
            }
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
        
        private async void btnKupi_Click(object sender, RoutedEventArgs e) {
            if ((bool)p.isAktivan && !p.isDeleted) {
                HttpResponseMessage countResponse = serviceNarudzbe.GetResponseParams("GetDozvola", Global.logiraniKorisnik.Id.ToString(), ProizvodId.ToString());
                if (countResponse.IsSuccessStatusCode) {
                    int count = countResponse.Content.ReadAsAsync<int>().Result;
                    if (count > 0) {
                        MessageDialog msg = new MessageDialog("Traženi artikal niste u mogućnosti naručiti više puta!", "Upozorenje");
                        await msg.ShowAsync();
                        return;
                    }
                }
                MessageDialog messageDialog = new MessageDialog("Opcija kupi artikal se koristi u slučaju ako ste stvarno zainteresovani za kupovinu određenog artikla. Molimo Vas da ovu opciju ne zloupotrebljavate jer se to automatski odražava na Vaš dojam koji Vam ostavljaju ostali korisnici i kupci.", "PAŽNJA!");
                messageDialog.Commands.Add(new UICommand("U redu"));
                messageDialog.Commands.Add(new UICommand("Odustani"));
                messageDialog.DefaultCommandIndex = 0;
                messageDialog.CancelCommandIndex = 1;
                var result = await messageDialog.ShowAsync();
                if (result.Label.Equals("U redu")) {
                    int Unique = 0;
                    HttpResponseMessage responseUnique = serviceNarudzbe.GetResponse("GetUnique");
                    if (responseUnique.IsSuccessStatusCode)
                        Unique = responseUnique.Content.ReadAsAsync<int>().Result;

                    NovaNarudzbaVM n = new NovaNarudzbaVM() { DatumVrijeme = DateTime.Now, PosiljaocId = Global.logiraniKorisnik.Id, ProizvodId = this.ProizvodId, BrojNarudzbe = Global.logiraniKorisnik.Id.ToString() + ProizvodId.ToString() + "/" + DateTime.Now.Year.ToString() + Unique.ToString(), Cijena = p.Cijena.ToString(), Proizvod = p.Naziv, Primaoc = p.Korisnik.KorisnickoIme};
                    Frame.Navigate(typeof(PregledNarudzba), n);
                }
                else return;


            }
            else {
                MessageDialog msg = new MessageDialog("Artikal nije aktivan!", "Upozorenje");
                await msg.ShowAsync();
                return;
            }
        }

        private void lvPreporuka_ItemClick(object sender, ItemClickEventArgs e) {
            Frame.Navigate(typeof(ProizvodDetalji), ((Proizvod)e.ClickedItem).Id);
        }
    }
}
