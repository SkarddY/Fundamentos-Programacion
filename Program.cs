using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void Main() {
        //Coordenadas para la pendiente

        Console.Write("Ingrese coordenadas en x1 "); 
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese coordenadas en y1 "); 
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese coordenadas en x2 "); 
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese coordenadas en y2 "); 
        double y2 = double.Parse(Console.ReadLine());
        Console.Write("Pendiente ");
        double m = (y2 - y1) / (x2 - x1);
        Console.WriteLine(m);

        //Intercepto
        Console.Write("Intercepto ");
        double b = y1 - m * x1;
        Console.WriteLine(b);

        //Distancia
        Console.Write("Distancia ");
        double d = Math.Sqrt(y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1);
        Console.WriteLine)(d);







    }
}
