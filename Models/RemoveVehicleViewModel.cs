using System.ComponentModel.DataAnnotations;

namespace Garage_2._0.Models
{
    public class RemoveVehicleViewModel
    {
        [Required(ErrorMessage = "Registration number is required.")]
        [RegularExpression(@"^[A-Za-z0-9-]+$", ErrorMessage = "Invalid registration number.")]
        public string RegNumber { get; set; }
    }

}
