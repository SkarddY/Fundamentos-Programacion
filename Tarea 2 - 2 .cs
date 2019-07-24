using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos_Tarea_2

{
    class Program
    {
        static void Main(string[] args)
        {

            // Datos conocidos

            Console.WriteLine("Ingresa los datos conocidos dos ángulos y un lado para hallar z ");
            Console.Write("Ángulo d ");
            double dgrados = double.Parse(Console.ReadLine());
            Console.Write("Ángulo b ");
            double bgrados = double.Parse(Console.ReadLine());
            Console.Write("Lado y ");
            double y = double.Parse(Console.ReadLine());

            // Valores

            double f = 180 - 90 - dgrados;
            double a = f - bgrados;
            double c = 90 - a;
            
            //Radianes

            double c1 = (c * Math.PI) / 180.0;
            double a1 = (a * Math.PI) / 180.0;

            double z = y * Math.Sin(c1) / Math.Sin(a1);


            Console.WriteLine("Z = ");
            Console.WriteLine(z);

        }

    }
}
