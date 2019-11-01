
using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades //Dentro de este espacio creamos todas las entidades
{
    public class Escuela: ObjetoEscuelaBase
    {
        //Atribuos -> Cualidades, adjetivos, lo que es
        //Metodos -> Acciones
      
        public int AñoDeCreación {get; set;}
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }
        public Escuela( string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año);

        public Escuela ( string nombre, int año, TiposEscuela tipos, string pais = "", string ciudad = "") : base()
        {
            (Nombre, AñoDeCreación) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine}, País: \"{Pais}\", Ciudad: \"{Ciudad}\"";
        }

        //Inicializar la escuela
        /*Todo objeto cuenta con un constructuro que nos ayuda a crear una
        instancia del objeto. */

    }
}