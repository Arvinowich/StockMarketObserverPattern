using System;
using StockMarketApp.Data;
using StockMarketApp.Interfaces;

namespace StockMarketApp.Models
{
    public class Stock : IStocks
    {
        List<IPortfolio> portfolios = new List<IPortfolio>();
        public SubjectData stockData;

        public Stock(SubjectData stockdata)
        {
            stockData = stockdata;
            
            //Evt tre parametre i ctor og så:
            //stockData = new SubjectData(para1, para2, para3) 
        }

        public void Attach(IPortfolio portfolio)
        {
            portfolios.Add(portfolio);
        }


        public void Detach(IPortfolio portfolio)
        {
            portfolios.Remove(portfolio);
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }

        public void Notify(SubjectData subjectData)
        {
            foreach (var observer in portfolios)
            {
                observer.Update(subjectData);
            }
        }

        public void SetData(SubjectData stockdata)
        {
            stockData = stockdata;
        }
    }
}

