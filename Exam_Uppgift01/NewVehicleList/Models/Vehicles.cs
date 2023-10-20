namespace NewVehicleList.Models;

public class Vehicles
{
    public DateTime Created { get; } = DateTime.Now;
    public string? VehicleRegnr { get; set; }
    public string? Vehicle { get; set; }
    public string? VehicleBrand { get; set; }
    public string? VehicleModel { get; set; }
    public string? VehicleYear { get; set; }
    public string? VehicleColor { get; set; }
    public string? FullVehicle => $"{Created} {VehicleRegnr!.ToUpper()} {Vehicle} {VehicleBrand} {VehicleModel} {VehicleYear} {VehicleColor}";
}
