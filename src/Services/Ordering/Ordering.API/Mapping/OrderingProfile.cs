using AutoMapper;
using EventBus.Messages.Event;
using Ordering.Application.Features.Orders.Commands.CheckOutOrder;

namespace Ordering.API.Mapping
{
    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            CreateMap<CheckoutOrderCommand, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
