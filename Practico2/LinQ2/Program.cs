using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();
            Console.WriteLine("promedios por empresas \n***************************");
            ce.PromedioSalario();
            Console.WriteLine("");

            Console.WriteLine("Peces Gordos \n***************************");
            ce.getSeo("CEO");


            Console.WriteLine("");
            Console.WriteLine("plantilla \n***************************");
            ce.GetEmpleadosOrdenados();
            Console.WriteLine("");
            Console.WriteLine("Plantilla ordenada por salario \n***************************");
            ce.getEmpleadosOrdenadosSegun();

            Console.WriteLine("\ningrese la empresa:(entero 1 a 6)\n1 para IAlpha\n2 para UdelaR \n3 para SpaceZ \n4 para pastitos y portland \n5 para vidrieria guichon \n6 para el pool de ariel ");

            string _Id = Console.ReadLine();
            try
            {
                int _Empresa = int.Parse(_Id);
                ce.getEmpleadosEmpresa(_Empresa);
            }
            catch
            {
                Console.WriteLine("Ha introducido un Id erroneo. Debe ingresar un numero entero");
        }
            Console.Read();
        }

}
}
