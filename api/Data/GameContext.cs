using System;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Player>().HasKey(x => new { x.Board.BoardId });

            var player1Board = new Board()
            {
                BoardId = 1,
                Cells = null
            };

            modelBuilder.Entity<Board>().HasData(player1Board);

            modelBuilder.Entity<Player>().HasData(
                new Player()
                {
                    PlayerId = 1,
                    FirstName = "Nelson",
                    LastName = "Samayoa",
                    Key = new Guid("5d516a2b-9722-481c-b98e-89831ae4a732"),
                    Board = player1Board
                }
            );

            modelBuilder.Entity<Game>().HasData(
               new Game
               {
                    GameId = 1,
                    Key = new Guid("647c6980-a700-435c-b9c1-4695568a8229"),
                    Players =
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}