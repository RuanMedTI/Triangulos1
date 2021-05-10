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
        public int lado1;
        public int lado2;
        public int lado3;

        //validacao das variaveis com os valores
        public void Calculo()
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Triangulo Equilátero");
                Console.ResetColor();
            }

            if (lado1 != lado2 || lado2 != lado3 || lado1 != lado3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Triangulo Isóceles");
                Console.ResetColor();
            }

            else if (lado1 != lado2 || lado2 != lado3 || lado1 != lado3)
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

