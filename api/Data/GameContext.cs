using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class GameContext : DbContext
    {
        public DbSet<Board> Board { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Game> Games { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=lingo.db");
    }
}