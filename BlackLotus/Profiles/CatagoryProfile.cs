using AutoMapper;
using BlackLotus.Data;
using BlackLotus.DTO;
using BlackLotus.Model;

namespace BlackLotus.Profiles
{
    public class CatagoryProfile: Profile
    {
        public CatagoryProfile()
        {
            CreateMap<Catagory, CatagoryReadDTO>();
            CreateMap<CatagoryCreateDTO, Catagory>();
        }

    }
}
