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
            var game = new Game() 
            {
                Players = new List<Player>()
            };

            game.Players.Add(new Player()
            {
                FirstName = "Bayron",
                LastName = "Pineda",
                Key = Guid.Parse("14943241-3721-4abf-8977-36290b04e7ec"),
                Board = new Board()
            });

            game.Players[0].Board.Cells = new List<Cell>()
            {
                new Cell() { Id = Guid.Parse("14943241-3721-4abf-8977-36290b0437ec"), Url = "https://media.nature.com/lw800/magazine-assets/d41586-020-01430-5/d41586-020-01430-5_17977552.jpg"},
                new Cell() { Id = Guid.Parse("44777ac2-8f97-4f97-9f33-95c245151fb3"), Url = "https://blog.consumerguide.com/wp-content/uploads/sites/2/2018/04/Honda-N-Box.png"},
                new Cell() { Id = Guid.Parse("12248303-2ec4-4afc-b6a8-8d1498c6601e"), Url = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/paulo-bent-ply-leather-chair-o-1582926567.jpg"},
                new Cell() { Id = Guid.Parse("ef1a7514-74e1-45b8-89ff-1495c24fc169"), Url = "https://static.independent.co.uk/s3fs-public/thumbnails/image/2015/10/07/23/web-ali-g-getty.jpg?width=1200"},
                new Cell() { Id = Guid.Parse("82696bf9-ff87-46c3-a4de-035177574f47"), Url = "https://www.sportsnet.ca/wp-content/uploads/2020/08/Lionel-Messi-Barcelona-Champions-League-1040x572.jpg"},
                new Cell() { Id = Guid.Parse("12d52cf2-bf5f-414c-99f8-ab0364324557"), Url = "https://mk0mexiconewsdam2uje.kinstacdn.com/wp-content/uploads/2015/12/quetzal-flying-mejor.jpg"},
                new Cell() { Id = Guid.Parse("06075c76-4361-4dd5-93eb-a80a28d7ab65"), Url = "https://static01.nyt.com/images/2020/09/25/sports/25soccer-nationalWEB1/merlin_177451008_91c7b66d-3c8a-4963-896e-54280f374b6d-articleLarge.jpg?quality=75&auto=webp&disable=upscale"},
                new Cell() { Id = Guid.Parse("3400c172-faa7-4e73-894c-dfa68e2e27b9"), Url = "https://cdn.theathletic.com/app/uploads/2019/09/06104502/GettyImages-1165481703-e1567781166557-1024x684.jpg"},
                new Cell() { Id = Guid.Parse("261c7359-7b71-4a24-a5eb-9e35b62cb823"), Url = "https://cdn.vox-cdn.com/thumbor/1mxkqqttp-h6NTQ9fF6wbcXMcdg=/12x0:4907x3263/1400x1050/filters:focal(12x0:4907x3263):format(jpeg)/cdn.vox-cdn.com/uploads/chorus_image/image/49388585/16071828377_85109fdee4_o.0.0.jpg"},
                new Cell() { Id = Guid.Parse("f39c648e-04c7-4c5a-a31a-6cf544a9f9d1"), Url = "https://post.healthline.com/wp-content/uploads/2019/04/Weed_Orange_1200x628-facebook.jpg"},
                new Cell() { Id = Guid.Parse("4a3a3aa0-0d23-406e-8d4d-82fac76066eb"), Url = "https://www.motortrend.com/uploads/sites/5/2020/01/2020-Acura-NSX-front-three-quarters.jpg"}
            };

            return game;
        }
    }
}
