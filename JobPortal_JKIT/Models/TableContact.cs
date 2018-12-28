using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace JobPortal_JKIT.Models
{
    public class TableContact
    {
        public int ContactID {get; set; }
        public string EmailID {get; set; }
        public int TelephoneNo {get; set; }
        public int MobileNo { get; set;  }

    }
}