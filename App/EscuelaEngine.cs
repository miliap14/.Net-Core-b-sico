using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public sealed class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

            //A pesar de que podríamos poner dentro del constructor los cursos, no lo hacemos
            //Ya que más adelante, vamos a agregar calificaciones, alumnos y demás y, en un escenario
            //Real, vamos a conectar todo esto con una base de datos, lo cual va a volver muy lerdo
            //Al constructor y necesitamos que este sea lo más rápido posible.
        }

        public void Inicializar() //Va a ser el encargado de inicializar todo
        {
            Escuela = new Escuela("CorMaker Academy", 2019, TiposEscuela.Primaria);

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        public void CargarEvaluaciones()
        {
            var lista = new List<Evaluación>();
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random();

                        for (int i = 0; i < 5; i++)
                        {
                            var eval = new Evaluación
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i+1}",
                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(eval);
                        }
                    }
                }
                
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>()
                {
                    /*Esta Lista se encuentra acá dentro porque cada materia se genera con un único ID, si lo hacemos fuera del foreach se cargarían asignaturas con el mismo ID dentro del mismo curso. De esta forma, cada curso tiene una asignatura con un ID distinto; Es decir: Curso 101 va a tener Matemáticas con un ID, curso 201 va a tener matemática pero con otro ID y así sucesivamente. */
                    new Asignatura{ Nombre = "Matemáticas"},
                    new Asignatura{ Nombre = "Educación Física"},
                    new Asignatura{ Nombre = "Castellao"},
                    new Asignatura{ Nombre = "Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar( int cantidad )
        {
            string[] nombre1 = {"Emiliano", "Martín", "Eduardo", "Juan", "Gastón", "Alejandro"};
            string[] apellido1 = {"Piovano", "Pomella", "Nóbrega", "Malacalza", "Ripol", "Almada"};
            string[] nombre2 = {"Jesús", "Oscar", "Ceferino", "Francisco", "David", "Omar"};

            var listaAlumnos = from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno{ Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy( (al) => al.UniqueId ).Take(cantidad).ToList(); //Con este parametro, pedimos que tome una cierta cantidad de alumnos


        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>{
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso(){ Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso(){ Nombre = "301", Jornada = TiposJornada.Mañana},
                new Curso(){ Nombre = "401", Jornada = TiposJornada.Tarde},
                new Curso(){ Nombre = "501", Jornada = TiposJornada.Tarde},
            };

            Random rnd = new Random();

            

            foreach (var cr in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5, 20);
                cr.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }
    }
}