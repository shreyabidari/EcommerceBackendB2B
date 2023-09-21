using AutoMapper;
using EcommerceBackendB2B.DTOs.WholesalerDtos;
using EcommerceBackendB2B.Models;
using EcommerceBackendB2B.Repostiory.Interface;
using EcommerceBackendB2B.Services.Interface;

namespace EcommerceBackendB2B.Services.Implementation
{
    public class WholesalerServices : IWholesaler
    {
        readonly IUnitofWork uow;
        readonly IMapper _mapper;

        public WholesalerServices(IUnitofWork _uow, IMapper mapper)
        {
            uow = _uow;
            _mapper = mapper;
        }
        public async Task<List<wholesalerDto>> GetAllWholesaler()
        {
            try
            {
                var Wholesaler = await uow.Repository<Wholesaler>().GetAllAsync();
                var WholesalerDto = _mapper.Map<List<wholesalerDto>>(Wholesaler);
                return WholesalerDto;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while getting the About Us.", ex);
            }


        }
        public async Task<wholesalerDto> CreateWholesaler(wholesalerDto WholesalerDto)
        {
            try
            {
                var WholesalerEntity = _mapper.Map<Wholesaler>(WholesalerDto);

                uow.Repository<Wholesaler>().AddAsync(WholesalerEntity);
                await uow.SaveChangesAsync();

                var createdWholesalerDto = _mapper.Map<wholesalerDto>(WholesalerEntity);
                return createdWholesalerDto;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the Admin.", ex);
            }
        }
        public async Task<wholesalerDto> GetWholesalerById(int id)
        {
            try
            {
                var WholesalerEntity = await uow.Repository<Wholesaler>().GetByIdAsync(id);
                var WholesalerDto = _mapper.Map<wholesalerDto>(WholesalerEntity);
                return WholesalerDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while getting the Admin with ID {id}.", ex);
            }
        }
        public async Task<wholesalerDto> DeleteWholesaler(int id)
        {
            try
            {
                var WholesareEntity = await uow.Repository<Wholesaler>().GetByIdAsync(id);

                if (WholesareEntity == null)
                {
                    throw new Exception($"Admin with ID {id} not found.");
                }

                await uow.Repository<Wholesaler>().DeleteAsync(WholesareEntity);
                await uow.SaveChangesAsync();

                var WholesalerDto = _mapper.Map<wholesalerDto>(WholesareEntity);
                return WholesalerDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while deleting the Admin with ID {id}.", ex);
            }
        }
    }

   
}
