using AutoMapper;
using BlackLotus.Data;
using BlackLotus.DTO;
using BlackLotus.Model;

namespace BlackLotus.Profiles
{
    public class StockProfile : Profile
    {
        public StockProfile()
        {
            CreateMap<Stock, StockReadDTO >();
            CreateMap<StockCreateDTO, Stock>();
        }

    }
}
