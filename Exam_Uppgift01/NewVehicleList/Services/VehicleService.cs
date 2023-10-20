using Newtonsoft.Json;
using NewVehicleList.Models;
using System.Diagnostics;

namespace NewVehicleList.Services;

public class VehicleService
{
    private List<Vehicles> _vehicles = new List<Vehicles>();

    public bool AddVehicle(Vehicles vehicles)
    {
        try
        {
            _vehicles.Add(vehicles);
            SendToJson();
            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }

        return false;
    }

    public IEnumerable<Vehicles> GetAllVehicles()
    {
        _vehicles.Clear();
        var content = FileService.ReadFromFile();
        if (!string.IsNullOrEmpty(content))
        {
            _vehicles = JsonConvert.DeserializeObject<List<Vehicles>>(content)!;
        }

        return _vehicles;
    }

    public Vehicles GetOneVehicle(string regnr)
    {
        try
        {
            return _vehicles.FirstOrDefault(x => x.VehicleRegnr == regnr)!;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public void RemoveVehicle(string regnr)
    {
        var vehicle = GetOneVehicle(regnr);
        _vehicles.Remove(vehicle);

        SendToJson(); 
    }
    public void SendToJson()
    {
        var json = JsonConvert.SerializeObject(_vehicles);
        FileService.SaveToFile(json);
    }
}
