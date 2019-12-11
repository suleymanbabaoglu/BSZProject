namespace MvcUI.Models.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Footlinks
    {
        [Key]
        public int LinkID { get; set; }

        [StringLength(50)]
        public string LinkText { get; set; }

        public int? LinkOrder { get; set; }

        [StringLength(250)]
        public string LinkUrl { get; set; }
    }
}
