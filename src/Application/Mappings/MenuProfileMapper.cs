using Application.Endpoints.Auths.Queries;
using Application.Endpoints.Menus.Queries;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class MenuProfileMapper : Profile
    {
        public MenuProfileMapper()
        {
            CreateMap<AppMenu, MenuViewModel>()
                .ForMember(dest => dest.RowStatus, opt => opt.MapFrom(src => (src.RowStatus == 0) ? 1 : 0))
                .ReverseMap();
            CreateMap<GetMenuQuery, GetMenuQuery>()
                .ForMember(dest => dest.RowStatus, opt => opt.MapFrom(src => (src.RowStatus == 0) ? 1 : 0));
        }
    }
}
