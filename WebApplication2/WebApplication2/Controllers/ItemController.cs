using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ItemList = "Computer Shop Item List Page";

            List<Item> IList = new List<Item>()
            {
                new Item {ID=1, Name="iPhone", Category="Mobile", Price=2393 },
                new Item {ID=2, Name="HardDisk", Category="Computer", Price=9399 },
                new Item {ID=3, Name="Mouse", Category="Computer", Price=120 },
                new Item {ID=4, Name="Samsung Note3", Category="Mobile", Price=9348 }
            };

            return View(IList);
        }
    }
}
