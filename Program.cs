using System;
using StockMarketApp;
using StockMarketApp.Data;
using StockMarketApp.Interfaces;
using StockMarketApp.Models;


public class Program
{
    public static void Main(string[] args)
    {
        //TODO
        SubjectData sub1 = new SubjectData(420, "GOOGLE", "GOOG");
        SubjectData sub2 = new SubjectData(69, "APPLE", "AAPL");
        SubjectData sub3 = new SubjectData(42069, "FACEBOOK", "META");

        Stock google = new Stock(sub1);
        Stock apple = new Stock(sub2);
        Stock facebook = new Stock(sub3);

        Portfolio noob = new Portfolio("Nordnet", sub3);

        Portfolio med = new Portfolio("Saxobank", sub1);

        google.Attach(noob);
        apple.Attach(noob);

    

        google.Notify(sub1);

        apple.Notify(sub2);

        PortfolioDisplay noobDisplay = new PortfolioDisplay(noob);

        noobDisplay.PrintPortfolio();

        Console.WriteLine("Start a Portfolio - Insert portfolio name: ");
        string userInputtedPortfolioName = Console.ReadLine();

        while (true)
        {
            int i = 0;



            Console.WriteLine("Now insert your first stock, use enter to seperate the follwing: Stock name, Stock Ticker, Stock Price: ");
            string userInputtedStockName = Console.ReadLine();
            string userInputtedStockTicker = Console.ReadLine();
            int userInputtedStocPrice = Convert.ToInt32(Console.ReadLine());

            SubjectData sub = new SubjectData(userInputtedStocPrice, userInputtedStockName, userInputtedStockTicker);
            Stock stock = new Stock(sub);

            string portname = "port" + i.ToString();
            Portfolio portfolio = new Portfolio(userInputtedPortfolioName, sub);


            PortfolioDisplay portfolioDisplay = new PortfolioDisplay(portfolio);
            portfolioDisplay.PrintPortfolio();

            Console.WriteLine("Now update your first stock, use enter to seperate the follwing: Stock name, Stock Ticker, Stock Price: ");
            string userInputtedStockNameUPDATE = Console.ReadLine();
            string userInputtedStockTickerUPDATE = Console.ReadLine();
            int userInputtedStocPriceUPDATE = Convert.ToInt32(Console.ReadLine());

            SubjectData sub9 = new SubjectData(userInputtedStocPriceUPDATE, userInputtedStockNameUPDATE, userInputtedStockTickerUPDATE);
            Stock stock1 = new Stock(sub9);
            stock1.Attach(portfolio);

            stock1.Notify(sub9);

            portfolioDisplay.PrintPortfolio();

        }


    
    }
}