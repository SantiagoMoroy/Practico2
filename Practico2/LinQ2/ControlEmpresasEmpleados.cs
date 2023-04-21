using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ2
{
    class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;
        public ControlEmpresasEmpleados() {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();


            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Ialpha" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Udelar" });
            listaEmpresas.Add(new Empresa { Id = 3, Nombre = "SpaceZ" });
            listaEmpresas.Add(new Empresa { Id = 4, Nombre = "pastitos y portland" });
            listaEmpresas.Add(new Empresa { Id = 5, Nombre = "vidrieria guichon" });
            listaEmpresas.Add(new Empresa { Id = 6, Nombre = "el pool de ariel" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 1, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "JuanC", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "JuanR", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Daniel", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 5, Nombre = "GonzaloT", Cargo = "CEO", EmpresaId = 2, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Leonardo", Cargo = "CEO", EmpresaId = 1, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 3, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Leonardo", Cargo = "CEO", EmpresaId = 3, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 7, Nombre = "Ariel", Cargo = "CEO", EmpresaId = 6, Salario = 300000 });
            listaEmpleados.Add(new Empleado { Id = 8, Nombre = "Santiago", Cargo = "Juntapuchos", EmpresaId = 4, Salario = 40000 });
            listaEmpleados.Add(new Empleado { Id = 9, Nombre = "Federico", Cargo = "Artista de semaforo", EmpresaId = 5, Salario = 40000 });
            listaEmpleados.Add(new Empleado { Id = 10, Nombre = "Javier", Cargo = "Limpia vidrios", EmpresaId = 5, Salario = 100 });

        }
        public void getSeo(string _Cargo)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados where empleado.Cargo == _Cargo orderby empleado.Cargo select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleados();
            }
        }
        public void GetEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Nombre select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleados();
            }
        }
        public void getEmpleadosOrdenadosSegun()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Salario select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleados();
            }
        }
        public void getEmpleadosEmpresa(int _Empresa)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados join empresa in listaEmpresas on empleado.EmpresaId equals empresa.Id where empresa.Id == _Empresa select empleado;
            foreach (Empleado elemento in empleados)
            { elemento.getDatosEmpleados(); }
        }
        public void PromedioSalario()
        {
            var consulta = from e in listaEmpleados group e by e.EmpresaId into g select new { empresa = g.Key, PromedioSalario = g.Average(e => e.Salario) };
            foreach (var resultado in consulta)
            {
                switch (resultado.empresa)
                {
                    case 1: Console.WriteLine($"empresa Ialpha- Promedio de salario:{resultado.PromedioSalario}");
                        break;
                    case 2: Console.WriteLine($"EMPRESA UdelaR - Promedio de salario:{resultado.PromedioSalario}");
                        break;
                    case 3:
                        Console.WriteLine($"EMPRESA SpaceZ - Promedio de salario:{resultado.PromedioSalario}");
                        break;

                }
            }
        }
    } 
}
