using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TestTabbedApp.ViewModels;

public partial class DetailsViewModel : ObservableObject
{
    [RelayCommand]
    private static async Task OpenTabedPage()
    {
        await Shell.Current.GoToAsync("//DetailTabs", true);
    }
}