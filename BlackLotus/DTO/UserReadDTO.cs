using System.ComponentModel.DataAnnotations;

namespace BlackLotus.DTO
{
    public class UserReadDTO
    {
        
        public int userId { get; set; }
       
        public string userName { get; set; }
        
        public string loginName { get; set; }
       
        public string loginPassword { get; set; }
    }
}
