
using System.ComponentModel.DataAnnotations;

namespace BlackLotus.Model
{
    public class Flower
    {
        [Key]
        [Required]
        public int flowerId { get; set; }
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
