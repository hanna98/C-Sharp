using System.Collections.ObjectModel;
using VehicleList_01.Models;

namespace VehicleList_01;

public partial class MainPage : ContentPage
{
    ObservableCollection<VehicleList> Vehicles = new ObservableCollection<VehicleList>();

    
    public MainPage()
    {
        InitializeComponent();
        CollectionViewVehicleList.ItemsSource = Vehicles;
    }

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        Vehicles.Add(new VehicleList { Vehicle = VehicleList_Vehicle.Text });
        VehicleList_Vehicle.Text = string.Empty;
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var vehicleList = button.BindingContext as VehicleList;

        Vehicles.Remove(vehicleList);
    }

    
}