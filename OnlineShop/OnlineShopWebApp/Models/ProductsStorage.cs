namespace OnlineShopWebApp.Models
{
    public class ProductsStorage
    {
        public readonly List<Product> Products = new List<Product>()
        {
            new Product("Lana Del Rey - Born To Die", 5000, "Label: Interscope Records, Polydor – B0030285-01\r\nFormat: Vinyl, LP, Album, Limited Edition, Reissue, Red Opaque\r\nCountry: US\r\nReleased: Feb 7, 2020\r\nGenre: Rock, Pop\r\nStyle: Dream Pop, Indie Pop, Trip Hop", "/images/image1.jpg"),
            new Product("Lana Del Rey – Blue Banisters", 5500, "Label: Polydor – 3859014, Interscope Records – 00602438590148\r\nFormat: 2xVinyl, LP, Album\r\nCountry: USA & Europe\r\nReleased: Oct 22, 2021\r\nGenre: Pop", "/images/image2.webp"),
            new Product("Olivia Rodrigo – Guts (Limited Magenta Vinyl)", 5000, "Label: Geffen Records – 5597742\r\nFormat: Vinyl, LP, Album, Limited Edition, Magenta, Alternative Artwork\r\nCountry: USA & Canada\r\nReleased: Sep 8, 2023\r\nGenre: Rock, Pop\r\nStyle: Alt-Pop, Pop Rock, Pop Punk, Alternative Rock", "/images/image3.jpg"),
            new Product("Король и Шут – Акустический альбом", 5500, "Label: United Music Group – CDVP 4026577\r\nFormat: Vinyl, LP\r\nCountry: Russia\r\nReleased: Dec 21, 2023\r\nGenre: Rock\r\nStyle: Punk", "/images/image4.jpg"),
            new Product("Doja Cat – Planet Her (Deluxe Edition)", 5500, "Label: Kemosabe Records, RCA, Sony Music – 19439-45681-1\r\nFormat: 2xVinyl, LP, Album, Deluxe Edition, Stereo\r\nCountry: Europe\r\nReleased: May 27, 2022\r\nGenre: Hip Hop, Funk / Soul, Pop\r\nStyle: Pop Rap, Contemporary R&B, Dance-pop, Trap", "/images/image5.jpg"),
            new Product("Taylor Swift – Folklore (Limited Red Vinyl)", 5500, "Label: Republic Records – B0032823-01, B0032754-01, B0032752-01\r\nFormat: 2xVinyl, LP, Album, Red \"Meet Me Behind The Mall\"\r\nCountry: US\r\nReleased: Nov 20, 2020\r\nGenre: Rock, Pop, Folk, World, & Country\r\nStyle: Vocal, Indie Pop, Indie Rock, Ballad", "/images/image6.jpg"),
            new Product("Taylor Swift – 1989 (Taylor's Version) (Tangerine Vinyl)", 5500, "Label: Republic Records – 0245554218\r\nFormat: 2xVinyl, LP, Album, Special Edition, Tangerine, MPO Pressing\r\nCountry: Worldwide\r\nReleased: Oct 27, 2023\r\nGenre: Electronic, Pop\r\nStyle: Synth-pop, Ballad, Pop Rock", "/images/image7.jpeg"),
            new Product("Eminem – The Marshall Mathers LP 2", 5500, "Label: Aftermath Entertainment, Shady Records, Interscope Records, Web Entertainment – 602537645879\r\nFormat: 2xVinyl, LP, Album\r\nCountry: Europe\r\nReleased: 2013\r\nGenre: Hip Hop\r\nStyle: Pop Rap", "/images/image8.jpg")
        };


		public Product TryGetById(int id)
        {
            return Products.SingleOrDefault(product => product.Id == id);
		}
    }
}
