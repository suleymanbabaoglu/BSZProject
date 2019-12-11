namespace MvcUI.Models.Entities
{
    using System.ComponentModel.DataAnnotations;

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
