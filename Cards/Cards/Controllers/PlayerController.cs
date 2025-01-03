using EjSmith.Cards.Classes;
using EjSmith.Cards.Services;
using Microsoft.AspNetCore.Mvc;

namespace EjSmith.Cards.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController(IPlayerService playerService) : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Player>> GetPlayers()
        {
            return await playerService.GetPlayers();
        }

        [HttpGet("{playerId}")]
        public async Task<Player> GetPlayer(string playerId)
        {
            return await playerService.GetPlayer(playerId);
        }

        [HttpPost]
        public async Task<Player> CreatePlayer([FromBody] Player player)
        {
            return await playerService.CreatePlayer(player);
        }

        [HttpPut]
        public async Task<Player> UpdatePlayer([FromBody] Player player)
        {
            return await playerService.UpdatePlayer(player);
        }

        [HttpDelete("{playerId}")]
        public void DeletePlayer(string playerId)
        {
            playerService.DeletePlayer(playerId);
        }
    }
}
