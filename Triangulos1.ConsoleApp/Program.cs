using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos1.ConsoleApp
{
    class Program
    {
        static Controlador controladores = new Controlador();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Triangulo 1.1\n");
            Console.ResetColor();

            controladores.lado1 = 5;
            controladores.lado2 = 5;
            controladores.lado3 = 2;

            controladores.Calculo();

            Console.ReadLine();
        }
    }
}

