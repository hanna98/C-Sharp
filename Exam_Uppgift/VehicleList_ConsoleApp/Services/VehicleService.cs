using Newtonsoft.Json;
using VehicleList_ConsoleApp.Interfaces;
using VehicleList_ConsoleApp.Models;

namespace VehicleList_ConsoleApp.Services;

public class VehicleService : IVehicleService
{
    private List<IVehicles> _vehicles = new List<IVehicles>();

    public async Task AddVehicleAsync(IVehicles vehicle)
    {
        _vehicles.Add(vehicle);

        await FileServices.SaveToFileAsync(_vehicles);
    }

    public IEnumerable<IVehicles> GetAllVehicles()
    {
        var content = FileServices.ReadFromFile();
        if (!string.IsNullOrEmpty(content))
        {
            List<IVehicles> vehicles = JsonConvert.DeserializeObject<List<IVehicles>>(content)!;
            foreach (var vehicle in vehicles!)
            {
                Console.WriteLine($"{vehicle.FullVehicle}");
            }
            return vehicles;
        }
        return Enumerable.Empty<IVehicles>(); // Returnera en tom sekvens om det inte finns något att deserialisera.
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
