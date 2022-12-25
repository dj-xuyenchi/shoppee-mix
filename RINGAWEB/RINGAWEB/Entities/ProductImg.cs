using System.ComponentModel.DataAnnotations.Schema;

namespace RINGAWEB.Entities
{
    public class ProductImg
    {
        public int ProductImgId { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public bool IsProductAvatar { get; set; }
        public byte[] ProductImgData { get; set; }
    }
}
