using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyNetCoreMVC.Models;

namespace MyNetCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        // 
        //[Route("Huy/Index/{id:int}")]

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetList()
        {
            return View();
        }

        public IActionResult Create( string name, string price)
        {
            ViewData["name"] = name;
            ViewData["price"] = price;
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete( int ID)
        {
            return new JsonResult(new Product()
            {
                id = ID
            });
        }
    }
}