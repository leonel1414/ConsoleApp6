using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp6
{
    internal class Triangulo
    {
        private int lado1, lado2, lado3;
        private string? texto { get; set; }

        public void inicializar()
        {
            Console.WriteLine("Ingrese lado 1:");
            texto = Console.ReadLine();
            lado1 = Convert.ToInt32(texto);

            Console.WriteLine("Ingrese lado 2:");
            texto = Console.ReadLine();
            lado2 = Convert.ToInt32(texto);

            Console.WriteLine("Ingrese lado 3:");
            texto = Console.ReadLine();
            lado3 = Convert.ToInt32(texto);
        }

        public void LadoMayor()
        {
            if (lado1 > lado2 && lado1 > lado3)
            {
                Console.WriteLine("Lado Mayor: ");
                Console.WriteLine(lado1);
            }
            else
            {
                if (lado2 > lado1 && lado2 > lado3)
                {
                    Console.WriteLine(lado2);
                }
                else
                {
                    Console.WriteLine(lado3);
                }

            }

        }

        public void EsEquilatero()
        {
            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("Es equilatero");
            }
            else
            {
                Console.WriteLine("No es equilatero");
            }

        }

    }
}
