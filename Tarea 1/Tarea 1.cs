using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación
{
    class Program
    {
        static void Main(string[] args)
        {

            //Problema 1

            Console.Write("Para el triángulo rectangulo XZY ingrese los valores de los lados Z y Y conocidos ");
            Console.WriteLine("");
            Console.Write("Valor Z = ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Valor Y = ");
            double y = double.Parse(Console.ReadLine());
       
            // Solucion
            Console.Write("Valor lado X = ");
            double x = Math.Sqrt(z * z + y * y);
            Console.WriteLine(x);

            Console.Write("Valor del ángulo w = ");
            double w = Math.Asin((1*z)/x);
            double w1 = (w * 180.0) / (Math.PI);
            Console.WriteLine(w1);

            Console.Write("Valor del ángulo v = ");
            double v = (180 - 90 - w1);
            Console.WriteLine(v);



        }

    }
}
