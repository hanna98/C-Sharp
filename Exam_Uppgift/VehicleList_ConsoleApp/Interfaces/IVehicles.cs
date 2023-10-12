namespace VehicleList_ConsoleApp.Interfaces;

public interface IVehicles
{
    DateTime Created { get; }
    string? Vehicle { get; set; }
    string? VehicleColor { get; set; }
    string? VehicleRegnr { get; set; }
    string? VehicleModel { get; set; }
    string? VehicleYear { get; set; }
    string? FullVehicle { get; }
}