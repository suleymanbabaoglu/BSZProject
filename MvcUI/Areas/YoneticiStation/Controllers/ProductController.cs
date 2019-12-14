using System;
using System.Collections.Generic;
using System.IO;
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
        public ActionResult ProductAdd(Products products, HttpPostedFileBase productImage1, HttpPostedFileBase productImage2, HttpPostedFileBase productImage3, HttpPostedFileBase productImage4)
        {
            FileInfo fi;
            using (var db = new BSZContext())
            {
                if (productImage1 != null)
                {
                    fi = new FileInfo(productImage1.FileName);
                    if (fi.Extension.ToLower() == ".jpg" || fi.Extension.ToLower() == ".png" ||
                        fi.Extension.ToLower() == ".jpeg")
                    {
                        string img1Path = products.ProductBarcode + "-1" + fi.Extension;
                        var img1UploadPath = Path.Combine(Server.MapPath(Url.Content("~/Contents/img/products/" + products.ProductBarcode + "/" + img1Path)));
                        if (!Directory.Exists(Server.MapPath(Url.Content("~/Contents/img/products/" + products.ProductBarcode))))
                        {
                            Directory.CreateDirectory(Server.MapPath(Url.Content("~/Contents/img/products/" + products.ProductBarcode)));
                        }
                        else
                        {
                            Directory.Delete(Server.MapPath(Url.Content("~/Contents/img/products/" + products.ProductBarcode)),true);
                        }
                        productImage1.SaveAs(img1UploadPath);
                        products.ProductImage1 = img1Path;
                    }


                    if (productImage2 != null)
                    {
                        if (fi.Extension.ToLower() == ".jpg" || fi.Extension.ToLower() == ".png" ||
                            fi.Extension.ToLower() == ".jpeg")
                        {
                            fi = new FileInfo(productImage2.FileName);
                            string img2Path = products.ProductBarcode + "-2" + fi.Extension;
                            var img2UploadPath = Path.Combine(Server.MapPath(
                                Url.Content("~/Contents/img/products/" + products.ProductBarcode + "/" + img2Path)));
                            productImage2.SaveAs(img2UploadPath);
                            products.ProductImage2 = img2Path;
                        }
                    }

                    if (productImage3 != null)
                    {
                        fi = new FileInfo(productImage3.FileName);
                        if (fi.Extension.ToLower() == ".jpg" || fi.Extension.ToLower() == ".png" ||
                            fi.Extension.ToLower() == ".jpeg")
                        {
                            string img3Path = products.ProductBarcode + "-3" + fi.Extension;
                            var img3UploadPath = Path.Combine(Server.MapPath(
                                Url.Content("~/Contents/img/products/" + products.ProductBarcode + "/" + img3Path)));
                            productImage3.SaveAs(img3UploadPath);
                            products.ProductImage3 = img3Path;
                        }
                    }

                    if (productImage4 != null)
                    {
                        fi = new FileInfo(productImage4.FileName);
                        if (fi.Extension.ToLower() == ".jpg" || fi.Extension.ToLower() == ".png" ||
                            fi.Extension.ToLower() == ".jpeg")
                        {
                            string img4Path = products.ProductBarcode + "-4" + fi.Extension;
                            var img4UploadPath = Path.Combine(Server.MapPath(
                                Url.Content("~/Contents/img/products/" + products.ProductBarcode + "/" + img4Path)));
                            productImage4.SaveAs(img4UploadPath);
                            products.ProductImage4 = img4Path;
                        }
                    }
                    db.products.Add(products);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("ProductAdd");
                }
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
        public ActionResult ProductUpdate(Products product, int id, HttpPostedFileBase image1, HttpPostedFileBase image2, HttpPostedFileBase image3, HttpPostedFileBase image4)
        {
            FileInfo fi;
            using (var db = new BSZContext())
            {
                var selectedProduct = db.products.Where(m => m.ProductID == id).FirstOrDefault();
                selectedProduct.ProductBrand = product.ProductBrand;
                selectedProduct.ProductText = product.ProductText;
                selectedProduct.ProductInfo = product.ProductInfo;

                if (selectedProduct.ProductBarcode != product.ProductBarcode)
                {
                    if (Directory.Exists(
                        Server.MapPath(Url.Content("~/Contents/img/products/" + selectedProduct.ProductBarcode))))
                    {
                        Directory.CreateDirectory(
                            Server.MapPath(
                                Url.Content("~/Contents/img/products/" + product.ProductBarcode)));

                        string from1 =
                               Server.MapPath(
                                   Url.Content("~/Contents/img/products/" + selectedProduct.ProductBarcode + "/" + selectedProduct.ProductImage1));
                        string to1 =
                            Server.MapPath(
                                Url.Content("~/Contents/img/products/" + product.ProductBarcode + "/" + product.ProductBarcode + "-1." +selectedProduct.ProductImage1.Split('.').Last()));
                        System.IO.File.Move(from1, to1);
                        selectedProduct.ProductImage1 = product.ProductBarcode + "-1." + selectedProduct.ProductImage1.Split('.').Last();

                        string from2 =
                            Server.MapPath(
                                Url.Content("~/Contents/img/products/" + selectedProduct.ProductBarcode + "/" + selectedProduct.ProductImage2));
                        string to2 =
                            Server.MapPath(
                                Url.Content("~/Contents/img/products/" + product.ProductBarcode + "/" + product.ProductBarcode + "-2." + selectedProduct.ProductImage2.Split('.').Last()));
                        System.IO.File.Move(from2, to2);
                        selectedProduct.ProductImage2 = product.ProductBarcode + "-2." + selectedProduct.ProductImage2.Split('.').Last();

                        string from3 =
                            Server.MapPath(
                                Url.Content("~/Contents/img/products/" + selectedProduct.ProductBarcode + "/" + selectedProduct.ProductImage3));
                        string to3 =
                            Server.MapPath(
                                Url.Content("~/Contents/img/products/" + product.ProductBarcode + "/" + product.ProductBarcode + "-3." + selectedProduct.ProductImage3.Split('.').Last()));
                        System.IO.File.Move(from3, to3);
                        selectedProduct.ProductImage3 = product.ProductBarcode + "-3." + selectedProduct.ProductImage3.Split('.').Last();

                        string from4 =
                            Server.MapPath(
                                Url.Content("~/Contents/img/products/" + selectedProduct.ProductBarcode + "/" + selectedProduct.ProductImage4));
                        string to4 =
                            Server.MapPath(
                                Url.Content("~/Contents/img/products/" + product.ProductBarcode + "/" + product.ProductBarcode + "-4." + selectedProduct.ProductImage4.Split('.').Last()));
                        System.IO.File.Move(from4, to4);
                        selectedProduct.ProductImage4 = product.ProductBarcode + "-4." + selectedProduct.ProductImage4.Split('.').Last();

                        Directory.Delete(
                            Server.MapPath(
                                Url.Content("~/Contents/img/products/" + selectedProduct.ProductBarcode)), true);

                    }
                }
                selectedProduct.ProductBarcode = product.ProductBarcode;

                if (image1 != null)
                {
                    fi = new FileInfo(image1.FileName);
                    string img1Path = selectedProduct.ProductBarcode + "-1" + fi.Extension;
                    var img1UploadPath = Path.Combine(Server.MapPath(Url.Content("~/Contents/img/products/" + selectedProduct.ProductBarcode + "/" + img1Path)));
                    image1.SaveAs(img1UploadPath);
                    selectedProduct.ProductImage1 = img1Path;
                }
                if (image2 != null)
                {
                    fi = new FileInfo(image2.FileName);
                    string img2Path = selectedProduct.ProductBarcode + "-2" + fi.Extension;
                    var img2UploadPath = Path.Combine(Server.MapPath(Url.Content("~/Contents/img/products/" + selectedProduct.ProductBarcode + "/" + img2Path)));
                    image2.SaveAs(img2UploadPath);
                    selectedProduct.ProductImage2 = img2Path;
                }

                if (image3 != null)
                {
                    fi = new FileInfo(image3.FileName);
                    string img3Path = selectedProduct.ProductBarcode + "-3" + fi.Extension;
                    var img3UploadPath = Path.Combine(Server.MapPath(Url.Content("~/Contents/img/products/" + selectedProduct.ProductBarcode + "/" + img3Path)));
                    image3.SaveAs(img3UploadPath);
                    selectedProduct.ProductImage3 = img3Path;
                }

                if (image4 != null)
                {
                    fi = new FileInfo(image4.FileName);
                    string img4Path = selectedProduct.ProductBarcode + "-4" + fi.Extension;
                    var img4UploadPath = Path.Combine(Server.MapPath(Url.Content("~/Contents/img/products/" + selectedProduct.ProductBarcode + "/" + img4Path)));
                    image4.SaveAs(img4UploadPath);
                    selectedProduct.ProductImage4 = img4Path;
                }
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
                Directory.Delete(
                    Server.MapPath(
                        Url.Content("~/Contents/img/products/" + selectedProduct.ProductBarcode)), true);
                return RedirectToAction("Index");
            }

        }

        private void FileAndDirDelete()
        {

        }

    }

}