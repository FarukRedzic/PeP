using PCL.Models;
using PCL.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WinPhoneUI.ExtensionKlase;
using WinPhoneUI.NotifikacijePhone;
using WinPhoneUI.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace WinPhoneUI.Pages {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MojProfil : Page {


        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");
        WebAPIHelper serviceNarudzbe = new WebAPIHelper("http://localhost:61718/", "api/Narudzba");
        WebAPIHelper serviceKategorije = new WebAPIHelper("http://localhost:61718/", "api/Kategorija");
        WebAPIHelper serviceProizvodi = new WebAPIHelper("http://localhost:61718/", "api/Proizvod");
        WebAPIHelper serviceFavoriti = new WebAPIHelper("http://localhost:61718/", "api/Favoriti");
        WebAPIHelper serviceDojmovi = new WebAPIHelper("http://localhost:61718/", "api/Dojam");

        private bool HoldEvent = true;
        int KorisnikId;
        Korisnik k;
        public MojProfil() {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e) {


            cbxBindProdani();
            cbxBindAktivni();
            cbxBindKupljeni();
            cbxBindFavoriti();
            cbxBindDojmovi();
            cbxBindVrstaNeaktivni();

            this.KorisnikId = Convert.ToInt32(e.Parameter);
            if (Global.logiraniKorisnik.Id != KorisnikId) {
                btnIzmjenaLozinke.Visibility = Visibility.Collapsed;
                btnIzmjenaProfila.Visibility = Visibility.Collapsed;
            }
            else {
                btnPosaljiPoruku.Visibility = Visibility.Collapsed;
            }
            HttpResponseMessage response = serviceKorisnik.GetResponse(KorisnikId.ToString());
            if (response.IsSuccessStatusCode) {
                k = response.Content.ReadAsAsync<Korisnik>().Result;
                tbIme.Text += k.Ime;
                tbPrezime.Text += k.Prezime;
                tbEmail.Text += k.Email;
                tbTelefon.Text += k.Telefon;
                tbOpstina.Text += k.Opstina.Naziv;
                tbAdresa.Text += k.Adresa;
                Username.Text += k.KorisnickoIme;
                Mail.Text = k.Email;
                chkTrgovina.IsChecked = k.IsTrgovina;

                MemoryStream ms = new MemoryStream(k.Slika);
                var Image = new BitmapImage();
                await Image.SetSourceAsync(ms.AsRandomAccessStream());
                pbSlika.Source = Image;

                //Prosjecna ocjena
                HttpResponseMessage pouzdanostResponse = serviceDojmovi.GetResponseParams("GetPouzdanost", new string[] { KorisnikId.ToString() });
                if (pouzdanostResponse.IsSuccessStatusCode) {
                    tbPouzdanost.Text = pouzdanostResponse.Content.ReadAsAsync<string>().Result;
                    tbPouzdanost.Text += "/10";
                }


                //Prodani
                string OD = DateTime.MinValue.ToApiDateTime();
                string DO = DateTime.MaxValue.ToApiDateTime();
                HttpResponseMessage responseProdani = serviceNarudzbe.GetResponseParams("GetProdaneByParams", new string[] { KorisnikId.ToString(),
                "null", // Broj narudzbe
                "-1", // Kategorija (-1 sve)
                OD,DO });
                if (responseProdani.IsSuccessStatusCode) {
                    lvProdani.ItemsSource = responseProdani.Content.ReadAsAsync<List<NarudzbaVM>>().Result;
                }

                //Aktivni
                HttpResponseMessage responseAktivni = serviceProizvodi.GetResponseParams("GetAktivneByParams", new string[] { KorisnikId.ToString(), "-1", }); // Kategorija (-1 sve)
                if (responseAktivni.IsSuccessStatusCode) {
                    lvAktivni.ItemsSource = responseAktivni.Content.ReadAsAsync<List<ProizvodVM>>().Result;
                }

                //Neaktivni
                if (k.IsTrgovina) {
                    HttpResponseMessage responseNeaktivni = serviceProizvodi.GetResponseParams("GetNeaktivneByParamsTrgovina", new string[] { KorisnikId.ToString(), "-1", }); // Kategorija (-1 sve)
                    if (responseAktivni.IsSuccessStatusCode) {
                        lvNeaktivni.ItemsSource = responseNeaktivni.Content.ReadAsAsync<List<ProizvodVM>>().Result;
                    }
                }
                else {
                    HttpResponseMessage responseNeaktivni = serviceProizvodi.GetResponseParams("GetNeaktivneByParams", new string[] { KorisnikId.ToString(), "-1", }); // Kategorija (-1 sve)
                    if (responseAktivni.IsSuccessStatusCode) {
                        lvNeaktivni.ItemsSource = responseNeaktivni.Content.ReadAsAsync<List<ProizvodVM>>().Result;
                    }
                }

                //Kupljeni
                HttpResponseMessage responseKupljeni = serviceNarudzbe.GetResponseParams("GetKupljeneByParams", new string[] { KorisnikId.ToString(), "-1" }); // Kategorija (-1 sve)
                if (responseKupljeni.IsSuccessStatusCode) {
                    lvKupljeni.ItemsSource = responseKupljeni.Content.ReadAsAsync<List<NarudzbaVM>>().Result;
                }

                //Favoriti
                HttpResponseMessage responseFavoriti = serviceFavoriti.GetResponseParams("GetFavoritiByParams", new string[] { KorisnikId.ToString(), "-1" });
                if (responseFavoriti.IsSuccessStatusCode) {
                    lvFavoriti.ItemsSource = responseFavoriti.Content.ReadAsAsync<List<FavoritiVM>>().Result;
                }
                //Dojmovi
                HttpResponseMessage responseDojam = serviceDojmovi.GetResponseParams("GetDojmoviByParams", new string[] { KorisnikId.ToString(), "-1" });
                if (responseDojam.IsSuccessStatusCode) {
                    lvDojmovi.ItemsSource = responseDojam.Content.ReadAsAsync<List<DojamVM>>().Result;
                }
            }
        }

        private void cbxBindVrstaNeaktivni() {
            HttpResponseMessage response = serviceKategorije.GetResponse("GetKategorijePhone");
            if (response.IsSuccessStatusCode) {
                cbxVrstaNeaktivni.ItemsSource = response.Content.ReadAsAsync<List<Kategorija>>().Result;
                cbxVrstaNeaktivni.DisplayMemberPath = "Naziv";
            }
        }

        private void cbxBindDojmovi() {
            List<OcjenaVM> ocjene = new List<OcjenaVM>();
            OcjenaVM ocjena;
            ocjena = new OcjenaVM() { Id = 0, Ocjena = "Sve ocjene" };
            ocjene.Add(ocjena);
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

            cbxVrstaDojmovi.ItemsSource = ocjene;
            cbxVrstaDojmovi.DisplayMemberPath = "Ocjena";
        }

        private void cbxBindFavoriti() {
            HttpResponseMessage response = serviceKategorije.GetResponse("GetKategorijePhone");
            if (response.IsSuccessStatusCode) {
                cbxVrstaFavoriti.ItemsSource = response.Content.ReadAsAsync<List<Kategorija>>().Result;
                cbxVrstaFavoriti.DisplayMemberPath = "Naziv";
            }
        }

        private void cbxBindKupljeni() {
            HttpResponseMessage response = serviceKategorije.GetResponse("GetKategorijePhone");
            if (response.IsSuccessStatusCode) {
                cbxVrstaKupljeni.ItemsSource = response.Content.ReadAsAsync<List<Kategorija>>().Result;
                cbxVrstaKupljeni.DisplayMemberPath = "Naziv";
            }
        }

        private void cbxBindAktivni() {
            HttpResponseMessage response = serviceKategorije.GetResponse("GetKategorijePhone");
            if (response.IsSuccessStatusCode) {
                cbxVrstaAktivni.ItemsSource = response.Content.ReadAsAsync<List<Kategorija>>().Result;
                cbxVrstaAktivni.DisplayMemberPath = "Naziv";
            }
        }

        private void cbxBindProdani() {
            HttpResponseMessage response = serviceKategorije.GetResponse("GetKategorijePhone");
            if (response.IsSuccessStatusCode) {
                cbxVrstaProdani.ItemsSource = response.Content.ReadAsAsync<List<Kategorija>>().Result;
                cbxVrstaProdani.DisplayMemberPath = "Naziv";
            }
        }

        private void btnIzmjenaProfila_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(UpdateProfil), k);
        }

        private void btnIzmjenaLozinke_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(IzmjenaLozinke));
        }

        private void cbxVrstaProdani_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            string OD = DateTime.MinValue.ToApiDateTime();
            string DO = DateTime.MaxValue.ToApiDateTime();
            int KategorijaId;
            if (cbxVrstaProdani.SelectedIndex == -1)
                KategorijaId = -1;
            else KategorijaId = ((Kategorija)cbxVrstaProdani.SelectedValue).Id;

            HttpResponseMessage responseNarudzba = serviceNarudzbe.GetResponseParams("GetProdaneByParams", new string[] { KorisnikId.ToString(),
                "null", // Broj narudzbe
                KategorijaId.ToString(), // Kategorija (-1 sve)
                OD,DO });
            if (responseNarudzba.IsSuccessStatusCode) {
                lvProdani.ItemsSource = responseNarudzba.Content.ReadAsAsync<List<NarudzbaVM>>().Result;
            }
        }

        private void cbxVrstaAktivni_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            int KategorijaId;
            if (cbxVrstaAktivni.SelectedIndex == -1)
                KategorijaId = -1;
            else KategorijaId = ((Kategorija)cbxVrstaAktivni.SelectedValue).Id;

            HttpResponseMessage responseAktivni = serviceProizvodi.GetResponseParams("GetAktivneByParams", new string[] { KorisnikId.ToString(),
                KategorijaId.ToString(), }); // Kategorija (-1 sve)
            if (responseAktivni.IsSuccessStatusCode) {
                lvAktivni.ItemsSource = responseAktivni.Content.ReadAsAsync<List<ProizvodVM>>().Result;
            }
        }

        private void cbxVrstaKupljeni_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            int KategorijaId;
            if (cbxVrstaKupljeni.SelectedIndex == -1)
                KategorijaId = -1;
            else KategorijaId = ((Kategorija)cbxVrstaKupljeni.SelectedValue).Id;

            HttpResponseMessage responseKupljeni = serviceNarudzbe.GetResponseParams("GetKupljeneByParams", new string[] { KorisnikId.ToString(), KategorijaId.ToString()}); // Kategorija (-1 sve)
            if (responseKupljeni.IsSuccessStatusCode) {
                lvKupljeni.ItemsSource = responseKupljeni.Content.ReadAsAsync<List<NarudzbaVM>>().Result;
            }
        }

        private void cbxVrstaFavoriti_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            int KategorijaId;
            if (cbxVrstaFavoriti.SelectedIndex == -1)
                KategorijaId = -1;
            else KategorijaId = ((Kategorija)cbxVrstaFavoriti.SelectedValue).Id;


            HttpResponseMessage responseFavoriti = serviceFavoriti.GetResponseParams("GetFavoritiByParams", new string[] { KorisnikId.ToString(), KategorijaId.ToString() });
            if (responseFavoriti.IsSuccessStatusCode) {
                lvFavoriti.ItemsSource = responseFavoriti.Content.ReadAsAsync<List<FavoritiVM>>().Result;
            }
        }

        private void cbxVrstaDojmovi_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            int OcjenaId;
            if (cbxVrstaDojmovi.SelectedIndex == -1)
                OcjenaId = -1;
            else OcjenaId = ((OcjenaVM)cbxVrstaDojmovi.SelectedValue).Id;

            HttpResponseMessage responseDojam = serviceDojmovi.GetResponseParams("GetDojmoviByParams", new string[] { KorisnikId.ToString(), OcjenaId.ToString() });
            if (responseDojam.IsSuccessStatusCode) {
                lvDojmovi.ItemsSource = responseDojam.Content.ReadAsAsync<List<DojamVM>>().Result;
            }
        }

        private void lvDojmovi_ItemClick(object sender, ItemClickEventArgs e) {
            Frame.Navigate(typeof(MojProfil), ((DojamVM)e.ClickedItem).KorisnikId);
        }

        private void lvAktivni_ItemClick(object sender, ItemClickEventArgs e) {
            Frame.Navigate(typeof(ProizvodDetalji), ((ProizvodVM)e.ClickedItem).Id);
        }

        private void lvProdani_ItemClick(object sender, ItemClickEventArgs e) {
            Frame.Navigate(typeof(ProizvodDetalji), ((NarudzbaVM)e.ClickedItem).ProizvodId);
        }

        private void lvKupljeni_ItemClick(object sender, ItemClickEventArgs e) {
            Frame.Navigate(typeof(ProizvodDetalji), ((NarudzbaVM)e.ClickedItem).ProizvodId);
        }

        private void lvFavoriti_ItemClick(object sender, ItemClickEventArgs e) {
            Frame.Navigate(typeof(ProizvodDetalji), ((FavoritiVM)e.ClickedItem).ProizvodId);
        }



        private async void lvFavoriti_Holding(object sender, HoldingRoutedEventArgs e) {
            if (Global.logiraniKorisnik.Id == KorisnikId) {
                FrameworkElement element = (FrameworkElement)e.OriginalSource;
                if (element.DataContext != null && element.DataContext is FavoritiVM) {
                    int FavoritId = ((FavoritiVM)element.DataContext).FavoritId;
                    HttpResponseMessage response = serviceFavoriti.DeleteResponse(FavoritId);
                    if (response.IsSuccessStatusCode) {
                        MessageDialog msg = new MessageDialog("Uspješno ste uklonili proizvod iz favorita!", "Poruka");
                        await msg.ShowAsync();
                        Frame.Navigate(typeof(MojProfil), KorisnikId);
                    }
                }
            }
        }


        private void btnPosaljiPoruku_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(NovaPoruka), KorisnikId);
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

        private void btnOdjava_Click(object sender, RoutedEventArgs e) {
            NotificationPhone.StopNotificationTimer();
            Global.logiraniKorisnik = null;
            Frame.Navigate(typeof(Login));
        }

        private void btnProizvodi_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(Proizvodi));
        }

        private void btnKorisnici_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(Korisnici));
        }

        private async void lvNeaktivni_ItemClick(object sender, ItemClickEventArgs e) {
            int PId = ((ProizvodVM)e.ClickedItem).Id;
            HttpResponseMessage response = serviceProizvodi.GetResponse(PId.ToString());

            Proizvod p = response.Content.ReadAsAsync<Proizvod>().Result;
            if (Global.logiraniKorisnik.Id != p.KorisnikId)
                return;


            MessageDialog messageDialog = new MessageDialog("Da li ste sigurni da želite aktivirati odabrani proizvod ?", "Upozorenje");
            messageDialog.Commands.Add(new UICommand("da"));
            messageDialog.Commands.Add(new UICommand("ne"));
            var result = await messageDialog.ShowAsync();

            if (result.Label.Equals("da")) {
                    p.isAktivan = true;
                    HttpResponseMessage r = serviceProizvodi.PutResponse(PId, p);
                    if (r.IsSuccessStatusCode) {
                        MessageDialog msg = new MessageDialog("Uspješno ste aktivirali proizvod!", "Poruka");
                        await msg.ShowAsync();
                        Frame.Navigate(typeof(MojProfil), Global.logiraniKorisnik.Id);
                    }
            }
            else return;
        }

        private async void lvNeaktivni_Holding(object sender, HoldingRoutedEventArgs e) {
            FrameworkElement element = (FrameworkElement)e.OriginalSource;
            if (element.DataContext != null && element.DataContext is ProizvodVM) {
                int id = ((ProizvodVM)element.DataContext).Id;
                HttpResponseMessage response = serviceProizvodi.GetResponse(id.ToString());

                Proizvod p = response.Content.ReadAsAsync<Proizvod>().Result;
                if (Global.logiraniKorisnik.Id != p.KorisnikId)
                    return;

                MessageDialog messageDialog = new MessageDialog("Da li ste sigurni da želite obrisati odabrani proizvod ?", "Upozorenje");
            messageDialog.Commands.Add(new UICommand("da"));
            messageDialog.Commands.Add(new UICommand("ne"));
            IUICommand result = null;
            if (HoldEvent) {
                HoldEvent = false;
                result = await messageDialog.ShowAsync();
                if (result.Label.Equals("da")) {
                    if (element.DataContext != null && element.DataContext is ProizvodVM) {
                            p.isDeleted = true;
                            HttpResponseMessage r = serviceProizvodi.PutResponse(id, p);
                            if (r.IsSuccessStatusCode) {
                                MessageDialog msg = new MessageDialog("Uspješno ste obrisali proizvod!", "Poruka");
                                HoldEvent = true;
                                Frame.Navigate(typeof(MojProfil), Global.logiraniKorisnik.Id);
                            }
                        }
                    }
                }
                else {
                    HoldEvent = true;
                    return;
                }
            }

        }
        private void cbxVrstaNeaktivni_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            int KategorijaId;
            if (cbxVrstaNeaktivni.SelectedIndex == -1)
                KategorijaId = -1;
            else KategorijaId = ((Kategorija)cbxVrstaNeaktivni.SelectedValue).Id;

            HttpResponseMessage responseNeaktivni = serviceProizvodi.GetResponseParams("GetNeaktivneByParams", new string[] { KorisnikId.ToString(),
                KategorijaId.ToString(), }); // Kategorija (-1 sve)
            if (responseNeaktivni.IsSuccessStatusCode) {
                lvNeaktivni.ItemsSource = responseNeaktivni.Content.ReadAsAsync<List<ProizvodVM>>().Result;
            }
        }


    }
}
