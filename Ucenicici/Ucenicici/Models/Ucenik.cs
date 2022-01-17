using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ucenicici.Models
{
    public class Ucenik
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string razred { get; set; }
        public int datum { get; set; }
        public string stanje { get; set; }
    }
}