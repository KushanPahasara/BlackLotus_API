using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace BlackLotus.Model
{
    public class Order
    {
        [Key]
        [Required]
        public int orderId { get; set; }
        [Required]
        public string flowerName { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public string customerName { get; set; }
        [Required]
        public string customerPhone { get; set; }
        public String orderedDate { get; set; }
        [Required]
        public String dilevaryDate { get; set; }
        [Required]
        public string orderDetails { get; set; }

        [Required]
        public string place { get; set; }

    }
}
