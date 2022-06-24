using Exercice_3_List.Models;

namespace Exercice_3_List.Data
{
    public static class FakeDB
    {
        public static IList<Plat> Plats = new List<Plat>
        {
            new Plat
            {
                Id = Guid.NewGuid(),
                Name = "Banana split",
                Origin = "Djibouti",
                Type = TypeDePlat.Dessert,
                Description = "Superbe coupe glace vanille avec banane et chocolat",
                Ingredients = new List<string>
                {
                    "Glace Vanille",
                    "Banane",
                    "Chocolat"
                }
            }
        };
    }
}
