using System;
using System.ComponentModel.DataAnnotations;

namespace Garage_2._0.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string VehicleType { get; set; }
        public string RegNumber { get; set; }

        public string? Color { get; set; } 
        public string? Brand { get; set; } 
        public string? Model { get; set; }

        public int NumWheels { get; set; }
        public DateTime ParkingStart { get; set; }
        public DateTime? ParkingEnd { get; set; }
        public static List<string> AvailableVehicleTypes { get; } = new List<string>
        {
            "Car", "Bus", "Boat", "Airplane", "Motorcycle"
        };
    }
}
