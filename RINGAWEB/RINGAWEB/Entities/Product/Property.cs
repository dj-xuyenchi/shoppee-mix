using System.ComponentModel.DataAnnotations.Schema;

namespace RINGAWEB.Entities.Product
{
    public class Property
    {
        public int PropertyId { get; set; }
        public int ProductId { get; set; }
        public string PropertyName { get; set; }
        public int PropertySort { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}
