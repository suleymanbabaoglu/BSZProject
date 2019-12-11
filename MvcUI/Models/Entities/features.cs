namespace MvcUI.Models.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Features
    {
        [Key]
        public int FeatureID { get; set; }

        [StringLength(100)]
        public string FeatureText { get; set; }

        [StringLength(100)]
        public string FeatureImage { get; set; }

        [StringLength(100)]
        public string FeatureUrl { get; set; }

        public int? FeatureOrder { get; set; }
    }
}
