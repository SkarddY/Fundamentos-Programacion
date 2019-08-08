using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingerese el número de datos: ");
            int datos = int.Parse(Console.ReadLine());
            double total = 0;
            int contador = 0;
            int maximo = 0;
            int minimo = 1000;
            string nMax = "";
            string nMin = "";


            while (contador < datos)
            {
                Console.WriteLine("Nombre: ");
                string n = (Console.ReadLine());
                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine());


                if (edad > maximo)
                {
                    maximo = edad;
                    nMax = n;
                }

                if (edad < minimo)
                {
                    minimo = edad;
                    nMin = n;
                }

                total += edad;
                contador += 1;
            }

                double promedio = total / contador;
                Console.WriteLine("Promedio: " + promedio);
                Console.WriteLine("Mayor: " + nMax + maximo);
                Console.WriteLine("Mínimo: " + nMin + minimo);

            

        }
    }

}
