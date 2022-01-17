using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektAplikacija.Models
{
    public class film
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Zanr { get; set; }
        public string Redatelj { get; set; }
        public string Trajanje { get; set; }
        public int Godina_izdanja { get; set; }
    }
}