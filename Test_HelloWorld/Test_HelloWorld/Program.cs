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
            Int32 leeftijd;
            Console.WriteLine("version 0.1.1");
            //here comes the logic
            Console.WriteLine("Geef je leeftijd op=:");
            leeftijd = Convert.ToInt32(Console.ReadLine());
            naam = Console.ReadLine();
            Console.WriteLine("Hello " + naam + " (" + leeftijd.ToString() + ")");
            Console.ReadLine();
        }
    }
}
