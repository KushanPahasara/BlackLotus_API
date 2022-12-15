using BlackLotus.Model;

namespace BlackLotus.Data
{
    public interface IOrderRepo
    {
        bool Save();
        IEnumerable<Order> GetOrders();
        void deleteOrder (Order order); 
        void createOrder(Order order);
        bool updateOrder(Order order);
        Order GetOrderById(int orderId);
    }
}
