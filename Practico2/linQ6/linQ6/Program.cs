using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linQ6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //i)la complejidad cognitiva del bloque es 6
        
          //ii)
            string letra = Console.ReadLine();
            List<string> letras = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h" };
            for (int i = 0; i < letras.Count; i++)
            {
                if (letras[i] == letra)
                {
                    Console.WriteLine($"la siguiente letra del abcdario es:{letras[i+1]}");
                }
            }


            Console.Read();
        }
    }
}
