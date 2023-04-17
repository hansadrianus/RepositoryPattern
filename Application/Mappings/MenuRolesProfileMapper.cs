using Application.Endpoints.Auths.Queries;
using Application.Endpoints.Menus.Commands;
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
    public class MenuRolesProfileMapper : Profile
    {
        public MenuRolesProfileMapper()
        {
            CreateMap<AppMenuRole, MenuRoleViewModel>()
                .ReverseMap();
            CreateMap<MenuRolesCommand, AppMenuRole>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
            CreateMap<GetMenuRolesQuery, GetRoleQuery>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.RoleId))
                .ForMember(dest => dest.Name, opt => opt.Ignore());
            CreateMap<GetMenuRolesQuery, GetMenuQuery>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AppMenuId))
                .ForMember(dest => dest.MenuName, opt => opt.MapFrom(src => src.MenuName));
        }
    }
}
