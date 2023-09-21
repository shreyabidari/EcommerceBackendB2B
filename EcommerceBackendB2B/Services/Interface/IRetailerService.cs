using EcommerceBackendB2B.DTOs;

namespace EcommerceBackendB2B.Services.Interface
{
    public interface IRetailerService
    {
        Task<RetailerDto> CreateRetailer(RetailerDto retailerDto);
        Task<List<RetailerDto>> GetAllRetailer();
        Task<RetailerDto> GetRetailerById(int id);
        Task<RetailerDto> DeleteRetailer(int id);
    }
}

