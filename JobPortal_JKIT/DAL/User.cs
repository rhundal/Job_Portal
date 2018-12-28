using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JobPortal_JKIT.DAL
{
    public class User
    {
        public string Email { get; set; }
        public string Roles { get; set; }
        public string Password { get; set; }
    }
}