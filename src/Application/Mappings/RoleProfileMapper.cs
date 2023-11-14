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
    public class RoleProfileMapper : Profile
    {
        public RoleProfileMapper()
        {
            CreateMap<ApplicationRole, RoleViewModel>()
                .ReverseMap();
            CreateMap<AddRoleCommand, ApplicationRole>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Uid, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.NormalizedName, opt => opt.Ignore())
                .ForMember(dest => dest.ConcurrencyStamp, opt => opt.Ignore())
                .ForMember(dest => dest.MenuRoles, opt => opt.Ignore())
                .ForMember(dest => dest.RowStatus, opt => opt.MapFrom(src => 0))
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
            CreateMap<UpdateRoleCommand, ApplicationRole>()
                .ForMember(dest => dest.NormalizedName, opt => opt.Ignore())
                .ForMember(dest => dest.ConcurrencyStamp, opt => opt.Ignore())
                .ForMember(dest => dest.MenuRoles, opt => opt.Ignore())
                .ForMember(dest => dest.RowStatus, opt => opt.MapFrom(src => 0))
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
        }
    }
}
