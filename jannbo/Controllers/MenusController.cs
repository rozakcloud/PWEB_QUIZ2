using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jannbo.Entities;

namespace MVCMenus.Controllers
{
    [Authorize]
    public class MenusController : Controller
    {
        // GET: Menus
        public ActionResult Index()
        {
            List<Menus> m;
            using (var r = new MenusEntities())
            {
                m = r.Menus.ToList();
            }
            return View(m);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            var menusmodel = new Menus();
            TryUpdateModel(menusmodel);

            using (var r = new MenusEntities())
            {
                r.Menus.Add(menusmodel);
                r.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}