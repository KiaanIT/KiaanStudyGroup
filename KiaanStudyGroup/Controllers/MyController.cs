using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiaanStudyGroup.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            List<Models.MyClass> Support = new List<Models.MyClass>();

            Support.Add(new Models.MyClass { StudentNumber = "u24600904", Name = "Kiaan", Surname = "Taljaard", Email = "u24600904@tuks.co.za" });
            Support.Add(new Models.MyClass { StudentNumber = "u24943802", Name = "Danel", Surname = "Steyn", Email = "u24943802@tuks.co.za" });
            Support.Add(new Models.MyClass { StudentNumber = "u24589412", Name = "Arno", Surname = "Redpath", Email = "u24589412@tuks.co.za" });
            Support.Add(new Models.MyClass { StudentNumber = "u24569748", Name = "Milos", Surname = "Sarovic", Email = "u24569748@tuks.co.za" });
            Support.Add(new Models.MyClass { StudentNumber = "u23815524", Name = "Sechaba", Surname = "Phahlamohlaka", Email = "u23815524@tuks.co.za" });



            return View(Support);
        }
    }
}