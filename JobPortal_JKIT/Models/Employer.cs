using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JobPortal_JKIT.Models
{
    public class Employer
    {
        [Key]
        public int EmployerID { get; set; }
        public int UserID { get; set;  }

        /// <summary>
        public string MobileNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        public string ConfirmPassword { get; set; }
        public DateTime EntryDate { get; set; }

        public int RoleID { get; set; }
    }
}