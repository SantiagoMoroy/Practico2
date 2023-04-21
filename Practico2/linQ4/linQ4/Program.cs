using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace linQ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A)
            Console.WriteLine("A");
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            var suma = valores.Sum();
            Console.WriteLine($"la suma total es :{suma}");
            
            //B)
            Console.WriteLine("B");
            List<int> valoresB = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sumaTotalValoresPares = 0;
            var consulta = from n in valoresB where n % 2 == 0 select n;
            foreach (int valor in valores)
            {
                sumaTotalValoresPares = consulta.Sum();
            }

            Console.WriteLine($"La suma total de los valores pares es: {sumaTotalValoresPares}");
            Console.Read();
        }
    }
}
