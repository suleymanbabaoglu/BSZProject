using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcUI.Models;
using MvcUI.Models.Entities;

namespace MvcUI.Areas.YoneticiStation.Controllers
{
    public class MenuController : Controller
    {
        private List<Menus> GetMenuList()
        {
            List<Menus> menuList = new List<Menus>();
            using (var db = new BSZContext())
            {
                foreach (var menu in db.menus.OrderBy(x => x.MenuOrder))
                {
                    menuList.Add(new Menus
                    {
                        MenuID = menu.MenuID,
                        MenuParentID = menu.MenuParentID,
                        MenuName = menu.MenuName,
                        MenuOrder = menu.MenuOrder,
                        MenuUrl = menu.MenuUrl
                    });
                }
                return menuList;
            }

        }

        public ActionResult Index()
        {
            return View(GetMenuList());
        }

        public ActionResult MenuAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MenuAdd(Menus menu)
        {
            using (var db = new BSZContext())
            {
                db.menus.Add(menu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult MenuUpdate(int id)
        {
            using (var db = new BSZContext())
            {
                var selectedMenu = db.menus.Where(m => m.MenuID == id).FirstOrDefault();
                return View(selectedMenu);
            }
        }

        [HttpPost]
        public ActionResult MenuUpdate(Menus menu, int id)
        {
            using (var db = new BSZContext())
            {
                var selectedMenu = db.menus.Where(m => m.MenuID == id).FirstOrDefault();
                selectedMenu.MenuName = menu.MenuName;
                selectedMenu.MenuOrder = menu.MenuOrder;
                selectedMenu.MenuParentID = menu.MenuParentID;
                selectedMenu.MenuUrl = menu.MenuUrl;
                UpdateModel(selectedMenu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

        }
        
        public ActionResult MenuDelete(int id)
        {
            using (var db = new BSZContext())
            {
                var selectedMenu = db.menus.Where(m => m.MenuID == id).FirstOrDefault();
                db.menus.Remove(selectedMenu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
        }



    }
}