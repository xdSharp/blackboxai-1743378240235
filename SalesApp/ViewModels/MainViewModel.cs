using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SalesApp.Models;

namespace SalesApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Sale> _sales = new();

    [ObservableProperty]
    private Sale _newSale = new();

    [RelayCommand]
    private void AddSale()
    {
        if (string.IsNullOrWhiteSpace(NewSale.ProductName) || NewSale.Amount <= 0)
            return;

        Sales.Add(new Sale(NewSale.ProductName, NewSale.Amount));
        NewSale = new Sale();
    }

    public decimal TotalSales => Sales.Sum(s => s.Amount);
    public string TopProduct => Sales
        .GroupBy(s => s.ProductName)
        .OrderByDescending(g => g.Count())
        .FirstOrDefault()?.Key ?? "Нет данных";
}