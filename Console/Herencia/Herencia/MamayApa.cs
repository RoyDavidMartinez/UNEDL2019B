using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
   

    }
    class MamayApa
    {
    private string nombre;
    private string apellido;
    private string edad;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public string Edad { get => edad; set => edad = value; }

    public void Cocinar(String nombre)
    {
        Console.WriteLine("" + nombre + " Aprendio a cocinar por parte de my mommy");
    }
    public void Rasurarse(String nombre)
    {
        Console.WriteLine("" + nombre + " Aprendio a rasurarse por parte de mi padre");
    }



}
