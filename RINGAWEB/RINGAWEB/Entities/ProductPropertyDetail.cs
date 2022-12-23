using System.ComponentModel.DataAnnotations.Schema;

namespace RINGAWEB.Entities
{
    public class ProductPropertyDetail
    {
        public int ProductPropertyDetailId { get; set; }
        public string ProductPropertyDetailName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double ShellPrice { get; set; }
    
    }
}
