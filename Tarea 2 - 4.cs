using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2___1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Con el ángulo c y los lados w y t, halle x ");
            Console.Write("Ángulo c ");
            double cgrados = double.Parse(Console.ReadLine());
            Console.Write("Lado w ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Lado t ");
            double t = double.Parse(Console.ReadLine());

            //Operaciones 

            double e = (180 - cgrados);

            double e1 = (e * Math.PI) / 180.0; 

            double d = Math.Asin(t * Math.Sin(e1) / w);

            double dgrados = (d * 180.0) / Math.PI;

            double b = 180 - dgrados - e;

            double b1 = (b * Math.PI) / 180.0;

            double x = w * Math.Sin(b1) / Math.Sin(e1);

            Console.Write("Lado x = ");
            Console.Write(x);
        }
    }
}
