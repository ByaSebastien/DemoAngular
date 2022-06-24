using System.ComponentModel.DataAnnotations;

namespace Exercice2_ASP_MVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? Reduction { get; set; }
        public string Reference { get; set; }
        public int QuantityInStock { get; set; }
    }
    public class ProductForm
    {
        [Required(ErrorMessage = "Le nom du produit est obligatoire !")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le nom du produit est invalid")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Le description du produit est obligatoire !")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Le prix du produit est obligatoire !")]
        [Range(0, double.MaxValue, ErrorMessage = "Le prix du produit est invalid")]
        public decimal? Price { get; set; }
        [Range(1, 90, ErrorMessage = "La réduction du produit est invalid")]
        public int? Reduction { get; set; }
        [Required(ErrorMessage = "La réference du produit est obligatoire !")]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "La référence du produit est invalid (7 charactère)")]
        public string Reference { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "La quantité en stock doit être positive")]
        public int? QuantityInStock { get; set; }
    }
}
