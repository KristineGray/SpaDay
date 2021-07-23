using Microsoft.AspNetCore.Mvc;
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
    }
}
