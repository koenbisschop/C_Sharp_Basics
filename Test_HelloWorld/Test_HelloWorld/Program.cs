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
            DateTime geboorteDatum;
            Console.WriteLine("version 0.1.1");
            //here comes the logic
            Console.WriteLine("Geef je geboortedatum:");
            geboorteDatum = Convert.ToDateTime(Console.ReadLine());
            naam = Console.ReadLine();
            Console.WriteLine("Hello " + naam + "(" + geboorteDatum.ToString("dddd dd/MM/yy") + ")");
            Console.ReadLine();
        }
    }
}
