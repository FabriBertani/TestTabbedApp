using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TestTabbedApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    private static async Task OpenDetailsPage()
    {
        await Shell.Current.GoToAsync("///Details", true);
    }
}