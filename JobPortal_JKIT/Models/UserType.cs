using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JobPortal_JKIT.Models
{
    public class UserType
    {
        [Key]
        public int userID { get; set; }  // set primary key , not null 
        [Required]
        public string logName { get; set; }
        public string password { get; set; }
        public string userType { get; set; }
        public int ActiveFlag { get; set; }

    }
}