﻿using Medical.Models;
using Medical.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    public class AdminProductController : Controller
    {

        private readonly MedicalContext db;
        private IWebHostEnvironment _environment;
        public AdminProductController(IWebHostEnvironment myEnvironment, MedicalContext _medical)
        {
            _environment = myEnvironment;
            db = _medical;
        }

        public IActionResult productManage()

        {
            CProductViewModel model = new CProductViewModel
            {
                productList = db.Products.ToList(),
                brandList = db.ProductBrands.ToList(),
                cateList = db.ProductCategories.ToList(),
                prodSpecList = db.ProductSpecifications.ToList()

            };

            IEnumerable<SelectListItem> brandSelectListItem = (from p in db.ProductBrands
                                                               where p.ProductBrandName != null
                                                               select p).ToList().Select(p => new SelectListItem
                                                               { Value = p.ProductBrandId.ToString(), Text = p.ProductBrandName });

            ViewBag.brandSelectListItem = brandSelectListItem;


            IEnumerable<SelectListItem> cateSelectListItem = (from p in db.ProductCategories
                                                              where p.ProductCategoryName != null
                                                              select p).ToList().Select(p => new SelectListItem
                                                              { Value = p.ProductCategoryId.ToString(), Text = p.ProductCategoryName });

            ViewBag.cateSelectListItem = cateSelectListItem;




            return View(model);
        }

        public IActionResult SelectedProduct(int? id)
        {
            ProductSpecification ps = db.ProductSpecifications.FirstOrDefault(ps => ps.ProductId == id);
            Product p = db.Products.FirstOrDefault(p => p.ProductId == id);
            CSelectedProductViewModel prod = new CSelectedProductViewModel()
            {


                Shelfdate = p.Shelfdate,
                Stock = p.Stock,
                ProductSpecificationId = ps.ProductSpecificationId,
                ProductId = ps.ProductId,
                ProductAppearance = ps.ProductAppearance,
                ProductColor = ps.ProductColor,
                ProductImage = ps.ProductImage,
                ProductMaterial = ps.ProductMaterial,
                ProductName = ps.Product.ProductName,
                Discontinued = p.Discontinued,
                UnitPrice = ps.UnitPrice,
                ProductBrandId = p.ProductBrandId,
                ProductCategoryId = p.ProductCategoryId

            };

            return Json(prod);
        }
        [HttpPost]
        public IActionResult ChangeSave(CSelectedProductViewModel cSelected /*string myJson*/)
        {
            // CSelectedProductViewModel cSelected = JsonSerializer.Deserialize<CSelectedProductViewModel>(myJson);
            Product mp = db.Products.FirstOrDefault(p => p.ProductId == cSelected.ProductId);
            ProductSpecification mps = db.ProductSpecifications.FirstOrDefault(m => m.ProductSpecificationId == cSelected.ProductSpecificationId);


            var file = Request.Form.Files["photo"];


            //"{\"Discontinued\":\"false\",\"ProductId\":\"0\",\"ProductAppearance\":\"最新款黑色太陽眼鏡\",\"ProductImage\":" +
            //    "\"/images/6143e97f-4d04-439c-bc97-4741069e20db.jpg\",\"ProductMaterial\":\"soft\",\"ProductName\":\"雷朋太陽眼鏡(黑)\"," +
            //    "\"Shelfdate\":\"999\",\"Stock\":\"16\"," +
            //    "\"UnitPrice\":\"5003\",\"ProductBrandId\":\"3\",\"ProductCategoryId\":\"1\",\"ProductSpecificationId\":\"2\"}"

            if (cSelected.photo != null)
            {
                string mpName = Guid.NewGuid().ToString() + ".jpg";
                cSelected.photo.CopyTo(new FileStream(_environment.WebRootPath + "/images/" + mpName, FileMode.Create));
                mps.ProductImage = mpName;
            }

            mp.Discontinued = cSelected.Discontinued;
            mp.ProductBrandId = cSelected.ProductBrandId;
            mp.ProductCategoryId = cSelected.ProductCategoryId;
            mp.ProductName = cSelected.ProductName;
            mp.Shelfdate = cSelected.Shelfdate;
            mp.Stock = cSelected.Stock;

            mps.ProductAppearance = cSelected.ProductAppearance;
            mps.ProductColor = cSelected.ProductColor;
            mps.ProductMaterial = cSelected.ProductMaterial;
            mps.UnitPrice = cSelected.UnitPrice;
            db.SaveChanges();

            return Content("成功");
        }



    }
}
