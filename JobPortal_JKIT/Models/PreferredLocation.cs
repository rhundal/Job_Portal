using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPortal_JKIT.Models
{
    public class PreferredLocation
    {
        public int PreferedLocationID {get; set; }
        public int UserID {get; set; }
        public int CityID {get; set; } 
        public int StateID {get; set; }


    }
}