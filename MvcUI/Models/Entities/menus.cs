namespace MvcUI.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
