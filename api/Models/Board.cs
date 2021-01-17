using System.Collections.Generic;
using System;

namespace api.Models
{
    public class Board
    {
        public int BoardId { get; set; }
        public Guid Key { get; set; }

        public IList<BoardCell> BoardCells { get; set; }
        public IList<GamePlayerBoard> GamePlayerBoards { get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
