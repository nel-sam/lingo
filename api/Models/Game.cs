using System.Collections.Generic;
using System;

namespace api.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public Guid Key { get; set; }
        public List<Player> Players { get; set; }
    }
}
