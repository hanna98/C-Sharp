using VehicleList_ConsoleApp.Interfaces;
using VehicleList_ConsoleApp.Models;

namespace VehicleList_ConsoleApp.Services;

public class MenuService
{
    private static readonly IVehicleService _vehicleService = new VehicleService();

    public static void VehicleMainMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("1. Lägg till nya fordon");
            Console.WriteLine("2. Ta bort fordon");
            Console.WriteLine("3. Visa alla fordon");
            Console.WriteLine("4. Visa ett fordon");
            Console.WriteLine("0. Avsluta programmet");
            Console.Write("Välj något av följande alternativ: ");
            var option = Console.ReadLine();

            Console.Clear();

            switch (option)
            {
                case "1":
                    AddVehicleList();
                    break;
                case "2":
                    RemoveVehicleList();
                    break;
                case "3":
                    ShowAllVehicleList();
                    break;
                case "4":
                    ShowOneVehicleList();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
            }

            Console.ReadKey();

        } while (true);
    }

    public static void AddVehicleList()
    {
        IVehicles vehicle = new Vehicles();

        Console.Write("Fordonets regnr: ");
        vehicle.VehicleRegnr = Console.ReadLine()!.ToUpper();
        Console.Write("Fordon: ");
        vehicle.Vehicle = Console.ReadLine();
        Console.Write("Fordonets märke: ");
        vehicle.VehicleBrand = Console.ReadLine();
        Console.Write("Fordonets model: ");
        vehicle.VehicleModel = Console.ReadLine();
        Console.Write("Fordonnets årsmodell: ");
        vehicle.VehicleYear = Console.ReadLine();
        Console.Write("Fordonets färg: ");
        vehicle.VehicleColor = Console.ReadLine();

        Task.Run(() => _vehicleService.AddVehicleAsync(vehicle));
    }

    public static void RemoveVehicleList()
    {
        Console.Write("Fordonets regnr: ");
        var regnr = Console.ReadLine();

        _vehicleService.RemoveVehicle(regnr!);
    }

    public static void ShowAllVehicleList()
    {
        foreach (var vehicle in _vehicleService.GetAllVehicles())
        {
            Console.WriteLine(vehicle!.FullVehicle);
            Console.WriteLine();
        }
    }

    public static void ShowOneVehicleList() 
    {
        Console.Write("Fordonets regnr: ");
        var regnr = Console.ReadLine();

        var vehicle = _vehicleService.GetOneVehicle(regnr!);

        Console.WriteLine(vehicle!.FullVehicle);
        Console.WriteLine();
    }
}
