﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RingaWEB.Entities.ProductPkg
{
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }
        public string ProductPropertyName { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public double? SellPrice { get; set; }
        public int? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public ProductDetail? ParentProductDetail { get; set; }

    }
}
