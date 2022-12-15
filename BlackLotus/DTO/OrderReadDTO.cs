using System.ComponentModel.DataAnnotations;

namespace BlackLotus.DTO
{
    public class OrderReadDTO
    {
        public int orderId { get; set; }

        public string flowerName { get; set; }
        
        public int quantity { get; set; }

        public string customerName { get; set; }
     
        public String customerPhone { get; set; }
        public String orderedDate { get; set; }
        
        public String dilevaryDate { get; set; }

        public string orderDetails { get; set; }

        public string place { get; set; }
    }
}
