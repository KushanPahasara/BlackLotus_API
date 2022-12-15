using System.ComponentModel.DataAnnotations;

namespace BlackLotus.DTO
{
    public class OrderCreateDTO
    {

        [Required]
        public string flowerName { get; set; }
        [Required]
        public int quantity { get; set; }

        [Required]
        public string customerName { get; set; }
        [Required]
        public String customerPhone { get; set; }
        public String orderedDate { get; set; }
        [Required]
        public String dilevaryDate { get; set; }
        [Required]
        public string orderDetails { get; set; }

        [Required]
        public string place { get; set; }
    }
}
