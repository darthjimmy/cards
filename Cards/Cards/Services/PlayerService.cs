using EjSmith.Cards.Classes;
using EjSmith.Cards.Data;
using Microsoft.EntityFrameworkCore;

namespace EjSmith.Cards.Services
{
    public class PlayerService(CardGameContext context) : IPlayerService
    {
        private readonly CardGameContext _context = context;
        public async Task<Player> CreatePlayer(Player player)
        {
            var id = Guid.NewGuid();

            var playerInsert = new Player
            {
                Id = id.ToString(),
                Name = player.Name,
            };

            await _context.Players.AddAsync(playerInsert);
            await _context.SaveChangesAsync();

            return playerInsert;
        }

        public void DeletePlayer(string playerId)
        {
            var player = _context.Players.FirstOrDefault(p => p.Id == playerId);

            if (player != null)
            {
                _context.Players.Remove(player);
            }
        }

        public async Task<Player> GetPlayer(string playerId)
        {
            return await _context.Players.FirstAsync(p => p.Id == playerId);
        }

        public async Task<Player> UpdatePlayer(Player player)
        {
            var playerUpdate = await _context.Players.FirstOrDefaultAsync(p => p.Id == player.Id) ?? throw new Exception("PlayerNotFound");
            playerUpdate.Name = player.Name;

            await _context.SaveChangesAsync();

            return playerUpdate;
        }
    }
}
