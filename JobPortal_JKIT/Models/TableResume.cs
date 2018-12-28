using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPortal_JKIT.Models
{
    public class TableResume
    {
        public int ResumeID {get; set; }
        public string EmailID  {get; set; }
        public string ResumeName {get; set; }
        public string Job { get; set;  }

    }
}