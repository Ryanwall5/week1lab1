using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            Person fred = new Person();
            fred.LastName = "wall";

            ViewBag.FirstName = "Ryan";
            ViewBag.LastName = fred.LastName;
            ViewBag.Address = "815 awesome st. Canby, Oregon 97013";
            return View();
        }
        
    }
}