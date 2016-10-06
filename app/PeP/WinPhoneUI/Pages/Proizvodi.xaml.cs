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
    public sealed partial class Proizvodi : Page {
        public Proizvodi() {
            this.InitializeComponent();
        }

        WebAPIHelper serviceProizvodi = new WebAPIHelper("http://localhost:61718/", "api/Proizvod");
        WebAPIHelper serviceKategorije = new WebAPIHelper("http://localhost:61718/", "api/Kategorija");

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            cbxBindKategorije();
            HttpResponseMessage response = serviceProizvodi.GetResponseParams("GetLast", new string[] { Global.logiraniKorisnik.Id.ToString() });
            if (response.IsSuccessStatusCode) {
                lvProizvodi.ItemsSource = response.Content.ReadAsAsync<List<ProizvodVM>>().Result;
            }
        }

        private void cbxBindKategorije() {
            HttpResponseMessage response = serviceKategorije.GetResponse("GetKategorijePhone");
            if (response.IsSuccessStatusCode) {
                cbxKategorije.ItemsSource = response.Content.ReadAsAsync<List<Kategorija>>().Result;
                cbxKategorije.DisplayMemberPath = "Naziv";
            }
        }

        private void lvProizvod_ItemClick(object sender, ItemClickEventArgs e) {
            Frame.Navigate(typeof(ProizvodDetalji), ((ProizvodVM)e.ClickedItem).Id);
        }

        private void btnTrazi_Click(object sender, RoutedEventArgs e) {
            int KategorijaId;
            if (cbxKategorije.SelectedIndex == -1 || cbxKategorije.SelectedIndex == 0)
                KategorijaId = 0;
            else KategorijaId = ((Kategorija)cbxKategorije.SelectedValue).Id;

            string Naziv = "null";
            if (txtNaziv.Text != "")
                Naziv = txtNaziv.Text.Trim();

            HttpResponseMessage response = serviceProizvodi.GetResponseParams("GetProizvodiByParams", new string[] { Naziv, KategorijaId.ToString(), Global.logiraniKorisnik.Id.ToString() });
            if (response.IsSuccessStatusCode) {
                lvProizvodi.ItemsSource = response.Content.ReadAsAsync<List<ProizvodVM>>().Result;
            }
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

        private void btnNarudzbe_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojeNarudzbe), Global.logiraniKorisnik.Id);
        }
    }
}
