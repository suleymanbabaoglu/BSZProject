namespace MvcUI.Models.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Sliders
    {
        [Key]
        public int SliderID { get; set; }

        public bool SliderIsActive { get; set; }

        [StringLength(50)]
        public string SliderText1 { get; set; }

        [StringLength(50)]
        public string SliderText2 { get; set; }

        [StringLength(250)]
        public string SliderInformation { get; set; }

        public int? SliderOrder { get; set; }

        [StringLength(250)]
        public string SliderBackground { get; set; }

        [StringLength(250)]
        public string SliderLink1 { get; set; }

        [StringLength(250)]
        public string SliderLink2 { get; set; }

        [StringLength(50)]
        public string SliderLinkText1 { get; set; }

        [StringLength(50)]
        public string SliderLinkText2 { get; set; }

        public double? SliderPrice { get; set; }

        [StringLength(50)]
        public string SliderCurrency { get; set; }
    }
}
