using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ2
{
    class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }
        public int EmpresaId { get; set; }
        public void getDatosEmpleados()
        {
            Console.WriteLine("Empleado {0} con id {1},con cargo {2}, con salario {3} y pertenece a " + "la empresa {4}", Nombre, Id, Cargo, Salario, EmpresaId);
        }
    }
}
