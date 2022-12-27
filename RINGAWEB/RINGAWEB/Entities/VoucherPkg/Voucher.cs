namespace RingaWEB.Entities.VoucherPkg
{
    public class Voucher
    {
        public int VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public string VoucherDetail { get; set; }
        public int VoucherTypeId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public double? VoucherValue { get; set; }
    }
}
