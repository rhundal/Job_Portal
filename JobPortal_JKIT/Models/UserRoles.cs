using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JobPortal_JKIT.Models
{
  public class UserRoles
    {
        public int userID { get; set; }   // foreign key
        public int RoleID { get; set; }   // foreign key
    }
}
