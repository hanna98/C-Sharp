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

        var json = JsonConvert.SerializeObject(_vehicles);
        await FileService.SaveToFileAsync(json);
    }

    public IEnumerable<IVehicles> GetAllVehicles()
    {
        _vehicles.Clear();
        var content = FileService.ReadFromFile();
        if (!string.IsNullOrEmpty(content))
        {
            foreach (var vehicle in JsonConvert.DeserializeObject<List<Vehicles>>(content)!)
                _vehicles.Add(vehicle);
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

        SendToJson();
    }

    public async void SendToJson()
    {
        var json = JsonConvert.SerializeObject(_vehicles);
        await FileService.SaveToFileAsync(json);
    }
}
