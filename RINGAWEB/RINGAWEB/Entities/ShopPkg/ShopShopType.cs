using System.ComponentModel.DataAnnotations.Schema;

namespace RingaWEB.Entities.ShopPkg
{
    public class ShopShopType
    {
        public int ShopShopTypeId { get; set; }
        public int? ShopId { get; set; }
        [ForeignKey("ShopId")]
        public Shop? Shop { get; set; }
        public int? ShopTypeId { get; set; }
        [ForeignKey("ShopTypeId")]
        public ShopeType ShopType { get; set; }
    }
}
