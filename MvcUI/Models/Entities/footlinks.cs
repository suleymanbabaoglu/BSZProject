namespace MvcUI.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
