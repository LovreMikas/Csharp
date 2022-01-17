using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjektAplikacija.Models;

namespace ProjektAplikacija.Controllers
{
    public class filmsController : Controller
    {
        // GET: films
        public ActionResult top()
        {
            List<film> fil = new List<film>
            {
                new film{ Id = 1, Naziv = "The Godfather", Zanr = "Krimi/Drama", Redatelj = "Francis Ford Coppola", Trajanje = "2 h 58 m", Godina_izdanja = 1972 },
                new film{ Id = 2, Naziv = "The Wizard of Oz", Zanr = "Fantastika/Mjuzikl", Redatelj = "Victor Fleming", Trajanje = "1 h 52 m", Godina_izdanja = 1939 },
                new film{ Id = 3, Naziv = "Citizen Kane", Zanr = "Drama/Misterija", Redatelj = "Orson Welles", Trajanje = "1 h 59 m", Godina_izdanja = 1941 },
                new film{ Id = 4, Naziv = "Casablanca", Zanr = "Romantični/Ratni", Redatelj = "Michael Curtiz", Trajanje = "1 h 42 m", Godina_izdanja = 1942 },
                new film{ Id = 5, Naziv = "E.T. The Extra-Terrestrial", Zanr = "Pustolovni/Dječji", Redatelj = "Steven Spielberg", Trajanje = "2 h 1 m", Godina_izdanja = 1982 },
                new film{ Id = 6, Naziv = "2001: A Space Odyssey", Zanr = "ZF/Pustolovni", Redatelj = "Stanley Kubrick", Trajanje = "2 h 44 m", Godina_izdanja = 1968 },
                new film{ Id = 7, Naziv = "Back to the Future", Zanr = "Komedija/ZF", Redatelj = "Robert Zemeckis", Trajanje = "1 h 56 m", Godina_izdanja = 1985 },
                new film{ Id = 8, Naziv = "Forrest Gump", Zanr = "Drama/Romantični", Redatelj = "Robert Zemeckis", Trajanje = "2 h 22 m", Godina_izdanja = 1994 },
                new film{ Id = 9, Naziv = "Gone With the Wind", Zanr = "Romantični/Drama", Redatelj = "Victor Fleming", Trajanje = "3 h 58 m", Godina_izdanja = 1939 },
                new film{ Id = 10, Naziv = "The Sound of Music", Zanr = "Mjuzikl/Romantičn", Redatelj = "Robert Wise", Trajanje = "2 h 55 m", Godina_izdanja = 1965 }
            };

            ViewData.Model = fil;

            return View();
        }
    }
}