using System;
using System.ComponentModel.DataAnnotations;

namespace Ar.Model.ViewModels
{
    public class EmploymentVM
    {
        [Required]
        [Display(Name = "Employment Type")]
        public string EmploymentType { get; set; }
        [Required]
        public string Employer { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        [Display(Name = "Gross Monthly Income")]
        public double GrossMonthlyIncome { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }
    }
}