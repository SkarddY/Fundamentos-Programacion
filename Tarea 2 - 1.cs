using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Con los datos b, z, y hallar x ");
            Console.Write("Ángulo b ");
            double bgrados = double.Parse(Console.ReadLine());
            Console.Write("Lado z ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Lado y ");
            double y = double.Parse(Console.ReadLine());

            // Solución

            double c = Math.Atan(z / y);
            double c1 = c * 180.0 / Math.PI;

            double e = 180 - c1;

            double t = Math.Sqrt(z * z + y * y);
            double d = 180 - e - bgrados;

            //Radianes

            double b1 = bgrados * Math.PI / 180.0;
            double d1 = d * Math.PI / 180.0;

            double x = t * Math.Sin(b1) / Math.Sin(d1);


            Console.Write("Lado x ");
            Console.WriteLine(x);


        }
    }
}
