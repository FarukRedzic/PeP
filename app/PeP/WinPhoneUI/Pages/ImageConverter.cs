using PCL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;
using WinPhoneUI.ViewModels;

namespace WinPhoneUI.Pages {
    public class ImageConverter : IValueConverter
    {
        public object Convert(System.Object value, Type targetType, System.Object parameter, System.String language)
        {
            MemoryStream ms = new MemoryStream();
            try {
                if (((KorisnikVM)value).Slika != null) {
                    ms = new MemoryStream(((KorisnikVM)value).Slika);
                    BitmapImage image = new BitmapImage();
                    image.SetSourceAsync(ms.AsRandomAccessStream());
                    return image;
                }
            }
            catch (Exception) {
            }

            try {
                if (((PorukaVM)value).Slika != null) {
                    ms = new MemoryStream(((PorukaVM)value).Slika);
                    BitmapImage image = new BitmapImage();
                    image.SetSourceAsync(ms.AsRandomAccessStream());
                    return image;
                }
            }
            catch (Exception) {
            }
            try {
                if (((KomentarVM)value).Slika != null) {
                    ms = new MemoryStream(((KomentarVM)value).Slika);
                    BitmapImage image = new BitmapImage();
                    image.SetSourceAsync(ms.AsRandomAccessStream());
                    return image;
                }
            }
            catch (Exception) {
            }
            try {
                if (((NarudzbaVM)value).Slika != null) {
                    ms = new MemoryStream(((NarudzbaVM)value).Slika);
                    BitmapImage image = new BitmapImage();
                    image.SetSourceAsync(ms.AsRandomAccessStream());
                    return image;
                }
            }
            catch (Exception) {
            }

            try {
                if (((ProizvodVM)value).Slika != null) {
                    ms = new MemoryStream(((ProizvodVM)value).Slika);
                    BitmapImage image = new BitmapImage();
                    image.SetSourceAsync(ms.AsRandomAccessStream());
                    return image;
                }
            }
            catch (Exception) {
            }
            try {
                if (((Proizvod)value).Slika != null) {
                    ms = new MemoryStream(((Proizvod)value).Slika);
                    BitmapImage image = new BitmapImage();
                    image.SetSourceAsync(ms.AsRandomAccessStream());
                    return image;
                }
            }
            catch (Exception) {
            }

            try {
                if (((FavoritiVM)value).Slika != null) {
                    ms = new MemoryStream(((FavoritiVM)value).Slika);
                    BitmapImage image = new BitmapImage();
                    image.SetSourceAsync(ms.AsRandomAccessStream());
                    return image;
                }
            }
            catch (Exception) {
            }

            try {
                if (((DojamVM)value).Slika != null) {
                    ms = new MemoryStream(((DojamVM)value).Slika);
                    BitmapImage image = new BitmapImage();
                    image.SetSourceAsync(ms.AsRandomAccessStream());
                    return image;
                }
            }
            catch (Exception) {
            }
            return null;
        }

        public object ConvertBack(System.Object value, Type targetType, System.Object parameter, System.String language) {
            return null;
        }
    }
}
