using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SalesApp.Models;
using SalesApp.Views;

namespace SalesApp.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    private string _username;
    
    [ObservableProperty] 
    private string _password;
    
    [RelayCommand]
    private async Task Login()
    {
        if (string.IsNullOrWhiteSpace(Username) || 
            string.IsNullOrWhiteSpace(Password))
        {
            await Shell.Current.DisplayAlert("Ошибка", "Введите логин и пароль", "OK");
            return;
        }
        
        // Простая проверка (в реальном приложении нужно хранить хеши паролей)
        if (Username == "admin" && Password == "admin")
        {
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
        else
        {
            await Shell.Current.DisplayAlert("Ошибка", "Неверный логин или пароль", "OK");
        }
    }
}