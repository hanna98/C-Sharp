namespace VehicleList_ConsoleApp.Interfaces;

public interface IVehicleService
{
    Task AddVehicleAsync(IVehicles vehicle);
    IEnumerable<IVehicles> GetAllVehicles();
    IVehicles GetOneVehicle(string regnr);
    void RemoveVehicle(string regnr);
}
