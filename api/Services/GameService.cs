using System.Collections.Generic;
using api.Data.Repositories;
using api.Models.Data_Transfer_Objects;
using System.Linq;

namespace api.Service 
{
    public class GameService
    {
        private GameRepository gameRepository;

        public GameService()
        {
            gameRepository = new GameRepository();
        }

        public List<GameDto> GetGames()
        {
            return gameRepository.GetGames()
                .Select(g => new GameDto
                {
                    Key = g.Key,
                    Players = g.Players
                }).ToList();
        }
    }
}