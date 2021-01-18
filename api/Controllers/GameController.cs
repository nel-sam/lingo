using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.Service;
using api.Models.Data_Transfer_Objects;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private GameService gameService;
        private readonly ILogger<GameController> _logger;

        public GameController(ILogger<GameController> logger)
        {
            _logger = logger;
            gameService = new GameService();
        }
     
        [HttpGet]
        public List<GameDto> GetGame()
        {
            _logger.LogInformation("User has requested Board");
           
            return gameService.GetGames();
        }
    }
}
