using System;
using System.Collections.Generic;
using Sacso.Models;

namespace Sacso;
class Program
{
    static void Main ()
    {
        List<SaleItem> report = new List<SaleItem>
        {
            new SaleItem { Category = "МАСЛО МОТОРНОЕ", Name = "ROWE RSI 5W-40 4L", Quantity = 2, PurchasePrice = 3600, SalesPrice = 4650 },
            new SaleItem { Category = "МАСЛО МОТОРНОЕ", Name = "ЛУКОИЛ GENESIS CN 5W-40 4L", Quantity = 3, PurchasePrice = 1630, SalesPrice = 2100 },
            new SaleItem { Category = "ФИЛЬТР МАСЛЯНЫЙ", Name = "W811/80", Quantity = 1, PurchasePrice = 360, SalesPrice = 550 }
        };

        Console.WriteLine("ОТЧЕТ ИЗ 1С");
        Console.WriteLine("---------------------------------------------------------------------");

        foreach ( var item in report)
        {
            Console.WriteLine($"{ item.Category}  { item.Name}: { item.Quantity} шт. | Прибыль: {item.Profit} руб. ");
        
        }           
    }
}


