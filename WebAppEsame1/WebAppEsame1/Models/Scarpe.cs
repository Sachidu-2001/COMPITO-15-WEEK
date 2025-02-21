namespace WebAppEsame1.Models
{
    public static class Scarpe
    {
        public static List<Product> ScarpeList = new List<Product>
        {
            new Product
            {
                Id = 1,
                Nome_Articolo = "NikeAirForceBlack",
                Prezzo = 120.99m,
                Descrizione_Dettagliata = "Sneakers Nike Air Force Nere da Uomo",
                Immagine_Copertina = "/Images/nikeairfoceblack.webp",
                Img_1 = "/Images/img1.jpeg",
                Img_2 = "/Images/Img3.avif",


            },
            new Product
            {
                Id = 2,
                Nome_Articolo = "AdidasSneakersRed",
                Prezzo = 78.99m,
                Descrizione_Dettagliata = "Sneakers Rosse Adidas da Uomo",
                Immagine_Copertina = "/Images/adidasred.webp",
                Img_1 = "/Images/img3.webp",
                Img_2 = "Images/img4.webp",
            }
        };
    }
}
