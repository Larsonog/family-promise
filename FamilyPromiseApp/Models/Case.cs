using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FamilyPromiseApp.Data;
namespace FamilyPromiseApp.Models
{
    public enum Employment
{
    [Display(Name = "Full Time")]
    FullTime,
    [Display(Name = "Part Time")]
    PartTime,
    Unemployed,
    Retired,
    Disabled,
    Student,
    Other
}

    public class Case
    {
        public int ID { get; set; }
        [Display(Name = "Referral taken by:")]
        public string TakenBy { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime Date { get; set;}

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        [Display(Name = "Referring Agency / Source:")]
        public string ReferringAgency { get; set;}

        [Display(Name = "Current Living Situation")]
        public string CurrentSituation { get; set; }

        [Display(Name = "Housing Situation")]
        public string IsHoused { get; set; }
        [Display(Name = "Employment Status")]
        
        public string income { get; set; }
        public string IsEmployed { get; set; }

        [Display(Name = "Transportation Method")]
        public string TransportMethod { get; set; }

        [Display(Name = "Substance Issues")]
        public string Substance { get; set; }

        [Display(Name = "Health Challenges")]
        public string HealthChallenge { get; set; }

        [Display(Name = "Domestic Violence")]
        public string DomesticViolenceHistory { get; set;}

        // public Person Person { get; set; }

    }
}