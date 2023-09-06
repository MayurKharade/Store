using AutoMapper;
using Store.Application.ViewModels;
using Store.Domain.Entities;

namespace Store.Application
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}
