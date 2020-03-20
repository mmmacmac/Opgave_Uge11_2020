using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Opgave11_2020.Models;

namespace Opgave11_2020.Controllers
{
    public class GetFormInputController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
