using System.ComponentModel.DataAnnotations.Schema;

namespace RINGAWEB.Entities
{
    public class ProductPropertyDetailMap
    {
        public int ProductPropertyDetailMapId { get; set; }
        public int PropertyDetailId { get; set; }
        public int ProductPropertyDetailId { get; set; }
        [ForeignKey("PropertyDetailId")]
        public PropertyDetail PropertyDetail { get; set; }
        [ForeignKey("ProductPropertyDetailId")]
        public ProductPropertyDetail ProductPropertyDetail { get; set; }
    }
}
