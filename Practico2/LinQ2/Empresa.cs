using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ2
{
    class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public void getDatosEmpresa()
        {
            Console.WriteLine("empresa {0} con Id{1}", Nombre, Id);
        }
    }
}
