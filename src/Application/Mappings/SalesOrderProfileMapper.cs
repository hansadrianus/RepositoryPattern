using Application.Endpoints.SalesOrders.Commands;
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
    public class SalesOrderProfileMapper : Profile
    {
        public SalesOrderProfileMapper()
        {
            CreateMap<SalesOrderHeader, SalesOrderViewModel>()
                .ReverseMap();
            CreateMap<SalesOrderDetail, SalesOrderViewModel.OrderDetailViewModel>()
                .ReverseMap();
            CreateMap<DraftSalesOrderCommand, SalesOrderHeader>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Uid, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.OrderNumber, opt => opt.Ignore())
                .ForMember(dest => dest.OrderDate, opt => opt.Ignore())
                .ForMember(dest => dest.IsDraft, opt => opt.MapFrom(src => true))
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
            CreateMap<PostSalesOrderCommand, SalesOrderHeader>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Uid, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.OrderNumber, opt => opt.Ignore())
                .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.IsDraft, opt => opt.MapFrom(src => false))
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
            //.AfterMap((src, dest) =>
            //{
            //    dest.SalesOrderDetails = new List<SalesOrderDetail>();
            //    foreach (var srcItem in src.OrderDetails)
            //    {
            //        SalesOrderDetail orderDetail = new SalesOrderDetail()
            //        {
            //            ProductId = srcItem.ProductId,
            //            Price = srcItem.Price,
            //            Quantity = srcItem.Quantity,
            //            DeliveryDate = srcItem.DeliveryDate,
            //            Notes = srcItem.Notes
            //        };
            //        dest.SalesOrderDetails.Add(orderDetail);
            //    }
            //});
            CreateMap<UpdatePostSalesOrderCommand, SalesOrderHeader>()
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
            CreateMap<UpdateDraftSalesOrderCommand, SalesOrderHeader>()
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
                //.AfterMap((src, dest) =>
                //{
                //    dest.SalesOrderDetails = new List<SalesOrderDetail>();
                //    foreach (var srcItem in src.OrderDetails)
                //    {
                //        SalesOrderDetail orderDetail = new SalesOrderDetail()
                //        {
                //            OrderId = (int)src.Id,
                //            ProductId = srcItem.ProductId,
                //            Price = srcItem.Price,
                //            Quantity = srcItem.Quantity,
                //            DeliveryDate = srcItem.DeliveryDate,
                //            Notes = srcItem.Notes
                //        };
                //        dest.SalesOrderDetails.Add(orderDetail);
                //    }
                //});
            CreateMap<DeleteSalesOrderCommand, SalesOrderHeader>()
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
            CreateMap<OrderDetailCommand, SalesOrderDetail>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Uid, opt => opt.Ignore())
                .ForMember(dest => dest.Product, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
        }
    }
}
