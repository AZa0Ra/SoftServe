using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Infrastructure
{
    public class CinemaDbContext : IdentityDbContext
    {
        public CinemaDbContext()
        {
            
        }
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CinemaDbApi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            optionsBuilder.UseSqlServer(connStr);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
         
            modelBuilder.Entity<Session>()
                .HasOne(s => s.Film)
                .WithMany(f => f.Sessions)
                .HasForeignKey(s => s.FilmId);

            modelBuilder.Entity<Session>()
                .HasOne(s => s.Room)
                .WithMany(r => r.Sessions)
                .HasForeignKey(s => s.RoomId);

     

            modelBuilder.SeedFilms();
            modelBuilder.SeedRooms();
            modelBuilder.SeedSessions();
        }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Film> Films { get; set; }
    }
}
