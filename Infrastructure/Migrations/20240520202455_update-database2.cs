using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Actors", "AgeRestriction", "Description", "Genre", "Rating", "ReleaseDate", "Title", "Trailer" },
                values: new object[,]
                {
                    { 10, "Jim Carrey, Ed Harris, Laura Linney, Noah Emmerich, Natascha McElhore, Holland Taylor", 12, "An insurance salesman discovers his whole life is actually a reality TV show.", "Drama, Comedy", "8.2", new DateTime(1998, 6, 5, 13, 35, 0, 0, DateTimeKind.Unspecified), "The Truman Show", "https://www.youtube.com/watch?v=dlnmQbPGuls" },
                    { 11, "Robert Downey Jr, Gwyneth Paltrow, Terrence Howard, Jeff Bridges, Leslie Bibb, Shaun Toub", 16, "After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.", "Adventure, Action, Ski-Fi", "7.9", new DateTime(2008, 5, 1, 12, 20, 0, 0, DateTimeKind.Unspecified), "Iron Man", "https://www.youtube.com/watch?v=8ugaeA-nMTc" },
                    { 12, "Chris Evans, Hugo Weaving, Samuel L Jackson, Hayley Atwell, Stanley Tucci, Sebastian Stan", 16, "Steve Rogers, a rejected military soldier, transforms into Captain America after taking a dose of a Super-Soldier serum .But being Captain America comes at a price as he attempts to take down a warmonger and a terrorist organization.", "Ski-Fi, Adventure, Action", "6.9", new DateTime(2011, 7, 22, 18, 35, 0, 0, DateTimeKind.Unspecified), "Captain America: The First Avenger", "https://www.youtube.com/watch?v=JerVrbLldXw" },
                    { 13, "Juliete Binoche, Johnny Deep, Judi Dench, Alfred Molina, Antonio Gil, Ron Cook, Lena Olin, John Wood", 18, "A French woman and her young daughter open up a chocolate shop in a small remote village that shakes up the rigid morality of the community.", "Drama, Romance", "7.2", new DateTime(2001, 1, 19, 4, 10, 0, 0, DateTimeKind.Unspecified), "Chocolat", "https://www.youtube.com/watch?v=692hOJq1KJE" },
                    { 14, "Johnny Deep, Freddie Highmore, David Kelly, Helena Bonham Carter, Noah Taylor, Missi Pyle, James Fox, Adam Godley, Julia Winter", 12, "Charlie, a young boy from an impoverished family, and four other kids win a tour of an amazing chocolate factory run by an imaginative chocolatier, Willy Wonka, and his staff of Oompa-Loompas.", "Adventure, Comedy, Musical, Family, Fantasy", "6.7", new DateTime(2005, 7, 15, 20, 5, 0, 0, DateTimeKind.Unspecified), "Charlie and the Chocolate Factory", "https://www.youtube.com/watch?v=OFVGCUIXJls" },
                    { 15, "Johnny Deep, Leonardo DiCaprio, Juliette Lewis, Mary Steenburgen, Darlene Cates, Laura Harrington, Kevin Tighe, Marry Kate Schellhardt, Cameron Finley, Crispin Glover", 18, "A young man in a small Midwestern town struggles to care for his mentally-disabled younger brother and morbidly obese mother while attempting to pursue his own happiness.", "Drama", "7.7", new DateTime(1994, 3, 4, 13, 50, 0, 0, DateTimeKind.Unspecified), "What's Eating Gilbert Grape", "https://www.youtube.com/watch?v=nCsVjQaNV0E" },
                    { 16, "Leonardo DiCaprio, Kate Winslet, Billy Zane, Kathy Bates, Frances Fisher, Gloria Stuart, Bill Paxton, David Warner, Victor Garber, Bernard Hill, Suzy Amis", 18, "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.", "Romance, Drama", "7.9", new DateTime(1997, 12, 19, 11, 15, 0, 0, DateTimeKind.Unspecified), "Titanic", "https://www.youtube.com/watch?v=I7c1etV7D7g" },
                    { 17, "Marisa Abela, Eddie Marsan, Lesley Manville, Juliet Cowan, Anna Darvas, Harley Bird, Thelma Ruby", 16, "The life and music of Amy Winehouse, through the journey of adolescence to adulthood and the creation of one of the best-selling albums of our time.", "Biography", "6.6", new DateTime(2024, 5, 17, 12, 20, 0, 0, DateTimeKind.Unspecified), "Back To Black", "https://www.youtube.com/watch?v=rYzIOBwyhIU" },
                    { 18, "Kirsten Dunst, Wagner Moura, Cailee Spaeny, Nick Offerman, Jefferson White, Evan Nai", 18, "A journey across a dystopian future America, following a team of military-embedded journalists as they race against time to reach DC before rebel factions descend upon the White House.", "Adventure, Action", "7.6", new DateTime(2024, 5, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), "Civil War", "https://www.youtube.com/watch?v=rYzIOBwyhIU" },
                    { 19, "Cailey Fleming, Ryan Reynolds, john Krasinski, Fiona Shaw, Stewe Carell, Alan Kim, Phoebe Waller-Bridge", 10, "A young girl who goes through a difficult experience begins to see everyone's imaginary friends who have been left behind as their real-life friends have grown up.", "Family, Comedy, Drama", "7.4", new DateTime(2024, 5, 16, 12, 20, 0, 0, DateTimeKind.Unspecified), "IF", "https://www.youtube.com/watch?v=ss2KvK-w6w8" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
