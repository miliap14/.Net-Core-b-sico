using System;
using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer //Es estática porque no permite crear nuevas instancias. Puedo utitlizar todo lo que tiene.
    {
        public static void DrawLine( int tam = 20)
        {
            WriteLine("".PadLeft(tam, '='));
        }

        public static void WriteTitle( string titulo )
        {  
            var tamaño = titulo.Length + 4;
            DrawLine(tamaño);
            WriteLine($"| {titulo} |");
            DrawLine(tamaño);
        }

        public static void Beep( int hz = 2000, int tiempo = 500, int cantidad = 3 )
        {
            while (cantidad-- > 0)
            {
                Console.Beep(hz, tiempo);
            }
        }
    }
}