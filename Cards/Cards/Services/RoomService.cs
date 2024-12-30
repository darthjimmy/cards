using EjSmith.Cards.Classes;
using EjSmith.Cards.Data;
using Microsoft.EntityFrameworkCore;

namespace EjSmith.Cards.Services
{
    public class RoomService(CardGameContext context) : IRoomService
    {
        private readonly CardGameContext _context = context;

        public async Task AddPlayerToRoom(string roomId, Player player)
        {
            var room = _context.Rooms.Include(r => r.Players).FirstOrDefault(r => r.Id == roomId);

            if (room != null)
            {
                room.Players.Add(player);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Room> CreateRoom()
        {
            var id = Guid.NewGuid();
            var idString = id.ToString();

            var room = new Room()
            {
                Id = idString,
                Name = $"Room {idString.Substring(idString.Length - 6)}"
            };

            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();

            return room;
        }

        public async Task<Room> GetRoom(string roomId)
        {
            return await _context.Rooms.FirstAsync(r => r.Id == roomId);
        }

        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            return await _context.Rooms.ToListAsync();
        }
    }
}
