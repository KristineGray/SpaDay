using Microsoft.AspNetCore.Mvc;
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

        // Create action method Add()
        // Should correspond to path: /user/add
        // return Add.cshtml view
        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        // Create action method for SubmitAddUserForm
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here

            // Check that the verify parameter matches the password within the newUser object
            // If true: 
                // store the user’s name in a ViewBag property and
                // return View("Index").
            // If false, render the form again
            if (newUser.Password == verify)
            {
                ViewBag.username = newUser.Username;
                return View("Index");
            }
            else
            {
                return View("Add");
            }
        }
    }
}
