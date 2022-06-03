using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using To_Do_List.Models;

namespace To_Do_List.Controllers
{
    public class ItemController : Controller
    {

        [HttpGet]
        public ActionResult Add(Guid ID)
        {
            return View(ID);
        }

        [HttpPost]
        public ActionResult Add(Guid ID, string item)
        {
            Data.FindCategory(ID).Item.Add(new Item
            {
                ID = ID,
                Name = item,
                Completed = false
            });

            return RedirectToAction("Index", "Home");
        }
    }
}