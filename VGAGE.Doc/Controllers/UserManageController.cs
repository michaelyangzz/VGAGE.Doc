using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VGAGE.Doc.Controllers
{
    public class UserManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}