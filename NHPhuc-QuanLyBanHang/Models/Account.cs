using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NHPhuc_QuanLyBanHang.Models
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }
        public bool Status { get; set; }
    }
}