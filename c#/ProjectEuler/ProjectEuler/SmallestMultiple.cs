using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class SmallestMultiple : ICommand
    {
        public string Name => "Smallest Multiple";

        public void execute()
        {
            int number = 20;
            bool isMultiple = false;

            while (!isMultiple)
            {
                isMultiple = true;
                for (int div = 1 ; div <= 20 ; div++)
                {
                    if (number % div != 0)
                    {
                        isMultiple = false;
                        break;
                    }
                }
                if(isMultiple)
                {
                    Console.WriteLine(number);
                }
                number+=20;
            }
        }
    }
}
