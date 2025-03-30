namespace SalesApp.Models;

public class Sale
{
    public string ProductName { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    
    public Sale() { }
    
    public Sale(string productName, decimal amount)
    {
        ProductName = productName;
        Amount = amount;
    }
}