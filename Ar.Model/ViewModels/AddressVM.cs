using System.ComponentModel.DataAnnotations;

namespace Ar.Model.ViewModels
{
    public class AddressVM
    {
        [Display(Name = "Street Address")]
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public double Zip { get; set; }
        [Required]
        public bool IsMailing { get; set; }
    }
}
