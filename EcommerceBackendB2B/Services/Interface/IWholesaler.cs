using EcommerceBackendB2B.DTOs.WholesalerDtos;

namespace EcommerceBackendB2B.Services.Interface
{
    public interface IWholesaler
    {
        Task<wholesalerDto> CreateWholesaler(wholesalerDto wholesalerDto);
        Task<List<wholesalerDto>> GetAllWholesaler();
        Task<wholesalerDto> GetWholesalerById(int id);
        Task<wholesalerDto> DeleteWholesaler(int id);
    }
}
