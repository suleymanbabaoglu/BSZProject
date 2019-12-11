using System;
using System.Linq;
using System.Web.Mvc;
using MvcUI.Models;
using MvcUI.Models.Entities;

namespace MvcUI.Areas.YoneticiStation.Controllers
{
    public class SettingsController : Controller
    {
        public ActionResult Index()
        {
            Settings settings;
            Contact contact;
            using (var db = new BSZContext())
            {
                var set = db.settings.FirstOrDefault();

                settings = new Settings
                {
                    copyright = set.copyright,
                    description = set.description,
                    email = set.email,
                    favicon = set.favicon,
                    keywords = set.keywords,
                    logo = set.logo,
                    mailpass = set.mailpass,
                    mailport = set.mailport,
                    mailsendfrom = set.mailsendfrom,
                    mailserver = set.mailserver,
                    mailuser = set.mailuser,
                    prices_isactive = set.prices_isactive,
                    title = set.title
                };

                var cont = db.contact.FirstOrDefault();

                contact = new Contact
                {
                    Email = set.email,
                    About_text = cont.About_text,
                    Address = cont.Address,
                    Facebook = cont.Facebook,
                    Google_plus = cont.Google_plus,
                    Instagram = cont.Instagram,
                    Phone = cont.Phone
                };
                return View(Tuple.Create(settings, contact));
            }

        }


        [HttpPost]
        public ActionResult UpdateSettings([Bind(Prefix = "Item1")]Settings _settings, [Bind(Prefix = "Item2")]Contact _contact)
        {
            try
            {
                using (var db = new BSZContext())
                {
                    var settings = db.settings.FirstOrDefault();
                    var contact = db.contact.FirstOrDefault();

                    settings.copyright = _settings.copyright;
                    settings.description = _settings.description;
                    settings.email = _settings.email;
                    settings.keywords = _settings.keywords;
                    settings.mailpass = _settings.mailpass;
                    settings.mailport = _settings.mailport;
                    settings.mailsendfrom = _settings.mailsendfrom;
                    settings.mailserver = _settings.mailserver;
                    settings.mailuser = _settings.mailuser;
                    settings.prices_isactive = _settings.prices_isactive;
                    settings.title = _settings.title;

                    contact.Email = settings.email;
                    contact.About_text = _contact.About_text;
                    contact.Address = _contact.Address;
                    contact.Facebook = _contact.Facebook;
                    contact.Google_plus = _contact.Google_plus;
                    contact.Instagram = _contact.Instagram;
                    contact.Phone = _contact.Phone;

                    UpdateModel(settings);
                    UpdateModel(contact);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception hh)
            {
                return RedirectToAction("Index");
            }
        }

    }
}
