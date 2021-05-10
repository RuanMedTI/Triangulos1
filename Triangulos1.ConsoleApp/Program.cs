using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos1.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Triangulo 1.1\n");
            Console.ResetColor();

            Triangulo triangulos = new Triangulo();

            triangulos.lado1 = 5;
            triangulos.lado2 = 5;
            triangulos.lado3 = 2;

            triangulos.Calculo();

            Console.ReadLine();
        }
    }
}

