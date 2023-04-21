using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace linQ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int sumaTotalValoresParesMayoresAOcho = 0;
            int sumaTotalValoresParesMenoresAOcho = 0;

            for(int i = 2;i < valores.Count; i+=2) {          //+1
                if (valores[i] > 8)
                {
                    
                    sumaTotalValoresParesMayoresAOcho+=i;      //+2
                    Console.WriteLine("mayores="+sumaTotalValoresParesMayoresAOcho);               
                }
                else
                {
                    sumaTotalValoresParesMenoresAOcho+=i;     //+1
                    Console.WriteLine("menores="+sumaTotalValoresParesMenoresAOcho);
                }
            }
            Console.WriteLine($"La suma total de los valores pares mayores a ocho es: {sumaTotalValoresParesMayoresAOcho}");
            Console.WriteLine($"La suma total de los valores pares menores a ocho es: {sumaTotalValoresParesMenoresAOcho}");
            List<int> valores2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int sumaTotalValoresParesMayoresAOcho2 = 0;
            int sumaTotalValoresParesMenoresAOcho2 = 0;
            var consulta = from n in valores2 where n > 8 &&  n%2 == 0 select n;
            var consulta2 = from n in valores2 where n < 8 && n%2 == 0 select n;
            foreach(var valor in valores2)
            {
                sumaTotalValoresParesMayoresAOcho2 = consulta.Sum();
                sumaTotalValoresParesMenoresAOcho2 = consulta2.Sum();
            }
            Console.WriteLine("(metodo linq)suma de valores pares mayores a 8:" + sumaTotalValoresParesMayoresAOcho2);
            Console.WriteLine("(metodo linq)suma de valores pares menores a 8:" + sumaTotalValoresParesMenoresAOcho2);
            Console.Read();
        }
    }
}
