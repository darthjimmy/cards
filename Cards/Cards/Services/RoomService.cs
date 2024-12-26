using EjSmith.Cards.Classes;
using EjSmith.Cards.Data;
using Microsoft.EntityFrameworkCore;

namespace EjSmith.Cards.Services
{
    public class RoomService(CardGameContext context) : IRoomService
    {
        private readonly CardGameContext _context = context;

        /// <inheritdoc/>
        public async Task AddPlayerToRoom(string roomId, Player player)
        {
            var room = _context.Rooms.Include(r => r.Players).FirstOrDefault(r => r.Id == roomId);

            if (room != null)
            {
                room.Players.Add(player);
                await _context.SaveChangesAsync();
            }
        }

        /// <inheritdoc/>
        public async Task<string> CreateRoom()
        {
            var room = new Room()
            {
                Id = new Guid().ToString()
            };

            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();

            return room.Id;
        }

        /// <inheritdoc/>
        public async Task<Room> GetRoom(string roomId)
        {
            return await _context.Rooms.FirstAsync(r => r.Id == roomId);
        }
    }
}
