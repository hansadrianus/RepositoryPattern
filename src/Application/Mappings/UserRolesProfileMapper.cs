using Application.Endpoints.Auths.Commands;
using Application.Endpoints.Auths.Queries;
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
    public class UserRolesProfileMapper : Profile
    {
        public UserRolesProfileMapper()
        {
            CreateMap<ApplicationUserRole, UserRolesViewModel>()
                .ForMember(dest => dest.RoleName, opt => opt.Ignore())
                .ForMember(dest => dest.IsSelected, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<UserRolesCommand, ApplicationUserRole>()
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
            CreateMap<GetUserRolesQuery, GetRoleQuery>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.RoleId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.RoleName));
        }
    }
}
