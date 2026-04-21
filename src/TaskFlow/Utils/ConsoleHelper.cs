using System;

namespace TaskFlow.Utils
{
    internal class ConsoleHelper
    {
        public static void MostrarTitulo(string titulo)
        {
            Console.WriteLine($"\n{'='.ToString().PadRight(40, '=')}");
            Console.WriteLine($"  {titulo}");
            Console.WriteLine($"{'='.ToString().PadRight(40, '=')}");
        }

        public static void MostrarSeparador()
        {
            Console.WriteLine("-------------------------------------");
        }
    }
}