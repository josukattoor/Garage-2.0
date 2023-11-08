
    using System;
    using System.ComponentModel.DataAnnotations;
namespace Garage_2._0.Models.NewFolder
{
    public class ParkingStartTimeInFutureAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime parkingStartTime)
            {
                if (parkingStartTime <= DateTime.Now)
                {
                    return new ValidationResult("Parking start time must be in the future.");
                }
            }
            return ValidationResult.Success;
        }
    }

}
