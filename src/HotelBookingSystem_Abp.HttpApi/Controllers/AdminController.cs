using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using HotelBookingSystem_Abp.Admins;
using HotelBookingSystem_Abp.Bases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Volo.Abp.AspNetCore.Mvc.ApplicationConfigurations;
using Volo.Abp.DependencyInjection;

namespace HotelBookingSystem_Abp.Controllers
{
    //[Dependency(ReplaceServices = true)]
    
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
        public async Task<IActionResult> CreateAsync([FromBody] AdminInputDto input)
        {
            var result = await _adminAppService.CreateAdminAsync(input);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
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
        public async Task<IActionResult> GetAsync(Guid id)
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
        public async Task<IActionResult> UpdateAsync([FromBody] AdminInputDto input)
        {
            var result = await _adminAppService.UpdateAdminAsync(input);
            return Ok(result);
        }
    }
}
