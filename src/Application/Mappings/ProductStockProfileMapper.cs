using Application.Endpoints.Inventories.Commands;
using Application.Endpoints.Products.Commands;
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
    public class ProductStockProfileMapper : Profile
    {
        public ProductStockProfileMapper()
        {
            CreateMap<Product, ProductStockViewModel>()
                .ReverseMap();
            CreateMap<UpdateProductStockCommand, Product>()
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
        }
    }
}
