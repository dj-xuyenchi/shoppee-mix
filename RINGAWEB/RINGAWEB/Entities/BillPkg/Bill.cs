using RingaWEB.Entities.VoucherPkg;
using System.ComponentModel.DataAnnotations.Schema;

namespace RingaWEB.Entities.BillPkg
{
    public class Bill
    {
        public int BillId { get; set; }
        public string BillCode { get; set; }
        public int? BillStatusId { get; set; }
        public BillStatus? BillStatus { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public DateTime? CloseDateTime { get; set; }
        public double? TotalBillBeforeVoucher { get; set; }
        public double? TotalBillAfterVoucher { get; set; }
        public double? ShipPrice { get; set; }
        public int? StarPoint { get; set; }
        public double? TotalBillAfterEverything { get; set; }
        public int? VoucherBillId { get; set; }
        [ForeignKey("VoucherBillId")]
        public Voucher? VoucherBill { get; set; }
        public int? VoucherShipId { get; set; }
        [ForeignKey("VoucherShipId")]
        public Voucher? VoucherShip { get; set; }
        public int? BuyMethodId { get; set; }
        [ForeignKey("BuyMethodId")]
        public BuyMethod? BuyMethod { get; set; }
        public int? ShipMethodId { get; set; }
        [ForeignKey("ShipMethodId")]
        public ShipMethod? ShipMethod { get; set; }

    }
}
