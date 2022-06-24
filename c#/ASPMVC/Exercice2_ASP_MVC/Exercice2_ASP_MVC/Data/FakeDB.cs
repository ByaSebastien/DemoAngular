using Exercice2_ASP_MVC.Models;

namespace Exercice2_ASP_MVC.Data
{
    public static class FakeDB
    {
        public static ICollection<Product> Products = new List<Product>
        {
            new Product
            {
                Name = "Produit",
                Description = "Un beau produit...",
                Price = 10,
                Reduction = 25,
                Reference = "a3645d8",
                QuantityInStock = 0
            },
            new Product
            {
                Name = "Produit2",
                Description = "Un deuxieme beau produit...",
                Price = 15,
                Reduction = 80,
                Reference = "b2315g4",
                QuantityInStock = 2
            },
            new Product
            {
                Name = "Produit3",
                Description = "Un autre beau produit...",
                Price = 20,
                Reduction = 5,
                Reference = "f5642f3",
                QuantityInStock = 5
            },
        };
    }
}
