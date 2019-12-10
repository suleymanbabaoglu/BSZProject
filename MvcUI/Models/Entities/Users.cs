using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcUI.Models.Entities
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Alanı Zorunludur !")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string UserName{ get; set; }

        [Required(ErrorMessage = "Parola Alanı Zorunludur !")]
        [DataType(DataType.Password)]
        [StringLength(250)]
        public string Password { get; set; }

        [StringLength(100)]
        [DataType(DataType.Text)]
        public string RealName { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [StringLength(250)]
        public string Email { get; set; }
        
        public bool RememberMe { get; set; }
    }
}