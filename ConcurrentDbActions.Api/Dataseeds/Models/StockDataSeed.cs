using System.Collections.Generic;
using ConcurrentDbActions.Domain.Models;

namespace ConcurrentDbActions.Api.Dataseeds.Models
{
    public static class StockDataSeed
    {
        public static ICollection<Stock> Data()
        {
            return new Stock[]
            {
                new Stock(1, 1, 1, 20, true),
                new Stock(2, 1, 1, 8, true),
                new Stock(3, 1, 1, 0, true),

                new Stock(4, 1, 2, 3, true),
                new Stock(5, 1, 2, 1, true),
                new Stock(6, 1, 1, 4, true),

                new Stock(7, 1, 1, 12, true),
            };
        }
    }
}
