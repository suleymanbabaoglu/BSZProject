namespace MvcUI.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Stocks
    {
        [Key]
        public int StockID { get; set; }

        [Required]
        [StringLength(50)]
        public string StockBarcode { get; set; }

        public int StockQuantity { get; set; }

        [Required]
        [StringLength(50)]
        public string StockSize { get; set; }
    }
}
