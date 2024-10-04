using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TestTabbedApp.ViewModels;

public partial class RootTabsViewModel : ObservableObject
{
    public RootTabsViewModel()
    {
    }

    [ObservableProperty]
    private int _counter = 0;

    [RelayCommand]
    private Task IncreaseCounter()
    {
        Counter++;

        return Task.CompletedTask;
    }

    [RelayCommand]
    private Task DecreaseCounter()
    {
        Counter--;

        return Task.CompletedTask;
    }

    [RelayCommand]
    private async Task GoBack()
    {
        if (Counter > 0)
            await Shell.Current.GoToAsync("//MainPage", true);
    }
}