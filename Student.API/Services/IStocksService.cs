using Student.API.Dto;

namespace Student.API.Services
{
    public interface IStocksService
    {
        List<Models.Stocks> GetAllStocks();
        Models.Stocks GetStockById(int id);
        Models.Stocks AddStock(PostStocksDto stock);
        Models.Stocks UpdateStock(PutStocksDto stockData, int id);
        void DeleteStock(int id);
    }
}
