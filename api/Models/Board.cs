using System.Collections.Generic;
using System;

namespace api.Models
{
    public class Board
    {
        public int Id { get; set; }
        public Guid Key { get; set; }
        public List<Cell> Cells { get; set; }
    }
}
