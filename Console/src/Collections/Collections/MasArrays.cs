using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Collections
{
    class MasArrays
    {
        public void Sorted()
        {
            SortedList sl = new SortedList();
            sl.Add(1,"Valor 1");
            sl.Add(5,"Valor 5");
            sl.Add(3,"valor 3");
            ICollection llave = sl.Keys;
            foreach(var k in llave)
            {
                Console.WriteLine("llave: " + k + "\nvalor: " + sl[k]);
            }

        }
    }
}
