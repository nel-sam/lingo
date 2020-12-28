using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoardController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<BoardController> _logger;

        public BoardController(ILogger<BoardController> logger)
        {
            _logger = logger;
        }
     
        [HttpGet]
        [Route("Board")]
        public Board GetBoard()
        {
            var board = new Board();
            board.Cells = new List<Cell>()
            {
                new Cell() { Id = "dog", Url = "https://media.nature.com/lw800/magazine-assets/d41586-020-01430-5/d41586-020-01430-5_17977552.jpg"},
                new Cell() { Id = "car", Url = "https://blog.consumerguide.com/wp-content/uploads/sites/2/2018/04/Honda-N-Box.png"},
                new Cell() { Id = "chr", Url = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/paulo-bent-ply-leather-chair-o-1582926567.jpg"},
                new Cell() { Id = "ali", Url = "https://static.independent.co.uk/s3fs-public/thumbnails/image/2015/10/07/23/web-ali-g-getty.jpg?width=1200"},
                new Cell() { Id = "msi", Url = "https://www.sportsnet.ca/wp-content/uploads/2020/08/Lionel-Messi-Barcelona-Champions-League-1040x572.jpg"},
                new Cell() { Id = "qzt", Url = "https://mk0mexiconewsdam2uje.kinstacdn.com/wp-content/uploads/2015/12/quetzal-flying-mejor.jpg"},
                new Cell() { Id = "mss", Url = "https://static01.nyt.com/images/2020/09/25/sports/25soccer-nationalWEB1/merlin_177451008_91c7b66d-3c8a-4963-896e-54280f374b6d-articleLarge.jpg?quality=75&auto=webp&disable=upscale"},
                new Cell() { Id = "leh", Url = "https://cdn.theathletic.com/app/uploads/2019/09/06104502/GettyImages-1165481703-e1567781166557-1024x684.jpg"},
                new Cell() { Id = "red", Url = "https://cdn.vox-cdn.com/thumbor/1mxkqqttp-h6NTQ9fF6wbcXMcdg=/12x0:4907x3263/1400x1050/filters:focal(12x0:4907x3263):format(jpeg)/cdn.vox-cdn.com/uploads/chorus_image/image/49388585/16071828377_85109fdee4_o.0.0.jpg"},
                new Cell() { Id = "mrj", Url = "https://post.healthline.com/wp-content/uploads/2019/04/Weed_Orange_1200x628-facebook.jpg"},
                new Cell() { Id = "nsx", Url = "https://www.motortrend.com/uploads/sites/5/2020/01/2020-Acura-NSX-front-three-quarters.jpg"}
            };
            return board;
        }
    }
}
