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
    public class RoleProfileMapper : Profile
    {
        public RoleProfileMapper()
        {
            CreateMap<ApplicationRole, RoleViewModel>()
                .ForMember(dest => dest.RowStatus, opt => opt.MapFrom(src => (src.RowStatus == 0) ? 1 : 0))
                .ReverseMap();
            CreateMap<GetRoleQuery, GetRoleQuery>()
                .ForMember(dest => dest.RowStatus, opt => opt.MapFrom(src => (src.RowStatus == 0) ? 1 : 0));
        }
    }
}
