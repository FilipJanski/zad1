using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Trapez
    {
        private double a;
        private double b;
        private double surface_area;
        private double h;

        public void read_data()
        {
            Console.Write("podaj podstawe a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("podaj podstawe b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("podaj wysokosc h: ");
            h = Convert.ToDouble(Console.ReadLine());
        }
        private double process_data()
        {
            return surface_area=(a+b)*h/2;
        }
        public void show_results()
        {
            process_data();
            System.Console.WriteLine(surface_area);
        }
    }
}
