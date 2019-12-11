using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcUI.Models;
using MvcUI.Models.Entities;

namespace MvcUI.Areas.YoneticiStation.Controllers
{
    public class ProductController : Controller
    {
        private List<Products> GetProductList()
        {
            List<Products> productList = new List<Products>();
            using (var db = new BSZContext())
            {
                foreach (var products in db.products)
                {
                    productList.Add(new Products
                    {
                        ProductID = products.ProductID,
                        ProductBarcode = products.ProductBarcode,
                        ProductBrand = products.ProductBrand,
                        ProductText = products.ProductText,
                        ProductInfo = products.ProductInfo,
                        ProductImage1 = products.ProductImage1,
                        ProductImage2 = products.ProductImage2,
                        ProductImage3 = products.ProductImage3,
                        ProductImage4 = products.ProductImage4
                    });
                }
                return productList;
            }

        }

        public ActionResult Index()
        {
            return View(GetProductList());
        }

        public ActionResult ProductAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProductAdd(Products products)
        {
            using (var db = new BSZContext())
            {
                db.products.Add(products);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult ProductUpdate(int id)
        {
            using (var db = new BSZContext())
            {
                var selectedProduct = db.products.Where(m => m.ProductID == id).FirstOrDefault();
                return View(selectedProduct);
            }
        }

        [HttpPost]
        public ActionResult ProductUpdate(Products product, int id)
        {
            using (var db = new BSZContext())
            {
                var selectedProduct = db.products.Where(m => m.ProductID == id).FirstOrDefault();
                selectedProduct.ProductBarcode = product.ProductBarcode;
                selectedProduct.ProductBrand = product.ProductBrand;
                selectedProduct.ProductText = product.ProductText;
                selectedProduct.ProductInfo = product.ProductInfo;
                selectedProduct.ProductImage1 = product.ProductImage1;
                selectedProduct.ProductImage2 = product.ProductImage2;
                selectedProduct.ProductImage3 = product.ProductImage3;
                selectedProduct.ProductImage4 = product.ProductImage4;
                UpdateModel(selectedProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

        }

        public ActionResult ProductDelete(int id)
        {
            using (var db = new BSZContext())
            {
                var selectedProduct = db.products.Where(m => m.ProductID == id).FirstOrDefault();
                db.products.Remove(selectedProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

        }



    }

}