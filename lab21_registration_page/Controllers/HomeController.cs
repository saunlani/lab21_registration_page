using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab21_registration_page.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Your Registration page.";

            return View();
        }

        public ActionResult Confirmation(string _firstname, string _lastname, 
            string _birthdate, string _email, string _password, string _phonenumber, 
            string _gender, string _subscribe, string _fdrink)
        {
            ViewBag.FirstName = _firstname;
            ViewBag.LastName = _lastname;
            ViewBag.Birthdate = _birthdate;
            ViewBag.Email = _email;
            ViewBag.Password = _password;
            ViewBag.PhoneNumber = _phonenumber;
            ViewBag.Gender = _gender;
            ViewBag.Subscribe = _subscribe;
            ViewBag.FavDrink = _fdrink;
            return View();
        }

        public ActionResult Welcome(string input)
        {
            ViewBag.Message = "Your Welcome page.";

            ViewBag.FirstName = input;
            return View();
        }
    }
}
