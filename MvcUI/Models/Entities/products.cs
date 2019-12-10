namespace MvcUI.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
