using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Exercice_3_List.Models
{
    public enum TypeDePlat { Entrée, Plat, Dessert, Apéro };
    public class Plat
    {
        public Guid Id { get; set; }
        [DisplayName("Nom")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Origine")]
        public string? Origin { get; set; }
        [DisplayName("Type de plat")]
        [Required]
        public TypeDePlat? Type { get; set; }
        [DisplayName("Description")]
        [Required]
        public string? Description { get; set; }
        [DisplayName("Liste d'ingrédients")]
        public IList<string>? Ingredients { get; set; }
    }
    public class PlatForm
    {
        [DisplayName("Nom")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Origine")]
        public string? Origin { get; set; }
        [DisplayName("Type de plat")]
        [Required]
        public TypeDePlat? Type { get; set; }
        [DisplayName("Description")]
        [Required]
        public string? Description { get; set; }
        public IList<string>? Ingredients { get; set; }
        public int NombreIngredients { set; get; }
    }
    public class PlatInter
    {
        [DisplayName("Nom du plat")]
        public string Name { get; set; }
        [DisplayName("Nombre d'ingrédient")]
        [Required]
        [Range(1, int.MaxValue)]
        public int? NombreIngredients { set; get; }
    }
}
