using Juris.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Juris.net.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View(new List<ClienteViewModel>());
        }

        public ActionResult Add()
        {
            return View(new ClienteViewModel());
        }
    }
}