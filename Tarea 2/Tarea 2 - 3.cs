using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Con los datos w, d y x, hallar y");

            Console.Write("Lado w  ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Lado x ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Ángulo d ");
            double dgrados = double.Parse(Console.ReadLine());

            //Operaciones

            double d = dgrados * Math.PI / 180.0;

            double z = w * Math.Sin(d);

            double f = Math.Sqrt(w * w - z * z);

            double y = f - x;

            Console.Write("Lado y ");
            Console.WriteLine(y);
        }


    }
}
