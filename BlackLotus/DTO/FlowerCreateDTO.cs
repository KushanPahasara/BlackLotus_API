using System.ComponentModel.DataAnnotations;

namespace BlackLotus.Data
{
    public class FlowerCreateDTO
    {
        [Required]
        public string flowerName { get; set; }
        [Required]
        public decimal flowerPrice { get; set; }
        [Required]
        public int stock { get; set; }
        [Required]
        public string Catagory { get; set; }
    }
}
