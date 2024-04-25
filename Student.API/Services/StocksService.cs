using Student.API.Dto;
using Student.API.Models;

namespace Student.API.Services
{
    public class StocksService : IStocksService
    {
        private AppDbContext _context;
        public StocksService(AppDbContext context)
        {
            _context = context;
        }
        public Stocks AddStock(PostStocksDto stock)
        {
            var newStock = new Models.Stocks()
            {
                FullName = stock.FullName,
                Symbol = stock.Symbol,
                Price = stock.Price
            };

            _context.Stocks.Add(newStock);
            _context.SaveChanges();

            return newStock;
        }

        public void DeleteStock(int id)
        {
            var stockDb = _context.Stocks
                .FirstOrDefault(n => n.Id == id);

            _context.Stocks.Remove(stockDb);
            _context.SaveChanges();
        }

        public List<Stocks> GetAllStocks()
        {
            var allStocks = _context.Stocks.ToList();
            return allStocks;
        }

        public Stocks GetStockById(int id)
        {
            var newStock = _context.Stocks
                .FirstOrDefault(n => n.Id == id);

            return newStock;
        }

        public Stocks UpdateStock(PutStocksDto stockData, int id)
        {
            var stockDb = _context.Stocks
                .FirstOrDefault(n => n.Id == id);

            stockDb.Symbol = stockData.Symbol;
            _context.Stocks.Update(stockDb);

            _context.SaveChanges();

            return stockDb;
        }
    }
}
