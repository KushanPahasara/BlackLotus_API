using System.ComponentModel.DataAnnotations;

namespace BlackLotus.Data
{
    public class FlowerReadDTO
    {
        public int flowerId { get; set; }
        public string flowerName { get; set; }
        
        public decimal flowerPrice { get; set; }
        
        public int stock { get; set; }
        
        public string Catagory { get; set; }
    }
}
