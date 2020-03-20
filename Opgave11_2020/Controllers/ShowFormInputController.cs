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
    public class ShowFormInputController : Controller
    {
        [HttpPost]
        public IActionResult Index(string firstName, string lastName, string email, int phone)
        {
            var fieldFornavn = firstName;
            var fieldEfternavn = lastName;
            var fieldMail = email;
            var fieldTelefon = phone;
            var formularModel = new GetFormInput() { firstName = fieldFornavn, lastName = fieldEfternavn, email = fieldMail, phone = fieldTelefon };
            return View(formularModel);
        }
    }
}
