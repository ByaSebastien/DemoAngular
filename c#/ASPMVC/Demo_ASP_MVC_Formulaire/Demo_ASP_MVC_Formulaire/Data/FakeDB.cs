using Demo_ASP_MVC_Formulaire.Models;

namespace Demo_ASP_MVC_Formulaire.Data
{
    public static class FakeDB
    {
        public static ICollection<Person> Persons = new List<Person>
        {
            new Person
            {
                Id = 1,
                Firstname ="zaza",
                Lastname ="zizi",
                Email = "zazazizi@mail.com"
            },
            new Person
            {
                Id = 2,
                Firstname ="bobo",
                Lastname ="bubu",
                Email = "bobobubu@mail.com"
            },
            new Person
            {
                Id = 3,
                Firstname ="fufu",
                Lastname ="fofo",
                Email = "fufufofo@mail.com"
            },
        };
        public static int LastId { get; set; } = 3;
    }
}
