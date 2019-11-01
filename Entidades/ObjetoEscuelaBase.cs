using System;

namespace CoreEscuela.Entidades
{
    public class ObjetoEscuelaBase
    {
        public string Nombre { get; set; }
        public string UniqueId { get; private set; }

        public ObjetoEscuelaBase()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}