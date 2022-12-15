using AutoMapper;
using BlackLotus.DTO;
using BlackLotus.Model;

namespace BlackLotus.Profiles
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderReadDTO>();
            CreateMap<OrderCreateDTO, Order>();

        }

    }
}
