using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class MockData
    {
       
        public static void SeedSessions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Session>().HasData(new Session[]
            {
                new Session()
                {
                    Id = 1,
                    FilmId = 1,
                    RoomId = 1,
                    DateTime = new DateTime(2024, 05, 17, 19, 30, 00),
                    VipReserved = 0,
                    NormalReserved = 0,
                    VipPrice = 10.00m,
                    NormalPrice = 8.00m
                },
                new Session()
                {
                    Id = 2,
                    FilmId = 2,
                    RoomId = 2,
                    DateTime = new DateTime(2024, 05, 18, 15, 00, 00),
                    VipReserved = 0,
                    NormalReserved = 0,
                    VipPrice = 12.00m,
                    NormalPrice = 10.00m
                }
            });
        }

        public static void SeedFilms(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasData(new Film[]
            {
                new Film()
                {
                    Id = 1,
                    Title = "Inception",
                    Description = "A thief who enters the dreams of others to steal their secrets from their subconscious.",
                    Actors = "none",
                    Trailer = "NULL",
                    Genre = "Action",
                    Rating = "PG-13",
                    ReleaseDate = new DateTime(2024, 05, 16, 00, 00, 00),
                    AgeRestriction = 13
                },
                new Film()
                {
                    Id = 2,
                    Title = "The Shawshank Redemption",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Actors = "none",
                    Trailer = "NULL",
                    Genre = "Drama",
                    Rating = "R",
                    ReleaseDate = new DateTime(2024, 05, 13, 00, 00, 00),
                    AgeRestriction = 18
                }
            })  ;
        }

        public static void SeedRooms(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(new Room[]
            {
                new Room()
                {
                    Id = 1,
                    Name = "first room", 
                    VipPlaces = 10,
                    NormalPlaces = 50
                },
                new Room()
                {
                    Id = 2,
                    Name = "second room",
                    VipPlaces = 5,
                    NormalPlaces = 30
                }
            });
        }
    }
}
