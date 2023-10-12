using _02VehicleList_Console.Modles;

namespace _02VehicleList_Console.Services;

public class MenuService
{
    private static readonly VehiclesService vehicleService = new VehiclesService();

    public static void VehicleMainMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("1. Lägg till nya fordon");
            //Console.WriteLine("2. Ta bort fordon");
            Console.WriteLine("3. Visa alla fordon");
            //Console.WriteLine("4. Visa ett fordon");
            Console.WriteLine("0. Avsluta programmet");
            Console.Write("Välj något av följande alternativ: ");
            var option = Console.ReadLine();

            Console.Clear();

            switch (option)
            {
                case "1":
                    AddVehicleList();
                    break;

                //case "2":
                //    RemoveVehicleList();
                //    break;

                case "3":
                    ShowAllVehicleList();
                    break;

                //case "4":
                //    ShowOneVehicleList();
                //    break;

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

        vehicleService.AddToList(vehicle);
    }

    public static void ShowAllVehicleList()
    {
        vehicleService.GetVehicles();
    }
}
