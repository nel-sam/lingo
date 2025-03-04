using System.Collections.Generic;
using System;

namespace api.Models
{
    public class Board
    {
        public int Id { get; set; }
        public Guid Key { get; set; }

        public IList<BoardCell> BoardCells { get; set; }


        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
