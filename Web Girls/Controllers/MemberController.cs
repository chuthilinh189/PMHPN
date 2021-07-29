using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Girls.Controllers
{
     public class MemberController : Controller
     {
          public ActionResult Index()
          {
               return View();
          }
          public ActionResult Member_Add()
          {
               return View();
          }
          public ActionResult Member_Add_Detail()
          {
               return View();
          }
     }
}