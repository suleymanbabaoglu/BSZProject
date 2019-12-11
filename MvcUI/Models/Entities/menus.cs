namespace MvcUI.Models.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Menus
    {
        [Key]
        public int MenuID { get; set; }

        [StringLength(15)]
        public string MenuName { get; set; }

        public int? MenuOrder { get; set; }

        [StringLength(250)]
        public string MenuUrl { get; set; }

        public int? MenuParentID { get; set; }
    }
}
