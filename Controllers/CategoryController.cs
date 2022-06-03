using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using To_Do_List.Models;

namespace To_Do_List.Controllers
{
    public class CategoryController : Controller
    {

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string name)
        {

            Data.categories.Add(new Category
            {
                ID = Guid.NewGuid(),
                Name = name,
                Item = new List<Item>()


            });
            return RedirectToAction("Index", "Home");
        }
    }
}