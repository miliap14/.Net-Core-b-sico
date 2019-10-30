using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Sancor Academy", 2019, TiposEscuela.Primaria);
            
            escuela.Cursos = new List<Curso>{
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso(){ Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso(){ Nombre = "301", Jornada = TiposJornada.Mañana},
            };
            
            escuela.Cursos.Add( new Curso (){ Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add( new Curso (){ Nombre = "202", Jornada = TiposJornada.Tarde });

            var otraColeccion = new List<Curso>{
                new Curso(){ Nombre = "101"},
                new Curso(){ Nombre = "201"},
                new Curso(){ Nombre = "301"},
            };

            escuela.Cursos.AddRange();
        

            Console.WriteLine(escuela);
            System.Console.WriteLine("============");
            ImprimirCursosEscuela(escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("====================");
            WriteLine("Cursos de la escuela");
            WriteLine("====================");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Curso: {curso.Nombre}, Id: {curso.UniqueId}");
                }
            }
        }
    }
}
