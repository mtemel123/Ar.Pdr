using System.ComponentModel.DataAnnotations;

namespace Ar.Model.ViewModels
{
    public class ProductsVM
    {
        [Required]
        public double Liability { get; set; }
        [Required]
        [Display(Name = "Road Side Assistance")]
        public bool RoadSideAssistance { get; set; }
        [Required]
        [Display(Name = "Property Damage")]
        public double PropertyDamage { get; set; }
        [Required]
        public double Collision { get; set; }
        [Required]
        public double Comprehensive { get; set; }
        [Required]
        public bool Rental { get; set; }
        [Required]
        [Display(Name = "Loan Payoff")]
        public bool LoanPayoff { get; set; }
        [Required]
        [Display(Name = "Driver Rewards")]
        public bool DriverRewards { get; set; }
    }
}