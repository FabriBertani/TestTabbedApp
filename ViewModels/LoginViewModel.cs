using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TestTabbedApp.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    private string _username = string.Empty;

    [RelayCommand]
    private async Task Login()
    {
        if (!string.IsNullOrWhiteSpace(Username))
            await Shell.Current.GoToAsync("//MainPage", true);
    }
}