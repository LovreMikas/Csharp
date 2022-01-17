using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektAplikacija.Models
{
    public class filmovi
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public Zanr Tip { get; set; }
    }

    public enum Zanr
    {
        komedija,
        akcija,
        romantika,
        drama,
        horor,
        ratni,
        krimi,
        triler,
        fantazija,
        mjuzikl,
        vestern,
        dokumentarac,
        animacija,
        biografija
    }

}