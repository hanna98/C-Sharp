using Newtonsoft.Json;
using VehicleList_ConsoleApp.Interfaces;

namespace VehicleList_ConsoleApp.Services;

public class VehicleService : IVehicleService
{
    private List<IVehicles> _vehicles = new List<IVehicles>();

    public async Task AddVehicleAsync(IVehicles vehicle)
    {
        _vehicles.Add(vehicle);

        var json = JsonConvert.SerializeObject(_vehicles);
        await FileService.SaveToFileAsync(json);
    }

    public IEnumerable<IVehicles> GetAllVehicles()
    {
        var content = FileService.ReadFromFile();
        if (string.IsNullOrEmpty(content))
            _vehicles = JsonConvert.DeserializeObject<List<IVehicles>>(content)!;

        foreach (var vehicle in _vehicles)
        {
            Console.WriteLine($"{vehicle.FullVehicle}");
        }
        return _vehicles;
    }

    public IVehicles GetOneVehicle(string regnr)
    {
        return _vehicles.FirstOrDefault(x => x.VehicleRegnr == regnr)!;
    }

    public void RemoveVehicle(string regnr)
    {
        var vehicle = GetOneVehicle(regnr);
        _vehicles.Remove(vehicle);
    }
}
