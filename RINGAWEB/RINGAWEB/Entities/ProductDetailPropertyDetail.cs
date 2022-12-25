using System.ComponentModel.DataAnnotations.Schema;

namespace RINGAWEB.Entities
{
    public class ProductDetailPropertyDetail
    {
        public int ProductDetailPropertyDetailId { get; set; }
        public int ProductDetailId { get; set; }
        [ForeignKey("ProductDetailId")]
        public ProductDetail ProductDetail { get; set; }
        public int PropertyDetailId { get; set; }
        [ForeignKey("PropertyDetailId")]
        public PropertyDetail PropertyDetail { get; set; }
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

    }
}
