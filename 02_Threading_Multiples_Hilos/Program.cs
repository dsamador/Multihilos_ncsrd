using System;
using System.Threading;

namespace _02_Threading_Multiples_Hilos
{
    internal class Program
    {
        private static bool ejecutar = true;
        static void Main(string[] args)
        {
            int m = 0;
            int x = 0;

            // Creamos el hilo y lo ararncamos
            Thread miHilo = new Thread(Mensaje);
            miHilo.Start();

            //simula que main lleva a cabo sus propias acciones
            while (ejecutar)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Saludos desde hilo principal {m}");
                m++;
                if(m == 500)
                    ejecutar = false;
            }
        }
        static void Mensaje()
        {
            int n = 0;
            while (ejecutar)
            {                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Saludos desde hilo {n}");
                n++;
            }
        }
    }
}
