using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.Write("ingrese su Salario Mensual ");
            double neto = double.Parse(Console.ReadLine());
            Console.WriteLine("¿Trabaja de forma Dependiente o Independiente?");
            Console.WriteLine("1 - Dependiente, 2 - Independiente ");
            int opcion = int.Parse(Console.ReadLine());
            double ARL = 0;
            double Salario = neto * 0.4;

            switch (opcion)
            {
                case 1:
                    double pension = Salario * 4 / 100;
                    double EPS = Salario * 4 / 100;
                    double Deducciones = -pension - EPS - ARL;
                    Console.Write("Total deducciones ");
                    Console.WriteLine(Deducciones);
                    double SalarioReal = neto + Deducciones;
                    Console.WriteLine("Salario real ");
                    Console.WriteLine(SalarioReal);
                    double SalarioAnual = SalarioReal * 12 + neto;
                    Console.WriteLine("Su salario anual es ");
                    Console.WriteLine(SalarioAnual);
                    break;

                case 2:

                    double pension2 = Salario * 16 / 100;
                    double EPS2 = Salario * 12.5 / 100;
                    Console.WriteLine("Marque del 1 al 5 su nivel de riesgo ");
                    int riesgo = int.Parse(Console.ReadLine());
                    switch (riesgo)
                    {
                        case 1:
                            ARL = Salario * 0.522 / 100;
                            break;
                        case 2:
                            ARL = Salario * 1.044 / 100;
                            break;

                        case 3:
                            ARL = Salario * 2.436 / 100;
                            break;
                        case 4:
                            ARL = Salario * 4.350 / 100;
                            break;

                        case 5:

                            ARL = Salario * 6.960 / 100;
                            break;


                    }


                    double deducciones = -pension2 - EPS2 - ARL;
                    Console.WriteLine("Sus Deducciones son ");
                    Console.WriteLine(deducciones);
                    double SalarioReal2 = neto + deducciones;
                    Console.WriteLine("Salario real " + SalarioReal2);
                    double SalarioAnual2 = SalarioReal2 * 12;
                    Console.WriteLine("Su salario anual es " + SalarioAnual2);

                    break;

            }
        }
    }
}
