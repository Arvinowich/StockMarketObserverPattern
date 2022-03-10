using System;
namespace StockMarketApp.Data
{
    public class SubjectData
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Ticker { get; set; }

        public SubjectData(double price, string name, string ticker)
        { 
            Price = price;
            Name = name;
            Ticker = ticker;
        }
    }
}

