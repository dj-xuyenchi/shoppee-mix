using System.ComponentModel.DataAnnotations.Schema;

namespace RINGAWEB.Entities.Product
{
    public class PropertyDetail
    {
        public int PropertyDetailId { get; set; }
        public int PropertyId { get; set; }
        public string PropertyDetailCode { get; set; }
        public string PropertyDetailDetail { get; set; }
        [ForeignKey("PropertyId")]
        public Property Property { get; set; }
        public int? ProductImgId { get; set; }
        public ProductImg? ProductImg { get; set; }

    }
}
