using AutoMapper;
using EcommerceBackendB2B.DTOs;
using EcommerceBackendB2B.DTOs.WholesalerDtos;
using EcommerceBackendB2B.Models;

namespace EcommerceBackendB2B.Conifgs
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            #region Users
            CreateMap<Admin, AdminDto>()
            .ReverseMap();
            CreateMap<Retailer, RetailerDto>().ReverseMap();

            #endregion
            CreateMap<ApprovalRequest, ApprovalRequestDto>().ReverseMap();
            CreateMap<Banning, BanningDto>().ReverseMap();
            CreateMap<Cart, CartDto>().ReverseMap();
            CreateMap<CartCheckout, CartCheckoutDto>().ReverseMap();
            CreateMap<CartProductDetails, CartProductDetailsDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Commission, CommissionDto>().ReverseMap();
            CreateMap<PaymentMethod, PaymentMethodDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Sales, SalesDto>().ReverseMap();
            CreateMap<SalesProductDetails, SalesProductDetailsDto>().ReverseMap();
            CreateMap<SalesReturn, SalesReturnDto>().ReverseMap();
            CreateMap<SalesReturnDetails, SalesReturnDetailsDto>().ReverseMap();
            CreateMap<Wholesaler, WholesalerandWholesalerInfoDTo>().ReverseMap();
            CreateMap<Wholesaler, WholesalerDto>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ReverseMap();
            /*CreateMap<CreateWholesalerDto, Wholesaler>()
                .Fo*/
                /*.Name, opt => opt.MapFrom(src => src.Name))
                .ForPath(dest => dest.ComplainerInfo.Email, opt => opt.MapFrom(src => src.Email))
                .ForPath(dest => dest.ComplainerInfo.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForPath(dest => dest.ComplainerInfo.Address, opt => opt.MapFrom(src => src.Address));
*/
               



        }

    }
}
