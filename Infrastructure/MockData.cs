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
                },

                new Film()
                {
                    Id = 10,
                    Title = "The Truman Show",
                    Description = "An insurance salesman discovers his whole life is actually a reality TV show.",
                    Actors = "Jim Carrey, Ed Harris, Laura Linney, Noah Emmerich, Natascha McElhore, Holland Taylor",
                    Trailer = "https://www.youtube.com/watch?v=dlnmQbPGuls",
                    Genre = "Drama, Comedy",
                    Rating = "8.2",
                    ReleaseDate = new DateTime(1998, 06, 05, 13, 35, 00),
                    AgeRestriction = 12
                },
new Film()
                {
                    Id = 11,
                    Title = "Iron Man",
                    Description = "After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.",
                    Actors = "Robert Downey Jr, Gwyneth Paltrow, Terrence Howard, Jeff Bridges, Leslie Bibb, Shaun Toub",
                    Trailer = "https://www.youtube.com/watch?v=8ugaeA-nMTc",
                    Genre = "Adventure, Action, Ski-Fi",
                    Rating = "7.9",
                    ReleaseDate = new DateTime(2008, 05, 01, 12, 20, 00),
                    AgeRestriction = 16
                },
new Film()
                {
                    Id = 12,
                    Title = "Captain America: The First Avenger",
                    Description = "Steve Rogers, a rejected military soldier, transforms into Captain America after taking a dose of a Super-Soldier serum .But being Captain America comes at a price as he attempts to take down a warmonger and a terrorist organization.",
                    Actors = "Chris Evans, Hugo Weaving, Samuel L Jackson, Hayley Atwell, Stanley Tucci, Sebastian Stan",
                    Trailer = "https://www.youtube.com/watch?v=JerVrbLldXw",
                    Genre = "Ski-Fi, Adventure, Action",
                    Rating = "6.9",
                    ReleaseDate = new DateTime(2011, 07, 22, 18, 35, 00),
                    AgeRestriction = 16
                },
new Film()
                {
                    Id = 13,
                    Title = "Chocolat",
                    Description = "A French woman and her young daughter open up a chocolate shop in a small remote village that shakes up the rigid morality of the community.",
                    Actors = "Juliete Binoche, Johnny Deep, Judi Dench, Alfred Molina, Antonio Gil, Ron Cook, Lena Olin, John Wood",
                    Trailer = "https://www.youtube.com/watch?v=692hOJq1KJE",
                    Genre = "Drama, Romance",
                    Rating = "7.2",
                    ReleaseDate = new DateTime(2001, 01, 19, 04, 10, 00),
                    AgeRestriction = 18
                },
new Film()
                {
                    Id = 14,
                    Title = "Charlie and the Chocolate Factory",
                    Description = "Charlie, a young boy from an impoverished family, and four other kids win a tour of an amazing chocolate factory run by an imaginative chocolatier, Willy Wonka, and his staff of Oompa-Loompas.",
                    Actors = "Johnny Deep, Freddie Highmore, David Kelly, Helena Bonham Carter, Noah Taylor, Missi Pyle, James Fox, Adam Godley, Julia Winter",
                    Trailer = "https://www.youtube.com/watch?v=OFVGCUIXJls",
                    Genre = "Adventure, Comedy, Musical, Family, Fantasy",
                    Rating = "6.7",
                    ReleaseDate = new DateTime(2005, 07, 15, 20, 05, 00),
                    AgeRestriction = 12
                },
new Film()
                {
                    Id = 15,
                    Title = "What's Eating Gilbert Grape",
                    Description = "A young man in a small Midwestern town struggles to care for his mentally-disabled younger brother and morbidly obese mother while attempting to pursue his own happiness.",
                    Actors = "Johnny Deep, Leonardo DiCaprio, Juliette Lewis, Mary Steenburgen, Darlene Cates, Laura Harrington, Kevin Tighe, Marry Kate Schellhardt, Cameron Finley, Crispin Glover",
                    Trailer = "https://www.youtube.com/watch?v=nCsVjQaNV0E",
                    Genre = "Drama",
                    Rating = "7.7",
                    ReleaseDate = new DateTime(1994, 03, 04, 13, 50, 00),
                    AgeRestriction = 18
                },
new Film()
                {
                    Id = 16,
                    Title = "Titanic",
                    Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",
                    Actors = "Leonardo DiCaprio, Kate Winslet, Billy Zane, Kathy Bates, Frances Fisher, Gloria Stuart, Bill Paxton, David Warner, Victor Garber, Bernard Hill, Suzy Amis",
                    Trailer = "https://www.youtube.com/watch?v=I7c1etV7D7g",
                    Genre = "Romance, Drama",
                    Rating = "7.9",
                    ReleaseDate = new DateTime(1997, 12, 19, 11, 15, 00),
                    AgeRestriction = 18
                },
new Film()
                {
                    Id = 17,
                    Title = "Back To Black",
                    Description = "The life and music of Amy Winehouse, through the journey of adolescence to adulthood and the creation of one of the best-selling albums of our time.",
                    Actors = "Marisa Abela, Eddie Marsan, Lesley Manville, Juliet Cowan, Anna Darvas, Harley Bird, Thelma Ruby",
                    Trailer = "https://www.youtube.com/watch?v=rYzIOBwyhIU",
                    Genre = "Biography",
                    Rating = "6.6",
                    ReleaseDate = new DateTime(2024, 05, 17, 12, 20, 00),
                    AgeRestriction = 16
                },
new Film()
                {
                    Id = 18,
                    Title = "Civil War",
                    Description = "A journey across a dystopian future America, following a team of military-embedded journalists as they race against time to reach DC before rebel factions descend upon the White House.",
                    Actors = "Kirsten Dunst, Wagner Moura, Cailee Spaeny, Nick Offerman, Jefferson White, Evan Nai",
                    Trailer = "https://www.youtube.com/watch?v=rYzIOBwyhIU",
                    Genre = "Adventure, Action",
                    Rating = "7.6",
                    ReleaseDate = new DateTime(2024, 05, 19, 20, 00, 00),
                    AgeRestriction = 18
                },
new Film()
                {
                    Id = 19,
                    Title = "IF",
                    Description = "A young girl who goes through a difficult experience begins to see everyone's imaginary friends who have been left behind as their real-life friends have grown up.",
                    Actors = "Cailey Fleming, Ryan Reynolds, john Krasinski, Fiona Shaw, Stewe Carell, Alan Kim, Phoebe Waller-Bridge",
                    Trailer = "https://www.youtube.com/watch?v=ss2KvK-w6w8",
                    Genre = "Family, Comedy, Drama",
                    Rating = "7.4",
                    ReleaseDate = new DateTime(2024, 05, 16, 12, 20, 00),
                    AgeRestriction = 10
                },


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
