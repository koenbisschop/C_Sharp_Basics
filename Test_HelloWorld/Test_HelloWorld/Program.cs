using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            Console.WriteLine("version 0.1.1");
            //here comes the logic
            Console.WriteLine("Geef je voornaam:");
            naam = Console.ReadLine();
            Console.WriteLine("Hello " + naam);
            Console.ReadLine();
        }
    }
}
