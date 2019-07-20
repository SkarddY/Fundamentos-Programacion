using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Para el triángulo rectangulo JKZ ingrese los valores conocidos del lado Z y el ángulo n ");
            Console.WriteLine(" ");
            Console.Write("Valor lado Z = ");
            double Z = double.Parse(Console.ReadLine());
            Console.Write("Ángulo n (en grados) = ");
            double n = double.Parse(Console.ReadLine());

            //Ángulo m
            Console.Write("Valor del ángulo m = ");
            double m = (180 - 90 - n);
            Console.WriteLine(m);

            double n1 = (n * Math.PI) / 180.0;
            double m1 = (m * Math.PI) / 180.0;

            //Lado K
            Console.Write("Valor del lado K = ");
            double K = (Math.Sin(m1) * Z) / Math.Sin(n1);
            Console.WriteLine(K);

            //Lado J
            Console.Write("Valor del lado J = ");
            double J = Math.Sqrt(Z * Z + K * K);
            Console.WriteLine(J);

        }

    }
}
