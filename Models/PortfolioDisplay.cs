using System;
namespace StockMarketApp.Models
{
    public class PortfolioDisplay
    {
        Portfolio portfolio;

        public PortfolioDisplay(Portfolio portfolio_)
        {
            portfolio = portfolio_;
        }

        public void PrintPortfolio()
        {
            Console.WriteLine($"The Portfolio: {portfolio.PortfolioName} Contains following stocks: ");
            foreach (var item in portfolio.stonks)
            {
                Console.WriteLine($"Name: {item.Name}: Ticker: {item.Ticker}: Price: ${item.Price}: ");   
            }
        }
    }
}

