namespace VehicleList_ConsoleApp.Interfaces
{
    public interface IVehicles
    {
        DateTime Created { get; }
        string? Vehicle { get; set; }
        string? VehicleBrand { get; set; }
        string? VehicleColor { get; set; }
        string? VehicleModel { get; set; }
        string? VehicleRegnr { get; set; }
        string? VehicleYear { get; set; }
        public string? FullVehicle { get; }
    }
}