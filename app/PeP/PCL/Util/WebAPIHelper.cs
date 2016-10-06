using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//using WebAPI.Models;
//using WebAPI.ViewModels;

namespace PCL.Util
{
    public class WebAPIHelper
    {
        private HttpClient Client { get; set; }
        private string Route { get; set; }

        public WebAPIHelper(string Uri, string Route)
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(Uri);
            this.Route = Route;
        }

        public HttpResponseMessage GetResponseParams(string action, params string[] param)
        {
            // kao QueryString (ne radi) ->
            //string paramtersForRoute = "?Ime=" + txtIme.Text + "&Prezime=" + txtPrezime.Text + "&StatusId=" + txt.StatusId.Text;

            // (radi) -> 
            //  string paramtersForRoute = "api/Korisnik/GetAdmin/Faruk/Redzic/1" 
            string paramatersForRoute = String.Empty;
            for (int i = 0; i < param.Length; i++)
                paramatersForRoute += "/" + param[i];

            return Client.GetAsync(Route + "/" + action + paramatersForRoute).Result; // api/Korisnik/GetAdmin/Faruk/Redzic/1
        }


        public HttpResponseMessage GetResponse(string action)
        {
            return Client.GetAsync(Route + "/" + action).Result;
        }

        public HttpResponseMessage PostResponse(string action, Object obj)
        {
            return Client.PostAsJsonAsync(Route + "/" + action, obj).Result;
        }

        public HttpResponseMessage PostResponse(Object obj)
        {
            return Client.PostAsJsonAsync(Route, obj).Result;
        }

        public HttpResponseMessage DeleteResponse(int id)
        {
            return Client.DeleteAsync(Route + "/" +  id).Result;
        }

        public HttpResponseMessage PutResponse(int id, Object obj)
        {
            return Client.PutAsJsonAsync(Route + "/" + id,obj).Result;
        }

    }
}
