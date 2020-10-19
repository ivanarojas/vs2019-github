using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona objetoPersona = new Persona("Ivana", "Rojas");
            objetoPersona.Apellido = "López";

            Persona objetoPersona2 = new Persona();
            objetoPersona2.Apellido = "Chanquia";
            objetoPersona2.Nombre = "Luis";
            Console.WriteLine(objetoPersona.ToString());
            Console.WriteLine(objetoPersona2.ToString());

            Console.WriteLine(Operaciones.Sumar(1, 2));

        }
    }
}
