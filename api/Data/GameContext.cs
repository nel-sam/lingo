using System;
using System.Collections.Generic;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class GameContext : DbContext
    {
        public DbSet<Board> Board { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<BoardCell> BoardCells { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=lingo.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoardCell>().HasKey(e => new { e.BoardId, e.CellId });

            modelBuilder.Entity<BoardCell>()
                .HasOne<Board>(b => b.Board)
                .WithMany(bc => bc.BoardCells)
                .HasForeignKey(b => b.BoardId);


            modelBuilder.Entity<BoardCell>()
                .HasOne<Cell>(c => c.Cells)
                .WithMany(bc => bc.BoardCells)
                .HasForeignKey(c => c.CellId);

            // modelBuilder.Entity<Game>().Property(e => e.GameId).ValueGeneratedOnAdd();
            // modelBuilder.Entity<Player>().Property(e => e.PlayerId).ValueGeneratedOnAdd();
            // modelBuilder.Entity<Board>().Property(e => e.BoardId).ValueGeneratedOnAdd();
            // modelBuilder.Entity<Cell>().Property(e => e.CellId).ValueGeneratedOnAdd();
            

            var player1Cells = new List<Cell>()
            {
                new Cell() { CellId = 1, Key = new Guid("14943241-3721-4abf-8977-36290b0437ec"), ImageUrl = new Uri("https://media.nature.com/lw800/magazine-assets/d41586-020-01430-5/d41586-020-01430-5_17977552.jpg")},
                new Cell() { CellId = 2, Key = new Guid("44777ac2-8f97-4f97-9f33-95c245151fb3"), ImageUrl = new Uri("https://blog.consumerguide.com/wp-content/uploads/sites/2/2018/04/Honda-N-Box.png")},
                new Cell() { CellId = 3, Key = new Guid("12248303-2ec4-4afc-b6a8-8d1498c6601e"), ImageUrl = new Uri("https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/paulo-bent-ply-leather-chair-o-1582926567.jpg")},
                new Cell() { CellId = 4, Key = new Guid("ef1a7514-74e1-45b8-89ff-1495c24fc169"), ImageUrl = new Uri("https://static.independent.co.uk/s3fs-public/thumbnails/image/2015/10/07/23/web-ali-g-getty.jpg?width=1200")},
                new Cell() { CellId = 5, Key = new Guid("82696bf9-ff87-46c3-a4de-035177574f47"), ImageUrl = new Uri("https://www.sportsnet.ca/wp-content/uploads/2020/08/Lionel-Messi-Barcelona-Champions-League-1040x572.jpg")},
                new Cell() { CellId = 6, Key = new Guid("12d52cf2-bf5f-414c-99f8-ab0364324557"), ImageUrl = new Uri("https://mk0mexiconewsdam2uje.kinstacdn.com/wp-content/uploads/2015/12/quetzal-flying-mejor.jpg")},
                new Cell() { CellId = 7, Key = new Guid("06075c76-4361-4dd5-93eb-a80a28d7ab65"), ImageUrl = new Uri("https://static01.nyt.com/images/2020/09/25/sports/25soccer-nationalWEB1/merlin_177451008_91c7b66d-3c8a-4963-896e-54280f374b6d-articleLarge.jpg?quality=75&auto=webp&disable=upscale")},
                new Cell() { CellId = 8, Key = new Guid("3400c172-faa7-4e73-894c-dfa68e2e27b9"), ImageUrl = new Uri("https://cdn.theathletic.com/app/uploads/2019/09/06104502/GettyImages-1165481703-e1567781166557-1024x684.jpg")},
                new Cell() { CellId = 9, Key = new Guid("261c7359-7b71-4a24-a5eb-9e35b62cb823"), ImageUrl = new Uri("https://cdn.vox-cdn.com/thumbor/1mxkqqttp-h6NTQ9fF6wbcXMcdg=/12x0:4907x3263/1400x1050/filters:focal(12x0:4907x3263):format(jpeg)/cdn.vox-cdn.com/uploads/chorus_image/image/49388585/16071828377_85109fdee4_o.0.0.jpg")},
                new Cell() { CellId = 10, Key = new Guid("f39c648e-04c7-4c5a-a31a-6cf544a9f9d1"), ImageUrl = new Uri("https://post.healthline.com/wp-content/uploads/2019/04/Weed_Orange_1200x628-facebook.jpg")},
                new Cell() { CellId = 11, Key = new Guid("4a3a3aa0-0d23-406e-8d4d-82fac76066eb"), ImageUrl = new Uri("https://www.motortrend.com/uploads/sites/5/2020/01/2020-Acura-NSX-front-three-quarters.jpg")}
            };

            var player1Board = new Board()
            {
                BoardId = 1,
                Key = new Guid("126963f9-ff87-46c3-a4de-035177574f47"),
                PlayerId = 1
            };

            var player2Board = new Board()
            {
                BoardId = 2,
                Key = new Guid("226363f9-ff87-46c3-a4de-035177574f47"),
                PlayerId = 2
            };

            var player1 = new Player()
            {
                PlayerId = 1,
                FirstName = "Nelson",
                LastName = "Samayoa",
                Key = new Guid("5d516a2b-9722-481c-b98e-89831ae4a732"),
                GameId = 1
            };

            var player2 = new Player()
            {
                PlayerId = 2,
                FirstName = "Bayron",
                LastName = "Pineda",
                Key = new Guid("5d526a2b-9722-481c-b98e-89831ae4a732"),
                GameId = 1
            };

            var Game1 = new Game()
            {
                GameId = 1,
                Key = new Guid("5d516a2b-9722-481c-b98e-89831ae4a732"),
            };

            var Game2 = new Game()
            {
                GameId = 2,
                Key = new Guid("5d536a2b-9722-481c-b98e-89831ae4a732"),
            };

            var Board1Cells = new List<BoardCell>
            {
                new BoardCell(){ BoardId = 1, CellId = 1},
                new BoardCell(){ BoardId = 2, CellId = 1}
            };

        
            modelBuilder.Entity<Game>().HasData(Game1);
            modelBuilder.Entity<Player>().HasData(player1, player2);

            modelBuilder.Entity<Board>().HasData(player1Board, player2Board);

            modelBuilder.Entity<Cell>().HasData(player1Cells);

            modelBuilder.Entity<BoardCell>().HasData(Board1Cells);

            base.OnModelCreating(modelBuilder);
        }
    }
}

// modelBuilder.Entity<Game>().HasKey(e => e.GameId);
            // modelBuilder.Entity<Player>().HasKey(e => e.PlayerId);
            // modelBuilder.Entity<Board>().HasKey(e => e.BoardId);
            // modelBuilder.Entity<Cell>().HasKey(e => e.CellId);

            // modelBuilder.Entity<Game>().Property(e => e.Id).ValueGeneratedOnAdd();
            // modelBuilder.Entity<Player>().Property(e => e.Id).ValueGeneratedOnAdd();
            // modelBuilder.Entity<Board>().Property(e => e.Id).ValueGeneratedOnAdd();
            // modelBuilder.Entity<Cell>().Property(e => e.Id).ValueGeneratedOnAdd();