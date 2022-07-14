﻿using Microsoft.AspNetCore.Http;
using Medical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.ViewModel
{
    public class CProductForShowViewModel
    {
        public List<Product> productList { get; set; }
        public List<ProductBrand> brandList { get; set; }
        public List<ProductCategory> cateList { get; set; }

        public List<ProductSpecification> prodSpec { get; set; }
        public IFormFile photo { get; set; }
        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; }
    }
}
