namespace api.Models
{
    public class GamePlayerBoard
    {
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public int BoardId { get; set; }
        public Board Board { get; set; }
    }
}