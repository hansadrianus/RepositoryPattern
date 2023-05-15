using Application.Endpoints.PhysicalInventoryDocuments.Commands;
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
    public class PhysialInventoryDocumentProfileMapper : Profile
    {
        public PhysialInventoryDocumentProfileMapper()
        {
            CreateMap<PhysicalInventoryDocumentHeader, PhysicalInventoryDocumentViewModel>()
                .ReverseMap();
            CreateMap<PhysicalInventoryDocumentDetail, PhysicalInventoryDocumentViewModel.PhysicalInventoryDocumentDetailViewModel>()
                .ReverseMap();
            CreateMap<DraftPhysicalInventoryDocumentCommand, PhysicalInventoryDocumentHeader>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.DocumentNo, opt => opt.Ignore())
                .ForMember(dest => dest.DocumentDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.IsDraft, opt => opt.MapFrom(src => true))
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
            CreateMap<PostPhysicalInventoryDocumentCommand, PhysicalInventoryDocumentHeader>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.DocumentNo, opt => opt.Ignore())
                .ForMember(dest => dest.DocumentDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.PostingDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.IsDraft, opt => opt.MapFrom(src => false))
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
            CreateMap<UpdateDraftPhysicalInventoryDocumentCommand, PhysicalInventoryDocumentHeader>()
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
            CreateMap<PhysicalInventoryDocumentDetailCommand, PhysicalInventoryDocumentDetail>()
                .ForMember(dest => dest.Product, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedTime, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.ModifiedTime, opt => opt.Ignore())
                .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
        }
    }
}
