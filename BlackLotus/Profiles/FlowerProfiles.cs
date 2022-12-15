using AutoMapper;
using BlackLotus.Data;
using BlackLotus.Model;

namespace BlackLotus.Profiles
{
    public class FlowerProfile : Profile
    {
        public FlowerProfile()
        {
            CreateMap<Flower, FlowerReadDTO>();
            CreateMap<FlowerCreateDTO, Flower>();
        }

    }
}