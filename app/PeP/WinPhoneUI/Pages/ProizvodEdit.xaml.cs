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
    public sealed partial class ProizvodEdit : Page {

        WebAPIHelper serviceProizvodi = new WebAPIHelper("http://localhost:61718/", "api/Proizvod");
        WebAPIHelper serviceKategorije = new WebAPIHelper("http://localhost:61718/", "api/Kategorija");

        public CoreApplicationView view { get; set; }
        public Byte[] SlikaBytes;

        public ProizvodEdit() {
            this.InitializeComponent();
            view = CoreApplication.GetCurrentView();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        int ProizvodId;
        Proizvod p;

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            cbxKategorijeBind();
            ProizvodId = Convert.ToInt32(e.Parameter);

            HttpResponseMessage response = serviceProizvodi.GetResponseParams("GetProizvod", ProizvodId.ToString());
            if (response.IsSuccessStatusCode) {
                p = response.Content.ReadAsAsync<Proizvod>().Result;
                txtNaziv.Text = p.Naziv;
                txtCijena.Text = p.Cijena.ToString();
                if (p.Slika != null) {
                    chkSlika.IsChecked = true;
                    SlikaBytes = p.Slika;
                }
                else chkSlika.IsChecked = false;
                chkSlika.IsEnabled = false;
                txtOpis.Text = p.Opis;
                cbxKategorija.SelectedIndex = p.KategorijaId;
            }
        }

        private void cbxKategorijeBind() {
            HttpResponseMessage response = serviceKategorije.GetResponse("GetKategorijePhone");
            if (response.IsSuccessStatusCode) {
                List<Kategorija> opstine = response.Content.ReadAsAsync<List<Kategorija>>().Result;
                cbxKategorija.ItemsSource = opstine;
                cbxKategorija.DisplayMemberPath = "Naziv";
            }
        }

        private async void btnPotvrdi_Click(object sender, RoutedEventArgs e) {

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


            HttpResponseMessage response = serviceProizvodi.PutResponse(p.Id, p);
            if (response.IsSuccessStatusCode) {
                MessageDialog msg = new MessageDialog("-Uspješno ste izmijenili podatke o proizvodu!", "Poruka");
                InputClear();
                Frame.Navigate(typeof(MojProfil), p.KorisnikId);
                await msg.ShowAsync();
            }
        }

        private void InputClear() {
            txtNaziv.Text = "";
            txtCijena.Text = "";
            txtOpis.Text = "";
            chkSlika.IsChecked = false;
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

        private async void btnDeaktiviraj_Click(object sender, RoutedEventArgs e) {
            if ((bool)!p.isAktivan) {
                MessageDialog msg = new MessageDialog("-Proizvod je prethodno već deaktiviran!", "Upozorenje");
                await msg.ShowAsync();
                InputClear();
                Frame.Navigate(typeof(MojProfil), p.KorisnikId);
                return;
            }
            p.isAktivan = false;
            HttpResponseMessage response = serviceProizvodi.PutResponse(p.Id, p);
            if (response.IsSuccessStatusCode) {
                MessageDialog msg = new MessageDialog("-Uspješno ste deaktivirali proizvod!", "Poruka");
                InputClear();
                Frame.Navigate(typeof(MojProfil), p.KorisnikId);
                await msg.ShowAsync();
            }
        }
    }
}
