using Microsoft.AspNetCore.Mvc;
using Mo3askarCore1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mo3askarCore1.Controllers
{

    public class ProductsController : Controller
    {
        // Pro = table
        static List<Product> pro = new List<Product>() {
        new Product{Id=1,ProductName="IPhonex",Price=1000,Qty=50},
        new Product{Id=2,ProductName="Nokia",Price=500,Qty=70}
       };

        public IActionResult AllProducts()
        {
            // from iActionResult to view
            ViewBag.pName = "Note 20";
            ViewBag.pPrice = "900";

            return View(pro);
        }

        public IActionResult NewProduct()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            // select *
            // from product
            // where Id=id
            // LINQ
            var x = (from p in pro
                     where p.Id == id
                     select p).SingleOrDefault();
            return View(x);


        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                pro.Add(product);
                return RedirectToAction("AllProducts");
            }
            return View(product);
        }

        public IActionResult Delete(int id)
        {
            var x = (from y in pro
                     where y.Id == id
                     select y).SingleOrDefault();
            pro.Remove(x);
            return RedirectToAction("AllProducts");
        }


    }
}
