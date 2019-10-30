using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine ()
        {
            
            //A pesar de que podríamos poner dentro del constructor los cursos, no lo hacemos
            //Ya que más adelante, vamos a agregar calificaciones, alumnos y demás y, en un escenario
            //Real, vamos a conectar todo esto con una base de datos, lo cual va a volver muy lerdo
            //Al constructor y necesitamos que este sea lo más rápido posible.
        }

        public void Inicializar() //Va a ser el encargado de inicializar todo
        {
            Escuela = new Escuela("CorMaker Academy", 2019, TiposEscuela.Primaria);

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