using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Updatedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Actors", "AgeRestriction", "Description", "Genre", "Rating", "ReleaseDate", "Title", "Trailer" },
                values: new object[] { "Cillian Murphy, Emily Blunt, Matt Damon, Robert Downey Jr., Alden Ehrenreich", 16, "Oppenheimer is a 2023 epic biographical thriller drama film written, directed, and produced by Christopher Nolan. It follows the life of J. Robert Oppenheimer, the American theoretical physicist who helped develop the first nuclear weapons during World War II.", "Biography, Drama, History", "8.3", new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oppenheimer", "https://www.youtube.com/watch?v=uYPbbksJxIg&ab_channel=UniversalPictures" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Actors", "AgeRestriction", "Description", "Genre", "Rating", "ReleaseDate", "Title", "Trailer" },
                values: new object[] { "Margot Robbie, Ryan Gosling, Issa Rae, Kate McKinnon, Alexandra Shipp, Emma Mackey", 12, "Set in the colorful Barbie Land, stereotypical Barbie lives a perfect life every single day. One day, she shows signs of being...a human. She decides to go to the Real World to find the cure in order to make herself perfect again.", "Adventure, Comedy, Fantasy", "6.8", new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbie", "https://www.youtube.com/watch?v=Kb7jYOYXiVc&ab_channel=RapidTrailer" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Actors", "AgeRestriction", "Description", "Genre", "Rating", "ReleaseDate", "Title", "Trailer" },
                values: new object[,]
                {
                    { 3, "timothee Chalamet, Zendaya, Rebecca Ferguson, Javier Dardem, Josh Brollin, Austin Butler", 16, "Dune: Part Two will explore the mythic journey of Paul Atreides as he unites with Chani and the Fremen while on a warpath of revenge against the conspirators who destroyed his family.", "Action, Adventure, Drama, Sci-Fi", "8.6", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dune: Part Two", "https://www.youtube.com/watch?v=Way9Dexny3w&ab_channel=WarnerBros.Pictures" },
                    { 4, "Joaquin Phoenix, Robert De Niro, Zazie Beetz, Frances Conroy, Brett Cullen", 16, "The film, loosely based on DC Comics characters, stars Joaquin Phoenix as the Joker. Set in 1981, it follows Arthur Fleck, a failed clown and aspiring stand-up comedian whose descent into mental illness and nihilism inspires a violent countercultural revolution against the wealthy in a decaying Gotham City.", "Crime, Drama, Thriller", "8.4", new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joker", "https://www.youtube.com/watch?v=t433PEQGErc&ab_channel=WarnerBros.Pictures" },
                    { 5, "Tom Holland, Zendaya, Benedict Cumberbatch, Jacob Batalon, Jon Favreau, Willem Dafoe", 12, "Peter Parker's secret identity is revealed to the entire world. Desperate for help, Peter turns to Doctor Strange to make the world forget that he is Spider-Man. The spell goes horribly wrong and shatters the multiverse, bringing in monstrous villains that could destroy the world.", "Action, Adventure, Fantasy, Sci-Fi", "8.2", new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider-Man: No Way Home", "https://www.youtube.com/watch?v=JfVOs4VSpmA&ab_channel=SonyPicturesEntertainment" },
                    { 6, "Tom Hardy, Charlize Theron, Nicholas Hoult, Zoe Kravitz, Hugh Keays-Byrne, Josh Helman", 16, "Set in a post-apocalyptic desert wasteland where petrol and water are scarce commodities, Fury Road follows Max Rockatansky (Hardy), who joins forces with Imperator Furiosa (Theron) against cult leader Immortan Joe (Keays-Byrne) and his army, leading to a lengthy road battle.", "Action, Adventure, Sci-Fi, THriller", "8.1", new DateTime(2015, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mad Max: Fury Road", "https://www.youtube.com/watch?v=hEJnMQG9ev8&ab_channel=WarnerBros.Pictures" },
                    { 7, "Robert Downey Jr., Chris Evans, Mark Ruffalo, Chris Hemsworth, Scarlett Johansson, Jeremy Renner, Tom Holland, Benedict Cumberbatch, Chadwick Boseman, Paul Rudd", 12, "AVENGERS: ENDGAME is set after Thanos' catastrophic use of the Infinity Stones randomly wiped out half of Earth's population in Avengers: Infinity War. Those left behind are desperate to do something -- anything -- to bring back their lost loved ones", "Action, Adventure, Drama, Sci-Fi", "8.4", new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avengers: Endgame", "https://www.youtube.com/watch?v=hA6hldpSTF8&ab_channel=MarvelEntertainment" },
                    { 8, "Rebecca Hall, Brian Tyree Henry, Dan Stevens, Kaylee Hottle, Alex Ferns, Fala Chen", 12, "The new installment in the Monsterverse puts the mighty Kong and the fearsome Godzilla against a colossal deadly threat hidden within our world that threatens the existence of their species and our very own, as well as diving deep into the mysteries of Skull Island and beyond.", "Action, Adventure, Fantasy, Sci-Fi, Thriller", "6.3", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Godzilla x Kong: The New Empire", "https://www.youtube.com/watch?v=lV1OOlGwExM&ab_channel=WarnerBros.Pictures" },
                    { 9, "Anne Hathaway, Nicholas Galitzine, Ella Rubin, Annie Mumolo, Perry Mattfeld, Reid Scott", 16, "Based on the acclaimed, contemporary love story of the same name, The Idea of You centers on Solène (Anne Hathaway), a 40-year-old single mom who begins an unexpected romance with 24-year-old Hayes Campbell (Nicholas Galitzine), the lead singer of August Moon, the hottest boy band on the planet.", "Comedy, Drama, Romance", "6.4", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The idea of you", "https://www.youtube.com/watch?v=V8i6PB0gGOA&ab_channel=PrimeVideo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Actors", "AgeRestriction", "Description", "Genre", "Rating", "ReleaseDate", "Title", "Trailer" },
                values: new object[] { "none", 13, "A thief who enters the dreams of others to steal their secrets from their subconscious.", "Action", "PG-13", new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception", "NULL" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Actors", "AgeRestriction", "Description", "Genre", "Rating", "ReleaseDate", "Title", "Trailer" },
                values: new object[] { "none", 18, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "Drama", "R", new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption", "NULL" });
        }
    }
}
