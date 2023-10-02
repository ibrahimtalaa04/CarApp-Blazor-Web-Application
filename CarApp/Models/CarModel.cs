using System.ComponentModel.DataAnnotations;

namespace CarApp.Models
{
    public class CarModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Make is required")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Model is required")]
        public string Model { get; set; }

        [Range(1900, 2100, ErrorMessage = "Year must be between 1900 and 2100")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Color is required")]
        public string Color { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Mileage must be a positive number")]
        public int Mileage { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Fuel Type is required")]
        public string FuelType { get; set; }

        [Required(ErrorMessage = "Transmission is required")]
        public string Transmission { get; set; }

        [Range(0.1, double.MaxValue, ErrorMessage = "Engine Size must be greater than 0")]
        public double EngineSize { get; set; }
    }
}
