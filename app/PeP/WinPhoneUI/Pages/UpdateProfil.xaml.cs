using PCL.Models;
using PCL.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace WinPhoneUI.Pages {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UpdateProfil : Page {

        WebAPIHelper serviceKorisnik = new WebAPIHelper("http://localhost:61718/", "api/Korisnik");

        Korisnik k;
        public CoreApplicationView view { get; set; }
        public Byte[] SlikaBytes;

        public UpdateProfil() {
            this.InitializeComponent();
            view = CoreApplication.GetCurrentView();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }


        protected override void OnNavigatedTo(NavigationEventArgs e) 
        {
            BindOpstine();
            this.k = e.Parameter as Korisnik;
            txtAdresa.Text = k.Adresa;
            txtEmail.Text = k.Email;
            txtIme.Text = k.Ime;
            txtPrezime.Text = k.Prezime;
            txtTelefon.Text = k.Telefon;

            chkSlika.IsChecked = true;
            cbxOpstina.SelectedIndex= k.OpstinaId - 1;

        }

        private void BindOpstine() 
        {
            HttpResponseMessage response = serviceKorisnik.GetResponse("GetOpstinePhone");
            if (response.IsSuccessStatusCode) {
                List<Opstina> opstine = response.Content.ReadAsAsync<List<Opstina>>().Result;
                cbxOpstina.ItemsSource = opstine;
                cbxOpstina.DisplayMemberPath = "Naziv";
            }
        }

        private void InputClear() 
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtEmail.Text = "";
            txtTelefon.Text = "";
            chkSlika.IsChecked = false;
            txtAdresa.Text = "";
        }

        private void btnPretraga_Click(object sender, RoutedEventArgs e) 
        {
            FileOpenPicker filePicker = new FileOpenPicker();
            filePicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            filePicker.ViewMode = PickerViewMode.Thumbnail;

            filePicker.FileTypeFilter.Clear();
            filePicker.FileTypeFilter.Add(".bmp");
            filePicker.FileTypeFilter.Add(".png");
            filePicker.FileTypeFilter.Add(".jpeg");
            filePicker.FileTypeFilter.Add(".jpg");

            filePicker.PickSingleFileAndContinue();
            view.Activated += viewActivated;
        }
        private async void viewActivated(CoreApplicationView sender, IActivatedEventArgs args1) {
            FileOpenPickerContinuationEventArgs args = args1 as FileOpenPickerContinuationEventArgs;

            if (args != null) {
                if (args.Files.Count == 0) return;
                view.Activated -= viewActivated;
                StorageFile storageFile = args.Files[0];

                var stream = await storageFile.OpenAsync(FileAccessMode.Read);
                var bitmapImage = new BitmapImage();
                await bitmapImage.SetSourceAsync(stream);

                if (bitmapImage.PixelHeight < 120 || bitmapImage.PixelWidth < 120) {
                    MessageDialog msg = new MessageDialog("Potrebno je da odaberete sliku većih dimenzija od 120x120!", "Upozorenje!");
                    await msg.ShowAsync();
                    return;
                }

                Byte[] bytes = new Byte[stream.Size];
                var decoder = await Windows.Graphics.Imaging.BitmapDecoder.CreateAsync(stream);

                var reader = new DataReader(stream.GetInputStreamAt(0));
                bytes = new byte[stream.Size];
                await reader.LoadAsync((uint)stream.Size);
                reader.ReadBytes(bytes);
                this.SlikaBytes = bytes;
                chkSlika.IsChecked = true;
            }
        }

        private async void btnPotvrdi_Click(object sender, RoutedEventArgs e) 
        {
            if (SlikaBytes != null)
                k.Slika = SlikaBytes;

            if (txtIme.Text.Trim() == "") {
                MessageDialog msg = new MessageDialog("-Ime je obavezno polje!", "Upozorenje!");
                await msg.ShowAsync();
                txtIme.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            else {
                k.Ime = txtIme.Text.Trim();
                txtIme.BorderBrush = null;
            }
            if (txtPrezime.Text == "") {
                MessageDialog msg = new MessageDialog("-Prezime je obavezno polje!", "Upozorenje!");
                await msg.ShowAsync();
                txtPrezime.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            else {
                k.Prezime = txtPrezime.Text.Trim();
                txtPrezime.BorderBrush = null;
            }
            if (string.IsNullOrEmpty(txtEmail.Text)) {
                MessageDialog msg = new MessageDialog("-Email je obavezno polje!", "Upozorenje!");
                await msg.ShowAsync();
                txtEmail.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            else if (!(txtEmail.Text.Contains(".")) || txtEmail.Text.Split('@').Length - 1 > 1) {
                MessageDialog msg = new MessageDialog("-Email nije u ispravnom formatu!", "Upozorenje!");
                await msg.ShowAsync();
                txtEmail.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            else {
                k.Email = txtEmail.Text.Trim();
                txtEmail.BorderBrush = null;
            }
            if (txtTelefon.Text == "") {
                MessageDialog msg = new MessageDialog("-Telefon je obavezno polje!", "Upozorenje!");
                await msg.ShowAsync();
                txtTelefon.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            else if (txtTelefon.Text.Length != 14 || txtTelefon.Text[3] != ' ' || txtTelefon.Text[6] != '-' || txtTelefon.Text[10] != '-') {
                MessageDialog msg = new MessageDialog("-Telefon nije u ispravnom formatu!", "Upozorenje!");
                await msg.ShowAsync();
                txtTelefon.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            else {
                k.Telefon = txtTelefon.Text.Trim();
                txtTelefon.BorderBrush = null;
            }

            if (cbxOpstina.SelectedValue == null) {
                MessageDialog msg = new MessageDialog("-Opština je obavezno polje!", "Upozorenje!");
                await msg.ShowAsync();
                cbxOpstina.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            else {
                k.OpstinaId = ((Opstina)cbxOpstina.SelectedValue).Id;
                cbxOpstina.BorderBrush = null;
            }

            if (string.IsNullOrEmpty(txtAdresa.Text)) {
                MessageDialog msg = new MessageDialog("-Adresa je obavezno polje!", "Upozorenje!");
                await msg.ShowAsync();
                txtAdresa.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            else {
                k.Adresa = txtAdresa.Text.Trim();
                txtAdresa.BorderBrush = null;
            }
            

            HttpResponseMessage response = serviceKorisnik.PutResponse(k.Id,  k);
            if (response.IsSuccessStatusCode) {
                MessageDialog msg = new MessageDialog("-Uspješno ste izmijenili vaše podatke!", "Poruka");
                await msg.ShowAsync();
                InputClear();
                Frame.Navigate(typeof(MojProfil), Global.logiraniKorisnik.Id);
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
