using System.ComponentModel.DataAnnotations.Schema;

namespace RingaWEB.Entities.VoucherPkg
{
    public class Voucher
    {
        public int VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public int VoucherStatusId { get; set; }
        [ForeignKey("VoucherStatusId")]
        public VoucherStatus VoucherStatus { get; set; }
        public string VoucherDetail { get; set; }
        public int VoucherTypeId { get; set; }
        [ForeignKey("VoucherTypeId")]
        public VoucherType VoucherType { get; set; }
        public DateTime CreateDateTime { get; set; }
        public double? VoucherValue { get; set; }
        public double? MaximunValue { get; set; }
        public double? MinimunTotalBillAccept { get; set; }
        public bool IsPercentValue { get; set; }
    }
}
