using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CP.UI.Controllers
{
    public class TestActController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public void TestAction()
        {
            var tes = 1;
        }
    }
}