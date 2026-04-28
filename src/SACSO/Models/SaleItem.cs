namespace Sacso.Models;

public class SaleItem
{
    public string Category { get; set; } = string.Empty;
    public string Name { get; set; } = "No Name";
    public int Quantity { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal SalesPrice { get; set; }

    public decimal Profit => (SalesPrice - PurchasePrice) * Quantity;
}