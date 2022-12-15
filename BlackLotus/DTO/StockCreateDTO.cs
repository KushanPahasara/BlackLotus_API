using System.ComponentModel.DataAnnotations;

namespace BlackLotus.DTO
{
    public class StockCreateDTO
    {
        [Required]
        public string flowerName { get; set; }
       
        [Required]
        public int stockQuntity { get; set; }

    }
}
