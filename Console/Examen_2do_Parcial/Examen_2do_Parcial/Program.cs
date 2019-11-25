using System;
using System.Collections;

namespace Examen_2do_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Checador = new Stack();
            Checador.Push("{{}{}{{{}}");
            Checador.Push("{{}{{{{}}}");
            Checador.Push("{{{{}{}}}}");
            Checador.Push("{{}{}}{{}}");

            Checador.Pop();
        }
    }
}
