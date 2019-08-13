using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0, carta3 = 0;
            int Puntos = 0;
            string continuar = "s";
            string cartaAdicional = "s";

            while (continuar == "s" && Puntos < 21 && cartaAdicional == "s")
            {
                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);


                Console.WriteLine("carta1: " + carta1);
                Console.WriteLine("carta2: " + carta2);
                Puntos += carta1 + carta2;
                Console.WriteLine("Puntos: " + Puntos);


                if (Puntos > 21)
                {
                    Console.WriteLine("No puedes continuar");
                }
                else if (Puntos == 21)
                {
                    Console.WriteLine("Ganaste");

                }
                else if (Puntos <= 21)
                {

                    Console.WriteLine("Tu total es: " + Puntos);
                    Console.Write("\nDesea continuar? (s/n)");
                    continuar = Console.ReadLine();
                    if (continuar == "n")
                    {
                        Console.WriteLine("Gracias por participar");
                    }
                    if (continuar == "s")
                    {
                        Console.WriteLine("\nDeseas una carta adicional? (1/0)");
                    }
                    int opcion = int.Parse(Console.ReadLine());
                    if (opcion == 1)
                    {
                        cartaAdicional = Console.ReadLine();
                        carta3 = aleatorio.Next(1, 11);


                        Console.WriteLine("carta3:" + carta3);

                        Console.WriteLine("carta1: " + carta1);
                        Console.WriteLine("carta2: " + carta2);
                        Puntos += carta1 + carta2 + carta3;
                        Console.WriteLine("Puntos: " + Puntos);
                    }


                    if (Puntos > 21)
                    {
                        Console.WriteLine("No puedes continuar");
                    }
                    else if (Puntos == 21)
                    {
                        Console.WriteLine("Ganaste");

                    }




                }
            }
        }
    }
}
