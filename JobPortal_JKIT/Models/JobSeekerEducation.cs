using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 
namespace JobPortal_JKIT.Models
{
    public class JobSeekerEducation
    {
        public int JobSeekerEduID {get; set; }
        public int UserID {get; set; }
        public string CollegeName {get; set; }
        public string Branch {get; set; }
        public string Skills {get; set; }
        public int YearofPassing {get; set; }
        public DateTime EntryDate { get; set; }

    }
}