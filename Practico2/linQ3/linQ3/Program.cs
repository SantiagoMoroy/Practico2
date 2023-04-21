using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linQ3
{
    internal class Program
    {
        static void Main(string[] args)                      //la funcion anterior valia 4 de complejidad cognitiva
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var consulta = from n in valores where n > 0 select n;
            foreach( int item in consulta )
            {
                Console.WriteLine( item.ToString() );
            }
            Console.Read();
        }
    }
}
