using System.Collections.Generic;
using System.Linq;
using api.Models;

namespace api.Data.Repositories
{
    public class GameRepository 
    {
        private GameContext gameContext;

        public GameRepository()
        {
            gameContext = new GameContext();
        }

        public List<Game> GetGames() 
        {
            return gameContext.Games.ToList();
        }
    }
}