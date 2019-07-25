using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa tu salario mensual: ");
            double salario = double.Parse(Console.ReadLine());

            double smmlv = 828116;

            if (salario < smmlv * 2)
            {
                Console.Write("Pagas la tarifa A.");

            }
            else if (2 * smmlv <= salario && salario <= 4 * smmlv)
            {
                Console.Write("Pagas la tarifa B ");
            }
            else if (salario> 4 * smmlv){
                Console.Write("Pagas la tarifa C ");
            }

            








        }
    }
}
