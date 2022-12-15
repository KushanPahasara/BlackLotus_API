using BlackLotus.Model;

namespace BlackLotus.Data
{
    public interface IStockRepo
    {
        bool Save();
        IEnumerable<Stock> GetStock();
        Stock GetStockById(int stockId);
        void createStock(Stock stock);

        void delete(Stock stock);

        bool update(Stock stock);
    }
}
