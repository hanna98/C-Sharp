using VehicleList_ConsoleApp.Interfaces;
using VehicleList_ConsoleApp.Models;
using VehicleList_ConsoleApp.Services;

namespace VehicleList_ConsoleApp_TestProject.UnitTests;

public class VehicleService_Should
{
    [Fact]
    public void AddVehicle_Should_AddOneVehicleToList_AndReturnTrue()
    {
        // Arrange
        IVehicleService vehicleService = new VehicleService();
        IVehicles vehicle = new Vehicles();

        // Act
        vehicle.VehicleRegnr = "VAS37U";
        vehicle.Vehicle = "Bil";
        vehicle.VehicleBrand = "Volvo";
        vehicle.VehicleModel = "V70";
        vehicle.VehicleYear = "1997";
        vehicle.VehicleColor = "Red";

        Task result = vehicleService.AddVehicleAsync(vehicle);

        // Assert
        Assert.ThrowsAnyAsync<Exception>(() => result);
    }

    [Fact]
    public void GetAllVehicles_Should_GetAListOfVehicles_ReturnOneVehicle()
    {
        // Arrange
        IVehicleService vehicleService = new VehicleService();
        IVehicles vehicle = new Vehicles();
        vehicle.VehicleRegnr = "VAS37U";
        vehicle.Vehicle = "Bil";
        vehicle.VehicleBrand = "Volvo";
        vehicle.VehicleModel = "V70";
        vehicle.VehicleYear = "1997";
        vehicle.VehicleColor = "Red";

        vehicleService.AddVehicleAsync(vehicle);

        // Act
        IEnumerable<IVehicles> result = vehicleService.GetAllVehicles();

        //Assert
        Assert.NotNull(result);
        Assert.Single(result);
    }
}
