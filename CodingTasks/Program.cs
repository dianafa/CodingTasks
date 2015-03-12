using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PascalsTriangle PT = new PascalsTriangle();
            var result = PT.Generate(5);
            Console.WriteLine("wynik:" + result);
            Console.ReadLine();
        }
    }
}
