using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10_RamonAlaniz
{
    class Empleado : Persona
    {
        private double sueldo_Bruto;
        public Empleado() { }
        public Empleado(double sueldo_Bruto)
        {
            this.Sueldo_Bruto = sueldo_Bruto;
        }

        public double Sueldo_Bruto { get => sueldo_Bruto; set => sueldo_Bruto = value; }
        public void Mostrardatos()
        {
            Console.WriteLine("Se muestran los datos");
        }
        public void calc_Salario()
        {
            Console.WriteLine("Se calcula el salario del empelado");
        }
    }
}
