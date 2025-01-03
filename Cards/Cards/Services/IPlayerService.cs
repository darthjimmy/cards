using EjSmith.Cards.Classes;

namespace EjSmith.Cards.Services
{
    public interface IPlayerService
    {
        /// <summary>
        /// Adds the <paramref name="player"/> to the database.
        /// </summary>
        /// <param name="player">The player to add.</param>
        /// <returns>The created player.</returns>
        public Task<Player> CreatePlayer(Player player);

        /// <summary>
        /// Gets a player by <paramref name="playerId"/>.
        /// </summary>
        /// <param name="playerId">The player ID to retrieve.</param>
        /// <returns>The retrieved player.</returns>
        public Task<Player> GetPlayer(string playerId);

        /// <summary>
        /// Gets all players from the database.
        /// </summary>
        /// <returns>And <see cref="IEnumerable{T}"/> containing all players.</returns>
        public Task<IEnumerable<Player>> GetPlayers();

        /// <summary>
        /// Updates the given <paramref name="player"/>.
        /// </summary>
        /// <param name="player">The <see cref="Player"/> info to update.</param>
        /// <returns>The updated <see cref="Player"/> object.</returns>
        public Task<Player> UpdatePlayer(Player player);

        /// <summary>
        /// Removes a player by <paramref name="playerId"/>.
        /// </summary>
        /// <param name="playerId">The ID of the player to remove.</param>
        public void DeletePlayer(string playerId);
    }
}
