using System.ComponentModel.DataAnnotations.Schema;

namespace RINGAWEB.Entities
{
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }
        public string ProductPropertyName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double ShellPrice { get; set; }
        public int? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public ProductDetail? ParentProductDetail { get; set; }
    
    }
}
