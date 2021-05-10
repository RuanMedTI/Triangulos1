using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos1.ConsoleApp
{
    public class Triangulo
    {
        //insert dos valores
        public int lado1;
        public int lado2;
        public int lado3;

        //validacao das variaveis com os valores
        public string Calculo()
        {

            if (lado1 == lado2 && lado2 == lado3)
            {               
                return "Triangulo Equilátero";                
            }

            if (lado1 != lado2 || lado2 != lado3 || lado1 != lado3)
            {                
                return "Triangulo Isóceles";               
            }

            else if (lado1 != lado2 || lado2 != lado3 || lado1 != lado3)
            {               
                return "Triangulo Escaleno";                
            }

            else
            {               
                return "Triangulo Inválido";                
            }
        }
    }
}

