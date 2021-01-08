using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid Key { get; set; }
        public Board Board { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }

    }
}
