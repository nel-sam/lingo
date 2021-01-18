using System;
using System.Collections.Generic;

namespace api.Models.Data_Transfer_Objects
{
    public class GameDto
    {
        public Guid Key { get; set; }

        public List<Player> Players { get; set; }
    }
}