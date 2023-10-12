using _02VehicleList_Console.Modles;
using Newtonsoft.Json;

namespace _02VehicleList_Console.Services;

public class VehiclesService
{
    private List<Vehicles> _vehicleList = new List<Vehicles>();
    
    public void AddToList(Vehicles vehicles)
    {
        _vehicleList.Add(vehicles);

        var json = JsonConvert.SerializeObject(_vehicleList);
        FileService.SaveToFile(json);
    }

    public void GetVehicles()
    {
        var content = FileService.ReadFromFile();
        if (!string.IsNullOrEmpty(content))
            _vehicleList = JsonConvert.DeserializeObject<List<Vehicles>>(content)!;

        foreach (var vehicle in _vehicleList)
        {
            Console.WriteLine($"{vehicle.VehicleRegnr} {vehicle.Vehicle} {vehicle.VehicleBrand}");
        }
    }
}
