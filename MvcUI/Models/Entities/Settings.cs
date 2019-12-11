namespace MvcUI.Models.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Settings
    {
        public int id { get; set; }

        [StringLength(250)]
        public string title { get; set; }

        [StringLength(150)]
        public string logo { get; set; }

        [StringLength(250)]
        public string description { get; set; }

        [StringLength(250)]
        public string keywords { get; set; }

        [StringLength(250)]
        public string favicon { get; set; }

        [StringLength(250)]
        public string copyright { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        [StringLength(250)]
        public string mailsendfrom { get; set; }

        [StringLength(250)]
        public string mailserver { get; set; }

        [StringLength(250)]
        public string mailport { get; set; }

        [StringLength(250)]
        public string mailuser { get; set; }

        [StringLength(250)]
        public string mailpass { get; set; }
        
        public bool prices_isactive { get; set; }
    }
}
