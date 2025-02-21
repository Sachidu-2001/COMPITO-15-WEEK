namespace WebAppEsame1.Models
{
    public class Scarpe
    {
        public static List<Product> ScarpeList = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Nome = "Nike Air Force Black",
                Prezzo = 120.99m,
                Descrizione = "Nike Snweakers Air Force da Uomo",
                Immagine_Copertina = "/Images/nikeairfoceblack.webp",
                Img_1 = "/Images/img1.jpeg",
                Img_2 = "/Images/img2.avif"
            },
            new Product() {
                Id = 2,
                Nome = "Adidas SuperStar Red",
                Prezzo = 79.99m,
                Descrizione = "Adidas Sneakers Rosse da Uomo",
                Immagine_Copertina = "/Images/adidasred.webp",
                Img_1 = "/Images/img3.webp",
                Img_2 = "/Images/img4.webp"
            },
            new Product()
            {
                Id = 3,
                Nome = "Yeezy Boost 350 Black&Blue",
                Prezzo = 339.00m,
                Descrizione = "Yeezy Boost 350 V2 Dazzling Blue",
                Immagine_Copertina = "/Images/yeezyboost.webp",
                Img_1 = "/Images/img5.webp",
                Img_2 = "/Images/img6.webp"
            },

            new Product()
            {
                Id= 4,
                Nome = "Lumberjack Boots",
                Prezzo = 54.99m,
                Descrizione = "Lumberjack River Boot Fur Lining Giallo Marrone",
                Immagine_Copertina = "/Images/lumberjack.jpg",
                Img_1 = "/Images/img7.jpeg",
                Img_2 = "/Images/img8.jpg"
            }
        };
    }

}