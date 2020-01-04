using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialTagHelper_Demo.Data;
using PartialTagHelper_Demo.Models;

namespace PartialTagHelper_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext  dbContext;

        public HomeController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            var employee = dbContext.Employees.ToList();
            return View(employee);
        }

        public PartialViewResult Employees()
        {
            var employee = dbContext.Employees.ToList();
            return PartialView("_Employee", employee);
        }

    }
}
