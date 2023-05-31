using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductCreateRequestDto
    {
        [Display(Name = "Giá")]
        public decimal Price { get; set; }
        [Display(Name = "Giá nhập")]
        public decimal OriginalPrice { get; set; }
        [Display(Name = "Tồn Kho")]
        public int Stock { get; set; }
        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        public string Name { set; get; }
        [Display(Name = "Mô tả")]
        public string Description { set; get; }
        [Display(Name = "Chi tiết")]
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }
        public bool? IsFeatured { get; set; }
        public IFormFile ThumbnailImage { get; set; }
    }
}
