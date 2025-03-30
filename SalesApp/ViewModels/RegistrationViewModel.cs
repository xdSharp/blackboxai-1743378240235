using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SalesApp.Views;

namespace SalesApp.ViewModels;

public partial class RegistrationViewModel : ObservableObject
{
    [ObservableProperty]
    private string _username;
    
    [ObservableProperty]
    private string _email;
    
    [ObservableProperty]
    private string _password;
    
    [RelayCommand]
    private async Task Register()
    {
        if (string.IsNullOrWhiteSpace(Username) || 
            string.IsNullOrWhiteSpace(Email) ||
            string.IsNullOrWhiteSpace(Password))
        {
            await Shell.Current.DisplayAlert("Ошибка", "Заполните все поля", "OK");
            return;
        }
        
        await Shell.Current.DisplayAlert("Успешно", "Регистрация завершена", "OK");
        await Shell.Current.GoToAsync($"//{nameof(LoginView)}");
    }
}