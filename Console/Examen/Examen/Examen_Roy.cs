
/*Roy David Martinez Gomez
 * Dado un monto de dinero, haga un algortimo que encuentre la cantidad maxima de elementos 
 * que pueden ser comprados de una lista de precios dada.
 * Ejemplo:
 * Cantidad de dinero: 50
 * Cantidad de precios: 7
 * Elementos: 1, 12, 5, 111, 200, 1000, 10
 * Resultados: 4
 */
using System;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int money,cantidad=4,resultado=0;
            Console.WriteLine("Ingrese la cantidad de dinero que tiene:");
            money = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad de dinero: "+money);
            Console.WriteLine("Cantidad de precios: "+cantidad);
            Console.WriteLine("Elementos: 1, 12, 5, 11");
            if (money-1 >= 0)
            {
                resultado++;
            }
            if (money - 12 >= 0)
            {
                resultado++;
            }
            if (money - 5 >= 0)
            {
                resultado++;
            }
            if (money - 11 >= 0)
            {
                resultado++;
            }
            Console.WriteLine("Resultados: "+resultado);

        }
    }
}
