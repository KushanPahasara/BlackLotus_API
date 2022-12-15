using BlackLotus.Model;

namespace BlackLotus.Data
{
    public class OrderRepo : IOrderRepo
    {
        private AppDBContex contex;

        public OrderRepo(AppDBContex dBContext)
        {
            contex = dBContext;
        }

        public void createOrder(Order order)
        {
          if(order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }
          contex.order.Add(order);
        }

        public void deleteOrder(Order order)
        {
                contex.order.Remove(order);
                Save();   
        }

        public Order GetOrderById(int orderId)
        {
            return contex.order.FirstOrDefault(o => o.orderId == orderId);
           
        }

        public IEnumerable<Order> GetOrders()
        {
          
            return contex.order.ToList();
        }

        public bool Save()
        {
            int count = contex.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool updateOrder(Order order)
        {
            contex.order.Update(order);
            return Save();
        }
    }
}
