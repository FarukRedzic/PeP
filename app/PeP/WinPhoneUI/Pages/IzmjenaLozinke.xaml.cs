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
    public sealed partial class IzmjenaLozinke : Page {
        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");

        public IzmjenaLozinke() {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
        }

        private void ClearInput() {
            txtNovaLozinka.Password = "";
            txtPotvrda.Password = "";
            txtStaraLozinka.Password = "";
        }

        private async void btnPotvrda_Click(object sender, RoutedEventArgs e) {
            Korisnik k = Global.logiraniKorisnik;
            if (UIHelper.GenerateHash(txtStaraLozinka.Password, k.LozinkaSalt) != k.LozinkaHash) {
                MessageDialog msg = new MessageDialog("Stara lozinka nije ispravna!", "Upozorenje!");
                await msg.ShowAsync();
                txtStaraLozinka.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            else if (txtNovaLozinka.Password.Length < 5) {
                MessageDialog msg = new MessageDialog("Nova lozinka nije ispravna! (min. 5 karaktera)", "Upozorenje!");
                await msg.ShowAsync();
                txtNovaLozinka.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                txtStaraLozinka.BorderBrush = null;
                txtNovaLozinka.BorderBrush = null;
                return;
            }
            else if (txtPotvrda.Password.Trim() != txtNovaLozinka.Password.Trim()) {
                MessageDialog msg = new MessageDialog("Potvrda lozinke se ne podudara sa novom lozinkom!", "Upozorenje!");
                await msg.ShowAsync();
                txtStaraLozinka.BorderBrush = null;
                txtNovaLozinka.BorderBrush = null;
                txtPotvrda.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            else if (txtStaraLozinka.Password == txtNovaLozinka.Password) 
            {
                MessageDialog msg = new MessageDialog("Nova lozinka ne može biti jednaka staroj lozinki!", "Upozorenje!");
                await msg.ShowAsync();
                txtStaraLozinka.BorderBrush = null;
                txtNovaLozinka.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                txtPotvrda.BorderBrush = null;
                return;
            }
            else if (UIHelper.GenerateHash(txtStaraLozinka.Password, k.LozinkaSalt) == k.LozinkaHash && txtPotvrda.Password.Trim() == txtNovaLozinka.Password.Trim()) {
                k.LozinkaSalt = PCL.Util.UIHelper.GenerateSalt();
                k.LozinkaHash = PCL.Util.UIHelper.GenerateHash(txtNovaLozinka.Password.Trim(), k.LozinkaSalt);
                HttpResponseMessage responsePut = serviceKorisnik.PutResponse(k.Id, k);
                MessageDialog msg = new MessageDialog("Uspješno ste promijenili lozinku!", "Poruka");
                await msg.ShowAsync();
                txtStaraLozinka.BorderBrush = null;
                txtNovaLozinka.BorderBrush = null;
                txtPotvrda.BorderBrush = null;
                ClearInput();
            }

        }

        private void btnHome_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojProfil), Global.logiraniKorisnik.Id);
        }

        private void btnNoviProizvod_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(ProizvodAdd));
        }

        private void btnNarudzbe_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojeNarudzbe), Global.logiraniKorisnik.Id);
        }

        private void btnPoruke_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(Poruke), Global.logiraniKorisnik.Id);
        }
    }
}
