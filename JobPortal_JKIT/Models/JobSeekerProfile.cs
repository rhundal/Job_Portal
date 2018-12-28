using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JobPortal_JKIT.Models
{
    public class JobSeekerProfile
    {
        [Key]
        public int UserID {get; set; }       
        public int JobSeekerID {get; set; }
        public string FirstName {get; set; }
        public string LastName {get; set; }
        public DateTime DOB { get; set; }
        public string Address {get; set; }
        public int CityID {get; set; }
        public int StateID {get; set; }
        public int CountryID {get; set; }
        public int CountryCode {get; set; }
        public int Pincode {get; set; }
        public string Gender {get; set; }
        public int ContactID {get; set; }
        public int TotalExperience {get; set; }
        public string IndustryType {get; set; }
        public string FunctionalArea {get; set; }
        public int CurrentPay {get; set; }
        public int ExpectedPay {get; set; }
        public bool Resume {get; set; }
        public int NoticePeriod {get; set; }
        public string Designation {get; set; }
        public string PreferedLocationID {get; set; }
        public string Relocate {get; set; }
        public DateTime EntryDate { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}