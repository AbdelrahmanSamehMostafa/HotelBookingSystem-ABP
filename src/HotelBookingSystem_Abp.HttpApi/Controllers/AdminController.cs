using System;
using System.Threading.Tasks;
using HotelBookingSystem_Abp.Admins;
using HotelBookingSystem_Abp.Bases;
using Microsoft.AspNetCore.Mvc;


namespace HotelBookingSystem_Abp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminAppService _adminAppService;

        public AdminController(IAdminAppService adminAppService)
        {
            _adminAppService = adminAppService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdminAsync([FromBody] AdminInputDto input)
        {
            var result = await _adminAppService.CreateAdminAsync(input);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteAdminAsync(Guid id)
        {
            var success = await _adminAppService.DeleteAdminAsync(id);
            if (success)
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAdminAsync(Guid id)
        {
            var result = await _adminAppService.GetAdminAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetListAsync([FromQuery] BaseListModelDto input)
        {
            var result = await _adminAppService.GetListAsync(input);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAdminAsync([FromBody] AdminInputDto input)
        {
            var result = await _adminAppService.UpdateAdminAsync(input);
            return Ok(result);
        }
    }
}
