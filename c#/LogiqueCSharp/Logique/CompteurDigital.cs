using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logique
{
    internal class CompteurDigital : ICommand
    {
        public string Name => "Compteur digital";

        public void Execute()
        {
            for (int centaine = 0; centaine < 10; centaine++)
            {
                for (int dizaine = 0; dizaine < 10; dizaine++)
                {
                    for (int unite = 0; unite < 10; unite++)
                    {
                        Console.WriteLine(centaine+""+dizaine+""+unite);
                    }
                }
            }
        }
    }
}
