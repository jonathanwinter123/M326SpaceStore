using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceStorium.Controllers
{
    using System.IO;

    using Newtonsoft.Json;

    using SpaceStorium.Models;

    public class ProductOverviewController : Controller
    {
        public ActionResult ProductOverview()
        {
            this.Products = this.GetProducts();
            return this.View(this.Products);
        }

        public List<Product> Products { get; set; }

        public List<Product> GetProducts()
        {
            string filePath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
            using (StreamReader streamReader = new StreamReader(filePath + @"\App_Data\data.json"))
            {
                string json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Product>>(json);
            }
        }
    }
}