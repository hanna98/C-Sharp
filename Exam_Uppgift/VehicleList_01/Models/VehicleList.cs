namespace VehicleList_01.Models;

public class VehicleList
{
    public DateTime Created { get; set; } = DateTime.Now;
    public string VehicleId { get; }
    public string Vehicle { get; set; } = null!;
    public string VehicleModel { get; set; } = null!;
    public string VehicleYear { get; set; } = null!;
    public string VehicleColor { get; set; } = null!;
}
