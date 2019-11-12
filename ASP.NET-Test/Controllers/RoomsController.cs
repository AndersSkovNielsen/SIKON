using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ASP.NET_Test.Models;

namespace ASP.NET_Test.Controllers
{
    public class RoomsController : Controller
    {
        // GET: Rooms
        public ActionResult Random()
        {
            var room = new Room() {Id = 1, Name = "Hall"};
            return View(room);
        }
    }
}