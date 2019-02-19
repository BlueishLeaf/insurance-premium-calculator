using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace insurance_premium_calculator.ViewModels
{
    public class InsuranceViewModel
    {
        [Required]
        [Display(Name = "Age")]
        public int age { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string gender { get; set; }

        [Display(Name = "Premium")]
        public double premium { get; set; }
    }
}