using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Persona
    {
        private string nombre=null;
        private string apellido=null;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string ToString()
        {
            return apellido + ", " + nombre;
        }
    }

}
