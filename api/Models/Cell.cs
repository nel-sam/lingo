using System;
using System.Collections.Generic;

namespace api.Models
{
    public class Cell
    {
        public int Id { get; set; }
        public Guid Key { get; set; }
        public Uri ImageUrl { get; set; }
        public IList<BoardCell> BoardCells { get; set; }

        public IList<Board> Boards { get; set;}
        
        // public int BoardId { get; set; }
        // public Board Board { get; set; }


    }
}
