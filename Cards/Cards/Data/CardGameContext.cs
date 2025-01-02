using EjSmith.Cards.Classes;
using Microsoft.EntityFrameworkCore;

namespace EjSmith.Cards.Data
{
    public class CardGameContext(IConfiguration configuration) : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Room> Rooms { get; set; }

        private readonly IConfiguration _configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
