using RingaWEB.Entities.ProductPkg;
using System.ComponentModel.DataAnnotations.Schema;

namespace RingaWEB.Entities.BillPkg
{
    public class BillDetail
    {
        public int BillDetailId { get; set; }
        public int BillId { get; set; }
        public int ProductDetailId { get; set; }
        [ForeignKey("ProductDetailId")]
        public ProductDetail ProductDetail { get; set; }
        public int Quantity { get; set; }
        public double SellPrice { get; set; }


    }
}
