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
    public class UserProfileProfileMapper : Profile
    {
        public UserProfileProfileMapper()
        {
            CreateMap<ApplicationUser, UserProfileViewModel>()
                .ForMember(dest => dest.RowStatus, opt => opt.Ignore())
                .AfterMap((src, dest) =>
                {
                    dest.RowStatus = (short)(src.RowStatus == 0 ? 1 : 0);
                })
                .ReverseMap();
            CreateMap<GetUserProfileQuery, GetUserProfileQuery>()
                .AfterMap((src, dest) =>
                {
                    dest.RowStatus = (short)(src.RowStatus == 0 ? 1 : 0);
                });
        }
    }
}
