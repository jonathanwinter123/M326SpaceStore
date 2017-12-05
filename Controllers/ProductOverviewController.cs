using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceStorium.Controllers
{
    public class ProductOverviewController : Controller
    {
        public ActionResult ProductOverview()
        {
            return this.View();
        }
    }
}