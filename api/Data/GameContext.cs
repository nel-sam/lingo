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
        public DbSet<Game> Games { get; set; }
        public DbSet<BoardCell> BoardCells { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=tcp:lingogame.database.windows.net,1433;Initial Catalog=lingo;Persist Security Info=False;User ID=lingoadmin;Password=Lijag4ll;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoardCell>().HasKey(e => new { e.Id, e.CellId });

            modelBuilder.Entity<BoardCell>()
                .HasOne<Board>(b => b.Board)
                .WithMany(bc => bc.BoardCells)
                .HasForeignKey(b => b.Id);


            modelBuilder.Entity<BoardCell>()
                .HasOne<Cell>(c => c.Cells)
                .WithMany(bc => bc.BoardCells)
                .HasForeignKey(c => c.CellId);         



            base.OnModelCreating(modelBuilder);
        }
    }
}
