using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7_RamonAlaniz
{
    class Estudiante : Persona
    {
        public Estudiante() { }
        public Estudiante(string nombre)
        {
            base.Nombre = nombre;
        }

        public void Estudiar()
        {
            Console.WriteLine("Estudiar...");
        }
    }
}
