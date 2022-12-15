using System.ComponentModel.DataAnnotations;

namespace BlackLotus.Model
{
    public class Catagory
    {
        [Key]
        [Required]
        public int catagoryId { get; set; }
        [Required]
        public string catagoryName { get; set; }
        [Required]

        public string catagoryDiscription { get; set; }

    }
}
