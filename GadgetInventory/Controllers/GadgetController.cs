using Microsoft.AspNetCore.Mvc;
using GadgetInventory.Models;
using System.Collections.Generic;

namespace GadgetInventory.Controllers
{
    public class GadgetController : Controller
    {
        private static List<Gadget> _gadgets = new List<Gadget>
        {
            new Gadget { Id = 1, Brand = "Apple", ModelName = "iPhone 15", Price = 799.00m},
            new Gadget { Id = 2, Brand = "Samsung", ModelName = "Galaxy S24", Price = 849.00m}
        };

        public  IActionResult Index()
        {
            return View(_gadgets);
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Gadget newGadget)
        {
            if (!ModelState.IsValid)
            {
                return View(newGadget);
            }
            newGadget.Id = _gadgets.Count + 1;
            _gadgets.Add(newGadget);

            return RedirectToAction("Index");
        }
    }
}
