using System.ComponentModel.DataAnnotations.Schema;

namespace RingaWEB.Entities.ProductPkg
{
    public class Property
    {
        public int PropertyId { get; set; }
        public int ProductId { get; set; }
        public string PropertyCode { get; set; }
        public string PropertyDetail { get; set; }
        public int PropertySort { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}
