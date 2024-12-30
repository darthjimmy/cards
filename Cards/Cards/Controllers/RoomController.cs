using EjSmith.Cards.Classes;
using EjSmith.Cards.Services;
using Microsoft.AspNetCore.Mvc;

namespace EjSmith.Cards.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController(IRoomService roomService) : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Room>> Get()
        {
            return await roomService.GetAllRooms();
        }

        [HttpPost]
        public async Task<Room> CreateRoom()
        {
            return await roomService.CreateRoom();
        }
    }
}
