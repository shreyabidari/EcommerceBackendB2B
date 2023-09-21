using AutoMapper;
using EcommerceBackendB2B.DTOs;
using EcommerceBackendB2B.Models;
using EcommerceBackendB2B.Repostiory.Implementation;
using EcommerceBackendB2B.Repostiory.Interface;
using EcommerceBackendB2B.Services.Interface;

namespace EcommerceBackendB2B.Services.Implementation
{
    public class AdminServices : IAdminServices
    {
        readonly IUnitofWork uow;
        readonly IMapper _mapper;
        public AdminServices(IUnitofWork _uow, IMapper mapper)
        {
            uow = _uow;
            _mapper = mapper;
        }
        public async Task<List<AdminDto>> GetAllAdmin()
        {
            try
            {
                var Admin = await uow.Repository<Admin>().GetAllAsync();
                var AdminDto = _mapper.Map<List<AdminDto>>(Admin);
                return AdminDto;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while getting the About Us.", ex); 
            }


        }
        public async Task<AdminDto> GetAdminById(int id)
        {
            try
            {
                var adminEntity = await uow.Repository<Admin>().GetByIdAsync(id);
                var adminDto = _mapper.Map<AdminDto>(adminEntity);
                return adminDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while getting the Admin with ID {id}.", ex);
            }
        }
        public async Task<AdminDto> DeleteAdmin(int id)
        {
            try
            {
                var adminEntity = await uow.Repository<Admin>().GetByIdAsync(id);

                if (adminEntity == null)
                {
                    throw new Exception($"Admin with ID {id} not found.");
                }

                await uow.Repository<Admin>().DeleteAsync(adminEntity);
                await uow.SaveChangesAsync();

                var adminDto = _mapper.Map<AdminDto>(adminEntity);
                return adminDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while deleting the Admin with ID {id}.", ex);
            }
        }
        public async Task<AdminDto> CreateAdmin(AdminDto adminDto)
        {
            try
            {
                var adminEntity = _mapper.Map<Admin>(adminDto);

                uow.Repository<Admin>().AddAsync(adminEntity);
                await uow.SaveChangesAsync();

                var createdAdminDto = _mapper.Map<AdminDto>(adminEntity);
                return createdAdminDto;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the Admin.", ex);
            }
        }
    }
}
  
