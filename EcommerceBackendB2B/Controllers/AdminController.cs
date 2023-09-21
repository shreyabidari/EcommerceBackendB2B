using EcommerceBackendB2B.DTOs;
using EcommerceBackendB2B.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceBackendB2B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminServices _adminServices;

        public AdminController(IAdminServices adminServices)
        {
            _adminServices = adminServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<AdminDto>>> GetAllAdmin()
        {
            var adminDtos = await _adminServices.GetAllAdmin();
            return Ok(adminDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AdminDto>> GetAdminById(int id)
        {
            var adminDto = await _adminServices.GetAdminById(id);
            if (adminDto == null)
            {
                return NotFound();
            }
            return Ok(adminDto);
        }

        [HttpPost]
        public async Task<ActionResult<AdminDto>> CreateAdmin(AdminDto adminDto)
        {
            var createdAdminDto = await _adminServices.CreateAdmin(adminDto);
            return CreatedAtAction(nameof(GetAdminById), new { id = createdAdminDto.ID }, createdAdminDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AdminDto>> DeleteAdmin(int id)
        {
            var deletedAdminDto = await _adminServices.DeleteAdmin(id);
            if (deletedAdminDto == null)
            {
                return NotFound();
            }
            return Ok(deletedAdminDto);
        }
    }
}
