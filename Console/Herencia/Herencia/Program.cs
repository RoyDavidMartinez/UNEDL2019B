using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            MamayApa Yo = new MamayApa();
            Yo.Nombre = "Roy";
            Yo.Apellido = "Martinez";
            Yo.Edad = "21";
            Console.WriteLine("El nombre es: " + Yo.Nombre);
            Console.WriteLine("El apellido es: " + Yo.Apellido);
            Console.WriteLine("la edad es: " + Yo.Edad);
            Yo.Cocinar("Roy");
            Yo.Rasurarse("Roy");
        }
    }
}
