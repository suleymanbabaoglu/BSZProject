using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcUI.Models;
using MvcUI.Models.Entities;

namespace MvcUI.Controllers
{
    public class AllProductsController : Controller
    {
        // GET: AllProducts
        public ActionResult Index()
        {
            using (var db = new BSZContext())
            {
                List<Products> productList = new List<Products>();
                foreach (var product in db.products.OrderByDescending(x => x.ProductID))
                {
                    productList.Add(new Products()
                    {
                        ProductID = product.ProductID,
                        ProductText = product.ProductText,
                        ProductImage1 = product.ProductImage1,
                        ProductBarcode = product.ProductBarcode
                    });
                }

                return View(productList);
            }
        }
    }
}