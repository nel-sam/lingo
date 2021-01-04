using System.Collections.Generic;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
      
        private readonly ILogger<GameController> _logger;

        public GameController(ILogger<GameController> logger)
        {
            _logger = logger;
        }
     
        [HttpGet]
        public Game GetGame()
        {
            _logger.LogInformation("User has requested Board");
           
            return null;
        }
    }
}
