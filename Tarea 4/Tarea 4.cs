using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los Votos A: ");
            int votosA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los Votos B: ");
            int votosB = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los Votos en blanco: ");
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los anulados: ");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la poblacion total de tu region: ");
            int Ptotal = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de la poblacion adulta: ");
            int Padulto = int.Parse(Console.ReadLine());
            int AdultosRestantes = Ptotal - Padulto;
            Console.WriteLine("Adultos sin votar: " + AdultosRestantes);

            int Df = votosA - votosB;
            int VotosTotales = votosA + votosB + blanco + anulados;
            double y = 0.30 * Ptotal;
            double x = 0.10 * VotosTotales; // x = 10% votos totales

            bool a = VotosTotales > Ptotal;
            bool b = (Df < x);
            bool c = VotosTotales < y;

            if ((a || b) && (c))
            {
                Console.Write("Las votaciones deben repetirse");
            }
            else
            {
                if (votosA > votosB)
                {
                    Console.WriteLine("Gana A");
                }
                else
                {
                    Console.WriteLine("Gana B");
                }

            }





        }
    }
}
