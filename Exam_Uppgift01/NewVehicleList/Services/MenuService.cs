/*  ToUpper används för att regnr alltid är med stora bokstäver och användren kanske inte álltid skriver med stora bokstäver
    
*/

using NewVehicleList.Models;

namespace NewVehicleList.Services;

public class MenuService
{
    private static readonly VehicleService _vehicleService = new VehicleService();

    public static void MainMenu()
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
                    RemoveVehicleFromList();
                    break;

                case "3":
                    ShowAllVehicles();
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
        Vehicles vehicle = new Vehicles();

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

        Task.Run(() => _vehicleService.AddVehicle(vehicle));
    }

    public static void RemoveVehicleFromList()
    {
        ShowAllVehicles();

        Console.Write("Fordonets regnr: ");
        var regnr = Console.ReadLine()!.ToUpper();

        _vehicleService.RemoveVehicle(regnr!);

        Console.WriteLine($"Du tog bort fordonet med regnr {regnr}");
    }

    public static void ShowAllVehicles()
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
        var regnr = Console.ReadLine()!.ToUpper();

        var vehicle = _vehicleService.GetOneVehicle(regnr!);
        Console.WriteLine(vehicle!.FullVehicle);
        Console.WriteLine();
    }
}
