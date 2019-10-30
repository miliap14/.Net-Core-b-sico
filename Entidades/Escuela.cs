
using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades //Dentro de este espacio creamos todas las entidades
{
    public class Escuela
    {
        //Atribuos -> Cualidades, adjetivos, lo que es
        //Metodos -> Acciones
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
        string nombre;
        public string Nombre 
        { 
            get { return nombre; } 
            set { nombre = value.ToUpper(); } 
        } //Esto es un encapsulamiento para evitar que en
        //un futuro necesitemos cambiar el nombre y asi no
        //no tenemos que cambiar todo el codigo

        public int AñoDeCreación {get; set;}
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }

        public Escuela (string nombre, int año, TiposEscuela tipo, string pais = "Argentina", string ciudad = "Sunchales")
        {
            Nombre = nombre;
            AñoDeCreación = año;
            TipoEscuela = tipo;
            Pais = pais;
            Ciudad = ciudad;
        }


        public override string ToString() //Con este metodo, sobre escribimos lo que para C# es una escuela y le decimos lo que ahora vale.
        {
            return $"Nombre: {nombre}, Tipo: {TipoEscuela}\nAño: {AñoDeCreación}, Pais: {Pais}, Ciudad: {Ciudad}";
        }

        //Inicializar la escuela
        /*Todo objeto cuenta con un constructuro que nos ayuda a crear una
        instancia del objeto. */

    }
}