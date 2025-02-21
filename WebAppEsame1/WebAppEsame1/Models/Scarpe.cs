namespace WebAppEsame1.Models
{
    public class Scarpe
    {
        public static List<Product> ScarpeList = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Nome = "NikeAirForceBlack",
                Prezzo = 120.99m,
                Descrizione = "Nike Snweakers Air Force da Uomo",
                Immagine_Copertina = "/Images/nikeairfoceblack.webp",
                Img_1 = "/Images/img1.jpeg",
                Img_2 = "/Images/img2.avif"
            },
            new Product() {
                Id = 2,
                Nome = "AdidasRed",
                Prezzo = 79.99m,
                Descrizione = "Adidas Sneakers Rosse da Uomo",
                Immagine_Copertina = "/Images/adidasred.webp",
                Img_1 = "/Images/img3.webp",
                Img_2 = "/Images/img4.webp"
            }
        };
    }

}