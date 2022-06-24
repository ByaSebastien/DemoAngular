using Labo_ASP_MVC.Models;

namespace Labo_ASP_MVC.Data
{
    public static class FakeDB
    {
        public static IList<Whisky> Whiskies = new List<Whisky>
        {
            new Whisky
            {
                Id = 1,
                Name = "Blue Label",
                Origin = "Irlandais",
                Image = "blue.jpg",
                Description = "les premières notes rappellent la noisette, le miel, la cerise et l'orange avant de libérer des saveurs plus complexes de gingembre, kumquats, bois de santal et chocolat noir. En longueur, la douceur du miel accompagnée de poivre et de fruits secs vient enrichir la dégustation avec beaucoup de velours."
            },
            new Whisky
            {
                Id = 2,
                Name = "jack daniel's",
                Origin = "Tennessee",
                Image = "jack.jpg",
                Description = "Avec ses 74 chais de vieillissement renfermant 1,6 millions de fûts, Jack Daniel’s est l’une des plus grandes distilleries au monde. Mais ce n’est certes pas ce gigantisme qui confère à celui que l’on surnomme « Jack » son caractère unique et ses arômes si distincts. Contrairement à ses cousines du Kentucky produisant du bourbon, Jack Daniel’s respecte le Lincoln County Process, un procédé unique qui consiste à faire passer le distillat à travers une couche de charbon d’érable avant sa mise en fût. Ceci permet de retenir les éléments les plus lourds et favorise l’homogénéité du distillat."
            },
            new Whisky
            {
                Id = 3,
                Name = "blanton's",
                Origin = "Kentucky",
                Image = "blanton.jpg",
                Description = "Premier bourbon à avoir été mis en bouteille fût par fût (single barrel) en 1983, Blanton's a révolutionné l'American whiskey. Il est élaboré au sein de la distillerie Buffalo Trace située au coeur du Kentucky. Ce straight bourbon porte le nom du colonel Blanton qui dirigea la distillerie de 1912 à 1953. Le créateur de Blanton's s'est inspiré de son prédécesseur, tirant profit de l'abandon du principe de rotation des fûts pour que chaque barrique acquière un profil aromatique unique. Blanton's offre ainsi un registre précis et gourmand de céréales, d'épices, de fruits confits, d'agrumes et de fleurs dans ses différentes expressions."
            },
        };
    }

}
