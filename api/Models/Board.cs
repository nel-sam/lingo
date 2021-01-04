using System.Collections.Generic;

namespace api.Models
{
    public class Board
    {
        public int BoardId { get; set; }
        public List<Cell> Cells { get; set; }
    }
}
