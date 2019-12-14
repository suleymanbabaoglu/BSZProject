using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcUI.Models;
using MvcUI.Models.Entities;

namespace BSZProject.MvcUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _HeroSlider()
        {
            using (var db=new BSZContext())
            {
                List<Sliders> sliderList = new List<Sliders>();
                foreach (var slider in db.sliders.Where(x => x.SliderIsActive == true).OrderBy(x => x.SliderOrder))
                {
                    sliderList.Add(new Sliders
                    {
                        SliderID = slider.SliderID,
                        SliderOrder = slider.SliderOrder,
                        SliderText1 = slider.SliderText1,
                        SliderText2 = slider.SliderText2,
                        SliderInformation = slider.SliderInformation,
                        SliderBackground = slider.SliderBackground,
                        SliderPrice = slider.SliderPrice,
                        SliderCurrency = slider.SliderCurrency,
                        SliderLink1 = slider.SliderLink1,
                        SliderLink2 = slider.SliderLink2,
                        SliderLinkText1 = slider.SliderLinkText1,
                        SliderLinkText2 = slider.SliderLinkText2,
                        SliderIsActive = slider.SliderIsActive
                    });
                }
                return PartialView(sliderList);
            }
        }

        public ActionResult _Features()
        {
            using (var db = new BSZContext())
            {
                List<Features> featureList = new List<Features>();
                foreach (var feature in db.features.OrderByDescending(x => x.FeatureOrder).Take(3))
                {
                    featureList.Add(new Features()
                    {
                        FeatureID = feature.FeatureID,
                        FeatureOrder = feature.FeatureOrder,
                        FeatureText = feature.FeatureText,
                        FeatureImage = feature.FeatureImage,
                        FeatureUrl = feature.FeatureUrl
                    });
                }
                return PartialView(featureList);
            }
            
        }

        public ActionResult _LatestProducts()
        {
            using (var db = new BSZContext())
            {
                List<Products> productList = new List<Products>();
                foreach (var product in db.products.OrderByDescending(x => x.ProductID).Take(5))
                {
                    productList.Add(new Products()
                    {
                        ProductID = product.ProductID,
                        ProductText = product.ProductText,
                        ProductImage1 = product.ProductImage1,
                        ProductBarcode = product.ProductBarcode
                    });
                }

                return PartialView(productList);
            }
        }

        public ActionResult _ProductFilter()
        {
            using (var db = new BSZContext())
            {
                List<Products> productList = new List<Products>();
                foreach (var product in db.products.OrderBy(x => x.ProductID).Take(8))
                {
                    productList.Add(new Products()
                    {
                        ProductID = product.ProductID,
                        ProductText = product.ProductText,
                        ProductImage1 = product.ProductImage1,
                        ProductBarcode = product.ProductBarcode
                    });
                }

                return PartialView(productList);
            }
        }

        public ActionResult _Banner()
        {
            return PartialView();
        }


    }
}