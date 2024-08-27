using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HotelBookingSystem_Abp.Bases;
using HotelBookingSystem_Abp.Rooms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelBookingSystem_Abp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomAppService _roomAppService;

        public RoomController(IRoomAppService roomAppService)
        {
            _roomAppService = roomAppService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoomAsync([FromBody] RoomInputDto input)
        {
            var result = await _roomAppService.CreateRoomAsync(input);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteRoomAsync(Guid id)
        {
            var success = await _roomAppService.DeleteRoomAsync(id);
            if (success)
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetRoomAsync(Guid id)
        {
            var result = await _roomAppService.GetRoomAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetListAsync([FromQuery] BaseListModelDto input)
        {
            var result = await _roomAppService.GetListAsync(input);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRoomAsync([FromBody] RoomInputDto input)
        {
            var result = await _roomAppService.UpdateRoomAsync(input);
            return Ok(result);
        }
    }
}