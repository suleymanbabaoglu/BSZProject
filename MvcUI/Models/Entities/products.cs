namespace MvcUI.Models.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Products
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(250)]
        public string ProductBrand { get; set; }

        [StringLength(200)]
        public string ProductText { get; set; }

        [StringLength(200)]
        public string ProductBarcode { get; set; }

        [StringLength(250)]
        public string ProductInfo { get; set; }

        [StringLength(250)]
        public string ProductImage1 { get; set; }

        [StringLength(250)]
        public string ProductImage2 { get; set; }

        [StringLength(250)]
        public string ProductImage3 { get; set; }

        [StringLength(250)]
        public string ProductImage4 { get; set; }
    }
}
