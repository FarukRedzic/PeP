using PCL.Models;
using PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;

namespace WinPhoneUI.NotifikacijePhone {
    public static class NotificationPhone 
    {
        private static DispatcherTimer timer = new DispatcherTimer();

        static WebAPIHelper serviceNotifikacije = new WebAPIHelper("http://localhost:61718/", "api/Notifikacije");

        public static void StartNotificationTimer() {
            timer.Interval = new TimeSpan(0, 0, 0, 10, 0);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public static void StopNotificationTimer() {
            timer.Stop();
        }

        public static async void timer_Tick(object sender, object e) {
            string message = string.Empty;
            List<Notifikacije> lista = new List<Notifikacije>();
            HttpResponseMessage response = serviceNotifikacije.GetResponseParams("GetNotifikacijes",Global.logiraniKorisnik.Id.ToString());
            if (response.IsSuccessStatusCode) {
                lista = response.Content.ReadAsAsync<List<Notifikacije>>().Result;
                for (int i = 0; i < lista.Count; i++) {
                    switch (lista[i].VrstaNotifikacijeId) {
                        case 1:
                            message += "-Imate novi zahtjev za narudžbu od korisnika: " + lista[i].Narudzba.Korisnik.KorisnickoIme + ".\n"; //prodavacu
                            break;
                        case 2:
                            message += "-Vaša narudžba artikla: " + lista[i].Narudzba.Proizvod.Naziv + " je uspješno procesirana.\n"; // kupcu
                            break;
                        case 3:
                            message += "-Vaša narudžba artikla: " + lista[i].Narudzba.Proizvod.Naziv + " je otkazana.\n"; // kupcu
                            break;
                        case 4:
                            message += "-Narudžba artikla: " + lista[i].Narudzba.Proizvod.Naziv + " je uspješno zaključena.\n"; // prodavacu
                            break;
                        case 5:
                            message += "-Korisnik: " + lista[i].KomentarisaoProizvod + " je komentarisao vaš proizvod: " + lista[i].Proizvod.Naziv + ".\n";
                            break;
                        case 6:
                            message += "-Dobili ste novu poruku od korisnika: " + lista[i].PoslaoPoruku + ".\n";
                            break;
                        default: break;
                    }
                }
            }
            if (!string.IsNullOrEmpty(message)) {
                try {
                    MessageDialog notifikacija = new MessageDialog(message, "Notifikacije");
                    await notifikacija.ShowAsync();
                    for (int i = 0; i < lista.Count; i++) {
                        lista[i].isNeaktivna = true;
                        HttpResponseMessage responsePut = serviceNotifikacije.PutResponse(lista[i].Id, lista[i]);
                    }
                }
                catch (Exception) {
                    return;
                }
            }
        }
    }
}
