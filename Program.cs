using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Coloca tu peso y estatura");
            Console.Write("Peso ");
            double p = double.Parse(Console.ReadLine());
            Console.Write("Estatura ");
            double e = double.Parse(Console.ReadLine());

            double IMC = p / e;

            if (IMC < 15)
            {
                Console.WriteLine("Delgadez muy severa");
            }
            else if (15.1 <= IMC & IMC <= 15.9)
            {
                Console.WriteLine("Delgadez severa");
            }
            else if (16 <= IMC & IMC <= 18.4)
            {
                Console.WriteLine("Delgadez");

            }
            else if (18.5 <= IMC & IMC <= 24.9)
            {
                Console.WriteLine("Peso saludable");
            }
            else if (25 <= IMC & IMC <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (30 <= IMC & IMC <= 34.9)
            {
                Console.WriteLine("Obesidad moderada");
            }
            else if (35 <= IMC & IMC <= 39.9)
            {
                Console.WriteLine("Obesidad severa");
            }
            else if (IMC > 40)
            {
                Console.WriteLine("Obesidad morbida");
            }


            Console.WriteLine(IMC);

        }


    }
}
