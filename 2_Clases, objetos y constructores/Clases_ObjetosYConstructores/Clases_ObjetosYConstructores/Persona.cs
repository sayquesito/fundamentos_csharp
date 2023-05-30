using System;

namespace Clases_ObjetosYConstructores
{
    class Persona
    {
        // Campos
        public string Nombre;
        public int Edad;
        public char Genero;

       // Constructor predeterminado
        public Persona()
        {
            Nombre = "Nicole Cristina Felix Araujo";
            Edad = 24;
        }

        // Constructor con parámetros
        public Persona(string nombre, int edad ,char genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }

        // Método
        public void Saludarenespanol()
        {
            Console.WriteLine("Hola, mi nombre es " + Nombre + " y tengo " + Edad + " años, soy genero " + Genero ) ;
                    }
        public void Saludareningles ()    
        {
            Console.WriteLine("Hi, my name is " + Nombre + " I have " + Edad + " years old, my gender is " +Genero);
        }
    }
}
