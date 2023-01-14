using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingalRDemo.Web.Controllers
{
    public class SignalRTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
