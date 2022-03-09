using System;
using StockMarketApp.Models;

namespace StockMarketApp.Interfaces
{
    public interface IStocks
    {
        public void Attach(IPortfolio portfolio);
        public void Detach(IPortfolio portfolio);
        public void Notify();
    }
}

