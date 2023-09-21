using EcommerceBackendB2B.DTOs;

namespace EcommerceBackendB2B.Services.Interface
{
    public interface IAdminServices
    {
        Task<AdminDto> CreateAdmin(AdminDto adminDto);
        Task<List<AdminDto>> GetAllAdmin();
        Task<AdminDto> GetAdminById(int id);
        Task<AdminDto> DeleteAdmin(int id);
    }
}
