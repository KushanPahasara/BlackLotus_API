using BlackLotus.Model;

namespace BlackLotus.Data
{
    public class StockRepo : IStockRepo
    {
        private AppDBContex context;

        public StockRepo(AppDBContex dBContext)
        {
            context = dBContext;
        }
        public void createStock(Stock stock)
        {
            if (stock == null)
            {
                throw new NotImplementedException(nameof(stock));
            }
            context.stock.Add(stock);
        }

        public void delete(Stock stock)
        {
            context.stock.Remove(stock);
            Save();
        }

        public IEnumerable<Stock> GetStock()
        {
           return context.stock.ToList();
        }

        public Stock GetStockById(int stockId)
        {
            return context.stock.FirstOrDefault(s => s.stockId == stockId);
        }

        public bool Save()
        {

            int count = context.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool update(Stock stock)
        {
            context.stock.Update(stock);
            return Save();
        }
    }
}
