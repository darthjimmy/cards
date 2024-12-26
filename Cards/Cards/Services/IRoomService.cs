﻿using EjSmith.Cards.Classes;

namespace EjSmith.Cards.Services
{
    public interface IRoomService
    {
        /// <summary>
        /// Creates a room.
        /// </summary>
        /// <returns>The room id.</returns>
        public Task<string> CreateRoom();

        /// <summary>
        /// Adds player <paramref name="player"/> to the given room <paramref name="roomId"/>.
        /// </summary>
        /// <param name="roomId">The room id.</param>
        /// <param name="player">The player to add to the room.</param>
        public Task AddPlayerToRoom(string roomId, Player player);

        /// <summary>
        /// Gets player from room <paramref name="roomId"/>.
        /// </summary>
        /// <param name="roomId">The room id to retrieve.</param>
        /// <returns>The requested room.</returns>
        public Task<Room> GetRoom(string roomId);
    }
}
