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
                .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.RoleId))
                .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Role.Name))
                .ForMember(dest => dest.IsSelected, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
