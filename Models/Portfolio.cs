using System;
using StockMarketApp.Data;
using StockMarketApp.Interfaces;

namespace StockMarketApp.Models
{
    public class Portfolio : IPortfolio
    {
        public List<SubjectData> stonks = new List<SubjectData>();
        public string PortfolioName;
        public Portfolio(string name, SubjectData sub)
        {
            PortfolioName = name;
            stonks.Add(sub);
        }

        public void Update(SubjectData subjectData)
        {
            var itemsToAdd = new List<SubjectData>();

            foreach (var stonk in stonks)
            {
                if (stonk.Name != subjectData.Name)
                {
                    itemsToAdd.Add(subjectData);
                    
                }
                else
                {
                    stonk.Price = subjectData.Price;
                }
            }
            stonks.AddRange(itemsToAdd);
        }
    }
}

