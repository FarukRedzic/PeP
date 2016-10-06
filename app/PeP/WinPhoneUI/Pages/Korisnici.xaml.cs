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
    public sealed partial class Korisnici : Page {
        public Korisnici() {
            this.InitializeComponent();
        }
        WebAPIHelper serviceKorisnici = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            cbxBind();
            string isTrgovina;
            if (cbxTrgovina.SelectedIndex == -1)
                isTrgovina = "null";
            else isTrgovina = ((cbxKorisniciVM)cbxTrgovina.SelectedValue).Id.ToString();

            string Naziv = "null";
            if (txtNaziv.Text != "")
                Naziv = txtNaziv.Text.Trim();

            HttpResponseMessage response = serviceKorisnici.GetResponseParams("GetKorisniciByParams", Naziv, isTrgovina, Global.logiraniKorisnik.Id.ToString() );
            if (response.IsSuccessStatusCode) {
                List<KorisnikVM> lista = response.Content.ReadAsAsync<List<KorisnikVM>>().Result;
                for (int i = 0; i < lista.Count; i++) {
                    if (lista[i].Popularnost == "")
                        lista[i].Popularnost = "-/10";
                    else lista[i].Popularnost += "/10";
                }
                lvKorisnici.ItemsSource = lista;
            }
        }

        private void cbxBind() {
            List<cbxKorisniciVM> lista = new List<cbxKorisniciVM>();
            cbxKorisniciVM cbx = new cbxKorisniciVM() { Id = null, Naziv = "Svi" };
            lista.Add(cbx);
            cbx = new cbxKorisniciVM() { Id = false, Naziv = "Obični korisnik" };
            lista.Add(cbx);
            cbx = new cbxKorisniciVM() { Id = true, Naziv = "Trgovina" };
            lista.Add(cbx);
            cbxTrgovina.ItemsSource = lista;
            cbxTrgovina.DisplayMemberPath = "Naziv";
        }

        private void lvKorisnici_ItemClick(object sender, ItemClickEventArgs e) {
            Frame.Navigate(typeof(MojProfil), ((KorisnikVM)e.ClickedItem).Id);
        }

        private void btnTrazi_Click(object sender, RoutedEventArgs e) {
            string isTrgovina;
            if (cbxTrgovina.SelectedIndex == -1 || cbxTrgovina.SelectedIndex == 0)
                isTrgovina = "null";
            else isTrgovina = ((cbxKorisniciVM)cbxTrgovina.SelectedValue).Id.ToString();

            string Naziv = "null";
            if (txtNaziv.Text != "")
                Naziv = txtNaziv.Text.Trim();

            HttpResponseMessage response = serviceKorisnici.GetResponseParams("GetKorisniciByParams", Naziv, isTrgovina, Global.logiraniKorisnik.Id.ToString());
            if (response.IsSuccessStatusCode) {
                List<KorisnikVM> lista = response.Content.ReadAsAsync<List<KorisnikVM>>().Result;
                for (int i = 0; i < lista.Count; i++) {
                    if (lista[i].Popularnost == "")
                        lista[i].Popularnost = "-/10";
                    else lista[i].Popularnost += "/10";
                }
                lvKorisnici.ItemsSource = lista;
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
    }
}
