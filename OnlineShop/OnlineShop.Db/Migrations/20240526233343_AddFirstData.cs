using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineShop.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddFirstData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("45a7e4b9-94e3-4b1e-aa34-abcde1234567"), "Label: Interscope Records, Polydor – B0030285-01\r\nFormat: Vinyl, LP, Album, Limited Edition, Reissue, Red Opaque\r\nCountry: US\r\nReleased: Feb 7, 2020\r\nGenre: Rock, Pop\r\nStyle: Dream Pop, Indie Pop, Trip Hop", "/images/image1.jpg", "Lana Del Rey - Born To Die", 5000m },
                    { new Guid("5fb4b0bb-765d-4b9a-b5de-c34567890123"), "Label: Polydor – 3859014, Interscope Records – 00602438590148\r\nFormat: 2xVinyl, LP, Album\r\nCountry: USA & Europe\r\nReleased: Oct 22, 2021\r\nGenre: Pop", "/images/image2.webp", "Lana Del Rey – Blue Banisters", 5500m },
                    { new Guid("6a8ca2f1-6e45-4b0f-a5ed-dcba09876543"), "Label: Geffen Records – 5597742\r\nFormat: Vinyl, LP, Album, Limited Edition, Magenta, Alternative Artwork\r\nCountry: USA & Canada\r\nReleased: Sep 8, 2023\r\nGenre: Rock, Pop\r\nStyle: Alt-Pop, Pop Rock, Pop Punk, Alternative Rock", "/images/image3.jpg", "Olivia Rodrigo – Guts (Limited Magenta Vinyl)", 5000m },
                    { new Guid("7b9d48f3-8c6b-473a-a5f8-efbc12345678"), "Label: United Music Group – CDVP 4026577\r\nFormat: Vinyl, LP\r\nCountry: Russia\r\nReleased: Dec 21, 2023\r\nGenre: Rock\r\nStyle: Punk", "/images/image4.jpg", "Король и Шут – Акустический альбом", 5500m },
                    { new Guid("8cad89f2-9f7c-4c9e-a1f5-fe9876543210"), "Label: Kemosabe Records, RCA, Sony Music – 19439-45681-1\r\nFormat: 2xVinyl, LP, Album, Deluxe Edition, Stereo\r\nCountry: Europe\r\nReleased: May 27, 2022\r\nGenre: Hip Hop, Funk / Soul, Pop\r\nStyle: Pop Rap, Contemporary R&B, Dance-pop, Trap", "/images/image5.jpg", "Doja Cat – Planet Her (Deluxe Edition)", 5500m },
                    { new Guid("9dbeaafb-a068-4c7b-a123-fecba0987654"), "Label: Republic Records – B0032823-01, B0032754-01, B0032752-01\r\nFormat: 2xVinyl, LP, Album, Red \"Meet Me Behind The Mall\"\r\nCountry: US\r\nReleased: Nov 20, 2020\r\nGenre: Rock, Pop, Folk, World, & Country\r\nStyle: Vocal, Indie Pop, Indie Rock, Ballad", "/images/image6.jpg", "Taylor Swift – Folklore (Limited Red Vinyl)", 5500m },
                    { new Guid("aeb4c6ad-ba89-4e4b-a234-fedcba987656"), "Label: Republic Records – 0245554218\r\nFormat: 2xVinyl, LP, Album, Special Edition, Tangerine, MPO Pressing\r\nCountry: Worldwide\r\nReleased: Oct 27, 2023\r\nGenre: Electronic, Pop\r\nStyle: Synth-pop, Ballad, Pop Rock", "/images/image7.jpeg", "Taylor Swift – 1989 (Taylor's Version) (Tangerine Vinyl)", 5500m },
                    { new Guid("b1a2c3d4-e5f6-4a7b-8c9d-0abcdef12345"), "Label: Aftermath Entertainment, Shady Records, Interscope Records, Web Entertainment – 602537645879\r\nFormat: 2xVinyl, LP, Album\r\nCountry: Europe\r\nReleased: 2013\r\nGenre: Hip Hop\r\nStyle: Pop Rap", "/images/image8.jpg", "Eminem – The Marshall Mathers LP 2", 5500m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45a7e4b9-94e3-4b1e-aa34-abcde1234567"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fb4b0bb-765d-4b9a-b5de-c34567890123"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a8ca2f1-6e45-4b0f-a5ed-dcba09876543"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b9d48f3-8c6b-473a-a5f8-efbc12345678"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cad89f2-9f7c-4c9e-a1f5-fe9876543210"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9dbeaafb-a068-4c7b-a123-fecba0987654"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aeb4c6ad-ba89-4e4b-a234-fedcba987656"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1a2c3d4-e5f6-4a7b-8c9d-0abcdef12345"));
        }
    }
}
