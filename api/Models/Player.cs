using System;
using System.Collections.Generic;

namespace api.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid Key { get; set; }

        public Board Board { get; set; }

        public List<GamePlayerBoard> GamePlayerBoards { get; set; }

        public List<Game> Games { get; set; }
    }
}
