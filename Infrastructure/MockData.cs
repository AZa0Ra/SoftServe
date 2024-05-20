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
                    Title = "Oppenheimer",
                    Description = "Oppenheimer is a 2023 epic biographical thriller drama film written, directed, and produced by Christopher Nolan. It follows the life of J. Robert Oppenheimer, the American theoretical physicist who helped develop the first nuclear weapons during World War II.",
                    Actors = "Cillian Murphy, Emily Blunt, Matt Damon, Robert Downey Jr., Alden Ehrenreich",
                    Trailer = "https://www.youtube.com/watch?v=uYPbbksJxIg&ab_channel=UniversalPictures",
                    Genre = "Biography, Drama, History",
                    Rating = "8.3",
                    ReleaseDate = new DateTime(2023, 08, 21, 00, 00, 00),
                    AgeRestriction = 16
                },
                new Film()
                {
                    Id = 2,
                    Title = "Barbie",
                    Description = "Set in the colorful Barbie Land, stereotypical Barbie lives a perfect life every single day. One day, she shows signs of being...a human. She decides to go to the Real World to find the cure in order to make herself perfect again.",
                    Actors = "Margot Robbie, Ryan Gosling, Issa Rae, Kate McKinnon, Alexandra Shipp, Emma Mackey",
                    Trailer = "https://www.youtube.com/watch?v=Kb7jYOYXiVc&ab_channel=RapidTrailer",
                    Genre = "Adventure, Comedy, Fantasy",
                    Rating = "6.8",
                    ReleaseDate = new DateTime(2023, 08, 21, 00, 00, 00),
                    AgeRestriction = 12
                },
                new Film()
                {
                    Id = 3,
                    Title = "Dune: Part Two",
                    Description = "Dune: Part Two will explore the mythic journey of Paul Atreides as he unites with Chani and the Fremen while on a warpath of revenge against the conspirators who destroyed his family.",
                    Actors = "timothee Chalamet, Zendaya, Rebecca Ferguson, Javier Dardem, Josh Brollin, Austin Butler",
                    Trailer = "https://www.youtube.com/watch?v=Way9Dexny3w&ab_channel=WarnerBros.Pictures",
                    Genre = "Action, Adventure, Drama, Sci-Fi",
                    Rating = "8.6",
                    ReleaseDate = new DateTime(2024, 02, 29, 00, 00, 00),
                    AgeRestriction = 16
                },
                new Film()
                {
                    Id = 4,
                    Title = "Joker",
                    Description = "The film, loosely based on DC Comics characters, stars Joaquin Phoenix as the Joker. Set in 1981, it follows Arthur Fleck, a failed clown and aspiring stand-up comedian whose descent into mental illness and nihilism inspires a violent countercultural revolution against the wealthy in a decaying Gotham City.",
                    Actors = "Joaquin Phoenix, Robert De Niro, Zazie Beetz, Frances Conroy, Brett Cullen",
                    Trailer = "https://www.youtube.com/watch?v=t433PEQGErc&ab_channel=WarnerBros.Pictures",
                    Genre = "Crime, Drama, Thriller",
                    Rating = "8.4",
                    ReleaseDate = new DateTime(2019, 10, 03, 00, 00, 00),
                    AgeRestriction = 16
                },
                new Film()
                {
                    Id = 5,
                    Title = "Spider-Man: No Way Home",
                    Description = "Peter Parker's secret identity is revealed to the entire world. Desperate for help, Peter turns to Doctor Strange to make the world forget that he is Spider-Man. The spell goes horribly wrong and shatters the multiverse, bringing in monstrous villains that could destroy the world.",
                    Actors = "Tom Holland, Zendaya, Benedict Cumberbatch, Jacob Batalon, Jon Favreau, Willem Dafoe",
                    Trailer = "https://www.youtube.com/watch?v=JfVOs4VSpmA&ab_channel=SonyPicturesEntertainment",
                    Genre = "Action, Adventure, Fantasy, Sci-Fi",
                    Rating = "8.2",
                    ReleaseDate = new DateTime(2021, 12, 17, 00, 00, 00),
                    AgeRestriction = 12
                },
                new Film()
                {
                    Id = 6,
                    Title = "Mad Max: Fury Road",
                    Description = "Set in a post-apocalyptic desert wasteland where petrol and water are scarce commodities, Fury Road follows Max Rockatansky (Hardy), who joins forces with Imperator Furiosa (Theron) against cult leader Immortan Joe (Keays-Byrne) and his army, leading to a lengthy road battle.",
                    Actors = "Tom Hardy, Charlize Theron, Nicholas Hoult, Zoe Kravitz, Hugh Keays-Byrne, Josh Helman",
                    Trailer = "https://www.youtube.com/watch?v=hEJnMQG9ev8&ab_channel=WarnerBros.Pictures",
                    Genre = "Action, Adventure, Sci-Fi, THriller",
                    Rating = "8.1",
                    ReleaseDate = new DateTime(2015, 05, 14, 00, 00, 00),
                    AgeRestriction = 16
                },
                new Film()
                {
                    Id = 7,
                    Title = "Avengers: Endgame",
                    Description = "AVENGERS: ENDGAME is set after Thanos' catastrophic use of the Infinity Stones randomly wiped out half of Earth's population in Avengers: Infinity War. Those left behind are desperate to do something -- anything -- to bring back their lost loved ones",
                    Actors = "Robert Downey Jr., Chris Evans, Mark Ruffalo, Chris Hemsworth, Scarlett Johansson, Jeremy Renner, Tom Holland, Benedict Cumberbatch, Chadwick Boseman, Paul Rudd",
                    Trailer = "https://www.youtube.com/watch?v=hA6hldpSTF8&ab_channel=MarvelEntertainment",
                    Genre = "Action, Adventure, Drama, Sci-Fi",
                    Rating = "8.4",
                    ReleaseDate = new DateTime(2019, 04, 26, 00, 00, 00),
                    AgeRestriction = 12
                },
                new Film()
                {
                    Id = 8,
                    Title = "Godzilla x Kong: The New Empire",
                    Description = "The new installment in the Monsterverse puts the mighty Kong and the fearsome Godzilla against a colossal deadly threat hidden within our world that threatens the existence of their species and our very own, as well as diving deep into the mysteries of Skull Island and beyond.",
                    Actors = "Rebecca Hall, Brian Tyree Henry, Dan Stevens, Kaylee Hottle, Alex Ferns, Fala Chen",
                    Trailer = "https://www.youtube.com/watch?v=lV1OOlGwExM&ab_channel=WarnerBros.Pictures",
                    Genre = "Action, Adventure, Fantasy, Sci-Fi, Thriller",
                    Rating = "6.3",
                    ReleaseDate = new DateTime(2024, 04, 28, 00, 00, 00),
                    AgeRestriction = 12
                },
                new Film()
                {
                    Id = 9,
                    Title = "The idea of you",
                    Description = "Based on the acclaimed, contemporary love story of the same name, The Idea of You centers on Solène (Anne Hathaway), a 40-year-old single mom who begins an unexpected romance with 24-year-old Hayes Campbell (Nicholas Galitzine), the lead singer of August Moon, the hottest boy band on the planet.",
                    Actors = "Anne Hathaway, Nicholas Galitzine, Ella Rubin, Annie Mumolo, Perry Mattfeld, Reid Scott",
                    Trailer = "https://www.youtube.com/watch?v=V8i6PB0gGOA&ab_channel=PrimeVideo",
                    Genre = "Comedy, Drama, Romance",
                    Rating = "6.4",
                    ReleaseDate = new DateTime(2024, 04, 26, 00, 00, 00),
                    AgeRestriction = 16
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
