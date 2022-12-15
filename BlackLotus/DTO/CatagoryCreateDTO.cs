using System.ComponentModel.DataAnnotations;

namespace BlackLotus.DTO
{
    public class CatagoryCreateDTO
    {

        [Required]
        public string catagoryName { get; set; }
        [Required]
        public string catagoryDiscription { get; set; }
    }
}
