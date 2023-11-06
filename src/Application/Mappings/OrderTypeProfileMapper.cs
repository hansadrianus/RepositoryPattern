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
    public class OrderTypeProfileMapper : Profile
    {
        public OrderTypeProfileMapper()
        {
            CreateMap<OrderType, OrderTypeViewModel>()
                .ReverseMap();
        }
    }
}
