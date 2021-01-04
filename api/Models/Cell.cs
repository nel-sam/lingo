using System;

namespace api.Models
{
    public class Cell
    {
        public int Id { get; set; }
        public Guid Key { get; set; }
        public Uri ImageUrl { get; set; }
    }
}
