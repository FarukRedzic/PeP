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
    public sealed partial class PregledPoruka : Page {
        public PregledPoruka() {
            this.InitializeComponent();
        }
        WebAPIHelper servicePoruke = new WebAPIHelper("http://localhost:61718/", "api/Poruka");

        int PorukaId;
        Poruka p;
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            this.PorukaId = Convert.ToInt32(e.Parameter);

            HttpResponseMessage response = servicePoruke.GetResponse(PorukaId.ToString());
            if (response.IsSuccessStatusCode) {
                p = response.Content.ReadAsAsync<Poruka>().Result;
                txtSadrzaj.Text = p.Sadrzaj;
                tbNaslov.Text += p.Naslov;

                if (p.PosiljaocId == Global.logiraniKorisnik.Id) {
                    btnOdgovori.Visibility = Visibility.Collapsed;
                    tbKorisnik.Text = "Primaoc: " + p.Primaoc.KorisnickoIme;
                    if (!p.Procitana)
                        txtProcitano.Visibility = Visibility.Collapsed;
                   
                }
                else {
                    p.Procitana = true;
                    HttpResponseMessage responsePut = servicePoruke.PutResponse(PorukaId, p);
                    txtProcitano.Visibility = Visibility.Collapsed;
                    tbKorisnik.Text = "Pošiljaoc: " + p.Posiljaoc.KorisnickoIme;
                }


            }

        }

        private void btnOdgovori_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(NovaPoruka), p.PosiljaocId);
        }

        private async void btnObrisi_Click(object sender, RoutedEventArgs e) {
            if (p.PosiljaocId == Global.logiraniKorisnik.Id) {
                p.isDeletedPoslana = true;
                HttpResponseMessage responsePut = servicePoruke.PutResponse(PorukaId, p);
                Frame.Navigate(typeof(Outbox), p.Posiljaoc.Id);
            }
            else {
                if (p.isDeletedPrimljena) {
                    HttpResponseMessage responseDelete = servicePoruke.PutResponse(PorukaId, p);
                    MessageDialog msgDelete = new MessageDialog("Poruka koju pokušavate obrisati je već obrisana!", "Upozorenje");
                    await msgDelete.ShowAsync();
                    Frame.Navigate(typeof(Inbox), p.Primaoc.Id);
                    return;
                }
                p.isDeletedPrimljena = true;
                HttpResponseMessage responsePut = servicePoruke.PutResponse(PorukaId, p);
                MessageDialog msg = new MessageDialog("Uspješno ste izbrisali poruku!", "Poruka");
                await msg.ShowAsync();
                Frame.Navigate(typeof(Inbox), p.Primaoc.Id);
            }
        }
    }
}
