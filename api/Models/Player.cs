using System;


namespace api.Models
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid Key { get; set; }
        public Board Board { get; set; }
    }
}
