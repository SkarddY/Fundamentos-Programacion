using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            int numerojugadores = 0, jugadores = 0, a = 0, b = 0, c = 0, d = 0, e = 0, A = 0, B = 0;

            while (true)
            {
                Console.WriteLine("Ingrese el numero de jugadores: ");
                numerojugadores = int.Parse(Console.ReadLine());

                if (numerojugadores <= 1)
                {
                    Console.WriteLine("Deben sere entre 2 a 5 personas, ingrese de nuevo");
                }
                if (numerojugadores > 5)
                {
                    Console.WriteLine("Deben sere entre 2 a 5 personas, ingrese de nuevo");
                }
                else if (numerojugadores >= 2 && numerojugadores <= 5)
                {

                    break;
                }
            }

 
                while (true)
                {

                Random aleatorio = new Random();
                jugadores++;
                Console.WriteLine("Turno del jugador " + jugadores);
                int carta1 = aleatorio.Next(1, 11);
                int carta2 = aleatorio.Next(1, 11);
                Console.WriteLine("Carta 1: " + carta1);
                Console.WriteLine("Carta 2: " + carta2);

                int cartaextra = 0;
                int total = carta1 + carta2;
                string pedir = "s";

                while (pedir == "s" && total < 21)
                {
                    Console.WriteLine("Total: " + total);
                    Console.Write("Pedir carta (s): ");
                    pedir = Console.ReadLine();

                    if (total <= 21)
                    {
                        cartaextra = aleatorio.Next(1, 11);
                        Console.WriteLine("Carta extra: " + cartaextra);
                        total += cartaextra;
                    }
                }
                if (total > 21) Console.WriteLine("Perdiste con un total de: " + total);
                Console.WriteLine("Gracias por participar ");

                if (numerojugadores == jugadores)
                {
                    Console.WriteLine("FIN DEL JUEGO");
                    break;
                }

                for (int i = 1; i >= numerojugadores; i++)
                {
                    if (i == 1) a = total;
                    else if (i == 2) b = total;
                    else if (i == 3) c = total;
                    else if (i == 4) d = total;
                    else if (i == 5) e = total;
                    total = 0;

                    if (c == 0 && d == 0 && e == 0)
                    {
                        A = Math.Max(a, b);
                        B = Math.Min(a, b);
                    }
                    else if (d == 0 && e == 0);
                    {
                        A = Math.Max(a, Math.Max(b, c));
                    }

                }

                

                }

            Console.WriteLine("Ha ganado el jugador 1 con: " + A + " puntos");

            if (e == 0)
            {
                A = Math.Max(Math.Max(a, d), Math.Max(b, c));
            }
            else
                A = Math.Max(e, Math.Max(Math.Max(a, d), Math.Max(b, c)));
            Console.WriteLine("Ha ganado el jugador 1 con: " + A + " puntos");


        }
    }
}
