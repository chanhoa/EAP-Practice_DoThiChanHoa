using ManageEmployees.Models;
using ManageEmployees.Models.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ManageEmployees.Controllers
{
    public class HomeController : Controller
    {
        public EmployeesDbContext _context;

        public HomeController(EmployeesDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var query = _context.Employees;
            return View(query);
        }

      
    }
}
