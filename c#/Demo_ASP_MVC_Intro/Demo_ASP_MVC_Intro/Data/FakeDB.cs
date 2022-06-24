using Demo_ASP_MVC_Intro.Models;

namespace Demo_ASP_MVC_Intro.Data
{
    public static class FakeDB
    {
        public static IEnumerable<Duck> Ducks = new List<Duck>
        {
            new Duck
            {
                Id = 1,
                FirstName = "Zaza",
                LastName = "Vanderquack",
                Birthdate = new DateTime(2006,11,20),
                Address = "Lac du village"
            },
            new Duck
            {
                Id = 2,
                FirstName = "Zizou",
                LastName = "LaTetePenssante",
                Birthdate = new DateTime(1991,05,01),
                Address = "Le bled"
            },
            new Duck
            {
                Id = 3,
                FirstName = "Zizi",
                LastName = "Vanderquock",
                Birthdate = new DateTime(2003,01,01),
                Address = "Slip d'à coté"
            },
        };
    }
}
