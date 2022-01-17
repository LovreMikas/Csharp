using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ucenicici.Models;

namespace Ucenicici.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Indexx()
        {
            List<Ucenik> stud = new List<Ucenik>
            {
                new Ucenik{id=1,ime="mijo",prezime="mati" ,razred="34" , datum=2002, stanje= "mater"},
                new Ucenik{id=2,ime="d",prezime="d" ,razred="34" , datum=2002, stanje= "caca"}

            };
            ViewData.Model = stud;
            return View();
        }
    }
}