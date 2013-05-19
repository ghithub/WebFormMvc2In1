using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFormMvc2In1.Controllers
{
    public class HelloController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}