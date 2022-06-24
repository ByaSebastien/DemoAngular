using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logique
{
    internal class NombresDigitaux : ICommand
    {
        public string Name => "Nombres digitaux";

        public void Execute()
        {
            int nombre = -1;

            Digit[] DigitArray = new Digit[10];

            DigitArray = InitDigit(DigitArray);
            Console.WriteLine("Entrez un nombre de 0 à 999");
            while (nombre > 999 || nombre < 0)
            {
            nombre = int.Parse(Console.ReadLine());
            }
            if (nombre > 100)
            {
                Console.WriteLine(DigitArray[nombre % 1000 / 100].top + ' ' + DigitArray[nombre % 100 / 10].top + ' ' + DigitArray[nombre % 10].top);
                Console.WriteLine(DigitArray[nombre % 1000 / 100].mid + ' ' + DigitArray[nombre % 100 / 10].mid + ' ' + DigitArray[nombre % 10].mid);
                Console.WriteLine(DigitArray[nombre % 1000 / 100].bot + ' ' + DigitArray[nombre % 100 / 10].bot + ' ' + DigitArray[nombre % 10].bot);
            }
            else if (nombre > 10)
            {
                Console.WriteLine(DigitArray[nombre % 100 / 10].top + ' ' + DigitArray[nombre % 10].top);
                Console.WriteLine(DigitArray[nombre % 100 / 10].mid + ' ' + DigitArray[nombre % 10].mid);
                Console.WriteLine(DigitArray[nombre % 100 / 10].bot + ' ' + DigitArray[nombre % 10].bot);
            }
            else
            {
                Console.WriteLine(DigitArray[nombre].top);
                Console.WriteLine(DigitArray[nombre].mid);
                Console.WriteLine(DigitArray[nombre].bot);
            }



        }

        private Digit[] InitDigit(Digit[] digitArray)
        {
            digitArray[0] = new Digit(" _ ", "| |", "|_|");
            digitArray[1] = new Digit("   ", " | ", " | ");
            digitArray[2] = new Digit(" _ ", " _|", "|_ ");
            digitArray[3] = new Digit(" _ ", " _|", " _|");
            digitArray[4] = new Digit("   ", "|_|", "  |");
            digitArray[5] = new Digit(" _ ", "|_ ", " _|");
            digitArray[6] = new Digit(" _ ", "|_ ", "|_|");
            digitArray[7] = new Digit(" _ ", " _|", "  |");
            digitArray[8] = new Digit(" _ ", "|_|", "|_|");
            digitArray[9] = new Digit(" _ ", "|_|", " _|");

            return digitArray;
        }

        public struct Digit
        {
            public string top = "";
            public string mid = "";
            public string bot = "";

            public Digit(string top, string mid, string bot)
            {
                this.top = top;
                this.mid = mid;
                this.bot = bot;
            }
        }
    }
}
