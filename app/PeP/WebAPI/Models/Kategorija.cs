using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Kategorija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    }
}