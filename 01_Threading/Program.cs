using System;
using System.Threading; // 

namespace _01_Threading
{
    public class Program
    {
        static void Main(string[] args)
        {           
            //Forma de pasar datos al hilo
            Thread hilo2 = new Thread(MiMensaje);
            //al iniciar el hilo mandamos el mensaje
            hilo2.Start(5);
        }
        // Se ejecuta en el segundo hilo y recibe parametro
        static void MiMensaje(object o)
        {
            int m = Convert.ToInt32(o);
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine($"Saludos desde el mensaje {m}, {m * 2}");
        }
        static void Saludos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saludos desde el hilo");
        }        
    }
}
