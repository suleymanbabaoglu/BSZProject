using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcUI.Models;
using MvcUI.Models.Entities;

namespace BSZProject.MvcUI.Controllers
{
    public class LayoutController : Controller
    {
        private Settings settings;
        private Contact contact;

        public ActionResult _Head()
        {
            using (var db = new BSZContext())
            {
                settings = new Settings();
                settings = db.settings.FirstOrDefault();
                return PartialView(settings);
            }
        }

        public ActionResult _Header()
        {
            settings = new Settings();
            using (var db = new BSZContext())
            {
                foreach (var setting in db.settings)
                {
                    settings = setting;
                }
                return PartialView(settings);
            }
        }

        public ActionResult _Search()
        {
            return PartialView();
        }

        public ActionResult _TopRight()
        {
            return PartialView();
        }

        public ActionResult _Navbar()
        {
            List<Menus> menuList = new List<Menus>();
            using (var db = new BSZContext())
            {
                foreach (var menu in db.menus.OrderBy(x => x.MenuOrder).Take(10))
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
                return PartialView(menuList);
            }
        }

        public ActionResult _Footer()
        {
            using (var db = new BSZContext())
            {
                settings = new Settings();
                settings = db.settings.FirstOrDefault();
                contact = new Contact();
                contact = db.contact.FirstOrDefault();

                ViewBag.settings = settings;
                return PartialView(contact);
            }
        }

        public ActionResult _LastBlog()
        {
            return PartialView();
        }

        public ActionResult _FootLinks()
        {
            List<Footlinks> footLinks = new List<Footlinks>();
            using (var db = new BSZContext())
            {
                foreach (var link in db.footlinks.OrderBy(x => x.LinkOrder).Take(10))
                {
                    footLinks.Add(new Footlinks
                    {
                        LinkID = link.LinkID,
                        LinkOrder = link.LinkOrder,
                        LinkText = link.LinkText,
                        LinkUrl = link.LinkUrl
                    });
                }
                return PartialView(footLinks);
            }
        }
    }
}