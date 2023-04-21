using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "juan", Edad = 25, Ciudad = "Lima" },
                new Persona { Nombre = "Maria", Edad = 30, Ciudad = "Bogota" },
                new Persona { Nombre = "", Edad = 35, Ciudad = "Madrid" },
                new Persona { Nombre = "Ana", Edad = 20, Ciudad = "Lima" },
                new Persona { Nombre = "jose", Edad = 40, Ciudad = "Buenos Aires" },
                new Persona { Nombre = "el santi",Edad = 35, Ciudad ="Bogota" }
            };
            var Consulta = from p in personas where p.Edad < 25 && p.Ciudad == "Lima" orderby p.Nombre descending select new { p.Nombre, p.Edad };
            var Consulta2 = from p in personas where p.Edad > 30 && p.Ciudad == "Bogota" orderby p.Nombre descending select new { p.Nombre, p.Edad };
            var Consulta3 = from p in personas where p.Edad > 25 && p.Edad <35 orderby p.Nombre ascending select new { p.Nombre, p.Edad };
            foreach (var Persona in Consulta)
            { Console.WriteLine($"ejercicio 1a: { Persona.Nombre}({Persona.Edad} años)"); 
            }
          
            foreach (var Persona in Consulta2)
            {
                Console.WriteLine($"ejercicio 1b: { Persona.Nombre}({Persona.Edad} años)");
            }
            foreach (var Persona in Consulta3)
            {
                Console.WriteLine($"ejercicio 1c: { Persona.Nombre}({Persona.Edad} años)");
            }
            Console.Read();
        }
    }
}
