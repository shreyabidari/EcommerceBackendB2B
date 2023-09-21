using EcommerceBackendB2B.DTOs.WholesalerDtos;
using EcommerceBackendB2B.Services.Implementation;
using EcommerceBackendB2B.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceBackendB2B.Controllers
{
    public class WholesalerController : Controller
    {

        private readonly IWholesaler _wholesalerServices;

        public WholesalerController(WholesalerServices wholesalerServices)
        {
            _wholesalerServices = wholesalerServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<wholesalerDto>>> GetAllWholesaler()
        {
            var wholesalerDtos = await _wholesalerServices.GetAllWholesaler();
            return Ok(wholesalerDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<wholesalerDto>> GetWholesalerById(int id)
        {
            var WholesalerDto = await _wholesalerServices.GetWholesalerById(id);
            if (WholesalerDto == null)
            {
                return NotFound();
            }
            return Ok(WholesalerDto);
        }

        [HttpPost]
        public async Task<ActionResult<wholesalerDto>> CreateWholesaler(wholesalerDto wholesalerDto)
        {
            var createdWholesalerDto = await _wholesalerServices.CreateWholesaler(wholesalerDto);
            return CreatedAtAction(nameof(GetWholesalerById), new { id = createdWholesalerDto.ID }, createdWholesalerDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<wholesalerDto>> DeleteWholesaler(int id)
        {
            var deletedWholesalerDto = await _wholesalerServices.DeleteWholesaler(id);
            if (deletedWholesalerDto == null)
            {
                return NotFound();
            }
            return Ok(deletedWholesalerDto);
        }

    }
}