using System.ComponentModel.DataAnnotations;

namespace BlackLotus.DTO
{
    public class UserCreateDTO
    {
        
        [Required]
        public string userName { get; set; }
        [Required]
        public string loginName { get; set; }
        [Required]
        public string loginPassword { get; set; }
    }
}
