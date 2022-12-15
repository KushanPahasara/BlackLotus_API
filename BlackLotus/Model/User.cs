using System.ComponentModel.DataAnnotations;

namespace BlackLotus.Model
{
    public class User
    {
        [Key]
        [Required]
        public int userId { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string loginName { get; set; }
        [Required]
        public string loginPassword { get; set; }
    }
}
