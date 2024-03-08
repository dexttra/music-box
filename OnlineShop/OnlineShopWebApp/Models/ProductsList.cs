namespace OnlineShopWebApp.Models
{
    public class ProductsList
    {
        public static List<Product> Products { get; } = new List<Product>()
        {
            new Product("Lana Del Rey - Born To Die", 5000, "Label: Interscope Records, Polydor – B0030285-01\r\nFormat: Vinyl, LP, Album, Limited Edition, Reissue, Red Opaque\r\nCountry: US\r\nReleased: Feb 7, 2020\r\nGenre: Rock, Pop\r\nStyle: Dream Pop, Indie Pop, Trip Hop"),
            new Product("Lana Del Rey – Blue Banisters", 5500, "Label: Polydor – 3859014, Interscope Records – 00602438590148\r\nFormat: 2xVinyl, LP, Album\r\nCountry: USA & Europe\r\nReleased: Oct 22, 2021\r\nGenre: Pop"),
            new Product("Olivia Rodrigo – Guts (Limited Magenta Vinyl)", 5000, "Label: Geffen Records – 5597742\r\nFormat: Vinyl, LP, Album, Limited Edition, Magenta, Alternative Artwork\r\nCountry: USA & Canada\r\nReleased: Sep 8, 2023\r\nGenre: Rock, Pop\r\nStyle: Alt-Pop, Pop Rock, Pop Punk, Alternative Rock"),
            new Product("Король и Шут – Акустический альбом", 5500, "Label: United Music Group – CDVP 4026577\r\nFormat: Vinyl, LP\r\nCountry: Russia\r\nReleased: Dec 21, 2023\r\nGenre: Rock\r\nStyle: Punk"),
            new Product("Doja Cat – Planet Her (Deluxe Edition)", 5500, "Label: Kemosabe Records, RCA, Sony Music – 19439-45681-1\r\nFormat: 2xVinyl, LP, Album, Deluxe Edition, Stereo\r\nCountry: Europe\r\nReleased: May 27, 2022\r\nGenre: Hip Hop, Funk / Soul, Pop\r\nStyle: Pop Rap, Contemporary R&B, Dance-pop, Trap")
        };
    }
}
