using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
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
            CargarAlumnos();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
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
                curso.Asignaturas.AddRange(listaAsignaturas);
            }
        }

        private void CargarAlumnos()
        {
            throw new NotImplementedException();
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
        }
    }
}