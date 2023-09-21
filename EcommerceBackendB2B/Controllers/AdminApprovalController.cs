using EcommerceBackendB2B.Models.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceBackendB2B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = UserRoles.Admin)]
    public class AdminApprovalController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public AdminApprovalController(UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("pending-registrations")]
        public async Task<IActionResult> GetPendingRegistrations()
        {
            // Query and return pending registrations that need admin approval
            var pendingRegistrations = await _userManager.Users.Where(u => u.RequiresApproval).ToListAsync();
            return Ok(pendingRegistrations);
        }

        [HttpPost]
        [Route("approve-registration/{userId}")]
        public async Task<IActionResult> ApproveRegistration(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return NotFound();

            user.RequiresApproval = false; // Update user's approval status
            await _userManager.UpdateAsync(user);

            // Add user to specific roles based on your logic
            await _userManager.AddToRolesAsync(user, new[] { UserRoles.Wholesaler, UserRoles.Retailer });

           

            return Ok(new { Message = "Registration approved." });
        }


        [HttpPost]
        [Route("deny-registration/{userId}")]
        public async Task<IActionResult> DenyRegistration(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return NotFound();

            // You might perform additional actions for denied registration
            await _userManager.DeleteAsync(user);

            

            return Ok(new { Message = "Registration denied and user deleted." });
        }
    }
}
    

