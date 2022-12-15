using System.ComponentModel.DataAnnotations;

namespace BlackLotus.Model
{
    public class Stock
    {
        [Key]
        [Required]
        public int stockId { get; set; }
        [Required]
        public string flowerName { get; set; }
        
        [Required]
        public int stockQuntity { get; set; }


    }
}
