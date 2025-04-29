using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trapez trapez = new Trapez();
            trapez.read_data();
            trapez.show_results();
            Console.ReadKey();
        }
    }
}
