using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos1.ConsoleApp
{
    public class Controlador
    {
        //insert dos valores
        public int x;
        public int y;
        public int z;

        //validacao das variaveis com os valores
        public void Calculo()
        {
            if (x == y && y == z)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Triangulo Equilátero");
                Console.ResetColor();
            }

            if (x != y || y != z || x != z)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Triangulo Isóceles");
                Console.ResetColor();
            }

            else if (x != y || y != z || x != z)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Triangulo Escaleno");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Triangulo Inválido");
                Console.ResetColor();
            }
        }
    }
}

