﻿using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideVm> Slides { get; set; }
        public List<ProductVm> FeaturedProducts { get; set; }
        public List<ProductVm> LastestProducts { get; set; }
    }
}
