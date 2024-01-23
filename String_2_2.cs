using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NizZnakova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi neki niz: ");
            string unos = Console.ReadLine();

            if (unos.Length < 5)
            {
                Console.WriteLine("Ispis: " + unos);
            }
            else
            {
                Console.WriteLine("Ispis: " + unos.Substring(2, unos.Length -4));
            }

            Console.ReadKey();
        }
    }
}
