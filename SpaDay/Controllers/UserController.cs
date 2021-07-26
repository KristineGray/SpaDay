using Microsoft.AspNetCore.Mvc;
using SpaDay.Data;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("/user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.verify = verify;
            ViewBag.username = newUser.Username;
            ViewBag.email = newUser.Email;
            ViewBag.password = newUser.Password;

            if (newUser.Password.Equals(verify))
            {
                return View("Index");
            }
            else
            {
                ViewBag.error = "Passwords must match to continue to the spa. Try again.";
                return View("Add");
            }
        }
    }
}
