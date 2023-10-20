using NewVehicleList.Models;
using NewVehicleList.Services;

namespace NewVehicleList_TestProject01.UnitTests;

public class VehicleService_Should
{
    [Fact]
    public void AddVehicle_Should_AddOneVehicleToList_AndReturnTrue()
    {
        // Arrenge
        VehicleService vehicleService = new VehicleService();
        Vehicles vehicle = new Vehicles
        {
            // Act
            VehicleRegnr = "VAS37U",
            Vehicle = "Bil",
            VehicleBrand = "Volvo",
            VehicleModel = "V70",
            VehicleYear = "1997",
            VehicleColor = "Red"
        };

        bool result = vehicleService.AddVehicle(vehicle);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void GetAllVehicles_Should_GetAListOfVehicles_ReturnOneVehicle()
    {
        // Arrenge
        VehicleService vehicleService = new VehicleService();
        Vehicles vehicle = new Vehicles
        {
            VehicleRegnr = "VAS37U",
            Vehicle = "Bil",
            VehicleBrand = "Volvo",
            VehicleModel = "V70",
            VehicleYear = "1997",
            VehicleColor = "Red"
        };

        vehicleService.AddVehicle(vehicle);

        // Act
        IEnumerable<Vehicles> result = vehicleService.GetAllVehicles();

        // Assert
        Assert.NotNull(result);
        Assert.Single(result);
    }
}
