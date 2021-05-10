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

            controladores.x = 5;
            controladores.y = 5;
            controladores.z = 2;

            controladores.Calculo();

            Console.ReadLine();
        }
    }
}

