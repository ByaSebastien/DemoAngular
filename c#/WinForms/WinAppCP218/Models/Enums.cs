using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum Language
    {
        Inconnu,
        Duits,
        Engels,
        Frans,
        Nederlands,
    }
    public enum EmployeesNumber
    {
        Inconnu = 0,
        de_1_à_4 = 1,
        de_5_à_9 = 5,
        de_10_à_19 = 10,
        de_20_à_49 = 20,
        de_50_à_100 = 50,
        de_100_à_199 = 100,
        de_200_à_499 = 200,
        de_500_à_999 = 500,
        plus_de_1000 = 1000,
    }
}
