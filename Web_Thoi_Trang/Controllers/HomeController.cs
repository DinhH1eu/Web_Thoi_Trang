using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Thoi_Trang.Models;

namespace Web_Thoi_Trang.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Product()
        {
            List<Product> DanhSach = new List<Product>();
            DanhSach.Add(new Product()
            {
                ID = 1,
                product_image = "/shop/images/product-01.jpg",
                product_name = "Esprit Ruffle Shirt",
                price  = "$16.64",
            });
            DanhSach.Add(new Product()
            {
                ID = 2,
                product_image = "/shop/images/product-02.jpg",
                product_name = "Herschel supply",
                price = "$35.31",
            });
            DanhSach.Add(new Product()
            {
                ID = 3,
                product_image = "/shop/images/product-03.jpg",
                product_name = "Only Check Trouser",
                price = "$35.31",
            });
            DanhSach.Add(new Product()
            {
                ID = 4,
                product_image = "/shop/images/product-04.jpg",
                product_name = "Herschel supply",
                price = "$35.31",
            });
            DanhSach.Add(new Product()
            {
                ID = 5,
                product_image = "/shop/images/product-05.jpg",
                product_name = "Herschel supply",
                price = "$35.31",
            });
            DanhSach.Add(new Product()
            {
                ID = 6,
                product_image = "/shop/images/product-06.jpg",
                product_name = "Herschel supply",
                price = "$35.31",
            });
            DanhSach.Add(new Product()
            {
                ID = 7,
                product_image = "/shop/images/product-07.jpg",
                product_name = "Herschel supply",
                price = "$35.31",
            });
            DanhSach.Add(new Product()
            {
                ID = 8,
                product_image = "/shop/images/product-08.jpg",
                product_name = "Herschel supply",
                price = "$35.31",
            });
            DanhSach.Add(new Product()
            {
                ID = 9,
                product_image = "/shop/images/product-09.jpg",
                product_name = "Herschel supply",
                price = "$35.31",
            });
            DanhSach.Add(new Product()
            {
                ID = 10,
                product_image = "/shop/images/product-10.jpg",
                product_name = "Herschel supply",
                price = "$35.31",
            });
            DanhSach.Add(new Product()
            {
                ID = 11,
                product_image = "/shop/images/product-11.jpg",
                product_name = "Herschel supply",
                price = "$35.31",
            });
            DanhSach.Add(new Product()
            {
                ID = 12,
                product_image = "/shop/images/product-12.jpg",
                product_name = "Herschel supply",
                price = "$35.31",
            });

            return View(DanhSach);
        }

        public ActionResult Product_Detail()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Shoping_Cart()
        {
            return View();
        }
    }
}