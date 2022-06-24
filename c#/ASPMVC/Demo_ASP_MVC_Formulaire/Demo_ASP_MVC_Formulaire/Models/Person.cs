using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Demo_ASP_MVC_Formulaire.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Secret { get; set; }
    }
    public class PersonForm
    {
        [DisplayName("Prénom")]
        [Required(ErrorMessage = "Le prénom est obligatoire")]
        [StringLength(50,MinimumLength = 2,ErrorMessage = "Prénom invalide")]
        public string Firstname { get; set; }
        [DisplayName("Nom")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Lastname { get; set; }
        [DisplayName("Mail")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [DisplayName("Secret")]
        [DataType(DataType.Password)]
        public string? Secret { get; set; }
    }
}
