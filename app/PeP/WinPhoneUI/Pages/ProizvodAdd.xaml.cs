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
    public sealed partial class ProizvodAdd : Page {
        public ProizvodAdd() {
            this.InitializeComponent();
            view = CoreApplication.GetCurrentView();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        WebAPIHelper serviceKategorije = new WebAPIHelper("http://localhost:61718/", "api/Kategorija");
        WebAPIHelper serviceProizvod = new WebAPIHelper("http://localhost:61718/", "api/Proizvod");


        public CoreApplicationView view { get; set; }
        public Byte[] SlikaBytes;


        protected override void OnNavigatedTo(NavigationEventArgs e) {
            BindKategorije();
            BorderClear();
            InputClear(); //
        }

        private void BindKategorije() {
            HttpResponseMessage response = serviceKategorije.GetResponse("GetKategorijePhoneAdd");
            if (response.IsSuccessStatusCode) {
                List<Kategorija> opstine = response.Content.ReadAsAsync<List<Kategorija>>().Result;
                cbxKategorija.ItemsSource = opstine;
                cbxKategorija.DisplayMemberPath = "Naziv";
            }
        }

        private async void btnPotvrdi_Click(object sender, RoutedEventArgs e) {
            Proizvod p = new Proizvod();



            if (txtNaziv.Text.Trim() == "") {
                MessageDialog msg = new MessageDialog("-Naziv je obavezno polje!", "Upozorenje!");
                await msg.ShowAsync();
                txtNaziv.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            else {
                p.Naziv = txtNaziv.Text.Trim();
                txtNaziv.BorderBrush = null;
            }

            try {
                p.Cijena = Convert.ToDouble(txtCijena.Text);
                txtCijena.BorderBrush = null;
            }
            catch (Exception) {
                MessageDialog msg = new MessageDialog("-Cijena nije u ispravnom formatu!", "Upozorenje!");
                await msg.ShowAsync();
                txtCijena.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }

            if (chkSlika.IsChecked == true) {
                p.Slika = SlikaBytes;
                chkSlika.BorderBrush = null;
            }
            else {
                MessageDialog msg = new MessageDialog("-Slika je obavezno polje!", "Upozorenje!");
                await msg.ShowAsync();
                chkSlika.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }

            if (cbxKategorija.SelectedValue == null) {
                MessageDialog msg = new MessageDialog("-Kategorija je obavezno polje!", "Upozorenje!");
                await msg.ShowAsync();
                cbxKategorija.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            else {
                p.KategorijaId = ((Kategorija)cbxKategorija.SelectedValue).Id;
                cbxKategorija.BorderBrush = null;
            }

            if (txtOpis.Text.Trim() == "") {
                MessageDialog msg = new MessageDialog("-Opis je obavezno polje!", "Upozorenje!");
                await msg.ShowAsync();
                txtOpis.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                return;
            }
            else {
                p.Opis = txtOpis.Text.Trim();
                txtOpis.BorderBrush = null;
            }

            p.Koristen = chkKoristen.IsChecked;
            p.KorisnikId = Global.logiraniKorisnik.Id;
            p.Postavio = DateTime.Now;
            p.isAktivan = true;
            HttpResponseMessage response = serviceProizvod.PostResponse(p);
            if (response.IsSuccessStatusCode) {
                MessageDialog msg = new MessageDialog("-Uspješno ste dodali proizvod!", "Poruka");
                InputClear();
                Frame.Navigate(typeof(MojProfil), p.KorisnikId);
                await msg.ShowAsync();
            }
        }

        private void InputClear() {
            txtNaziv.Text = "";
            txtCijena.Text = "";
            txtOpis.Text = "";
            chkKoristen.IsChecked = false;
            chkSlika.IsChecked = false;
        }

        private void BorderClear() {
            txtNaziv.BorderBrush = null;
            txtCijena.BorderBrush = null;
            txtOpis.BorderBrush = null;
            chkSlika.BorderBrush = null;
            cbxKategorija.BorderBrush = null;
        }

        private void btnPretraga_Click(object sender, RoutedEventArgs e) {
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
                    MessageDialog msg = new MessageDialog("Potrebno je da odaberete sliku dimenzija većih od 120x120!", "Upozorenje!");
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

        private void btnHome_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojProfil), Global.logiraniKorisnik.Id);
            BorderClear();
        }

        private void btnPoruke_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(Poruke), Global.logiraniKorisnik.Id);
            BorderClear();
        }

        private void btnNarudzbe_Click(object sender, RoutedEventArgs e) {
            Frame.Navigate(typeof(MojeNarudzbe), Global.logiraniKorisnik.Id);
            BorderClear();
        }
    }
}
