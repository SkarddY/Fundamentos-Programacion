using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 2
            Console.Write("Para el triángulo rectangulo tzy ingrese los valores de t y el ángulo a ");
            Console.WriteLine("");
            Console.Write("Valor del lado t = ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Valor del ángulo a (en grados) = ");
            double a = double.Parse(Console.ReadLine());

            // Ángulo v
            Console.Write("Valor del ángulo v = ");

            double v = (180 - 90 - a);
            Console.WriteLine(v);
            double v1 = v * (Math.PI / 180);
            
            // Lado z
            Console.Write("Valor del lado z = ");

            double z = (Math.Sin(v1)*t / 1 );
            Console.Write(z);

            // Lado y
            Console.Write(" Valor del lado y = ");

            double y = Math.Sqrt(t * t - z * z);
            Console.WriteLine(y);            



        }
    }
}
