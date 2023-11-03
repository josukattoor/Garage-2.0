namespace Garage_2._0.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

        public class Vehicle
        {
            public int Id { get; set; }

            [Required(ErrorMessage = "Vehicle type is required.")]
            public string VehicleType { get; set; }

        [Required(ErrorMessage = "Registration number is required.")]
        [RegularExpression(@"^[A-Za-z0-9-]+$", ErrorMessage = "Invalid registration number.")]

        public string RegNumber { get; set; }

            [Required(ErrorMessage = "Color is required.")]
            public string Color { get; set; }

            [Required(ErrorMessage = "Brand is required.")]
            public string Brand { get; set; }

            [Required(ErrorMessage = "Model is required.")]
            public string Model { get; set; }

            [Required(ErrorMessage = "Number of wheels is required.")]
            [Range(0, int.MaxValue, ErrorMessage = "Number of wheels must be a non-negative number.")]
            public int NumWheels { get; set; }

            public DateTime ParkingStart { get; set; }

            public DateTime ParkingEnd { get; set; }



    }
}
