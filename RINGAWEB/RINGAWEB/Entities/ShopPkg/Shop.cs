using Microsoft.AspNetCore.Mvc.ModelBinding;
using RingaWEB.Entities.AccountPkg;
using System.ComponentModel.DataAnnotations.Schema;

namespace RingaWEB.Entities.ShopPkg
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string ShopCode { get; set; }
        public int AccountOwnerId { get; set; }
        [ForeignKey("AccountOwnerId")]
        public Account AccountOwner { get; set; }
        public string ShopName { get; set; }
        public int? ShopeStatusId { get; set; }
        [ForeignKey("ShopStatusId")]
        public ShopStatus? ShopStatus { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }




    }
}
