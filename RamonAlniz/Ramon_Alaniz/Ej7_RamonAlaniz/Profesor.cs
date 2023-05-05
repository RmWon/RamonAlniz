using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7_RamonAlaniz
{
    class Profesor : Persona
    {
        public Profesor() { }
        public Profesor(string nombre)
        {
            base.Nombre = nombre;
        }

        public void Explicar()
        {
            Console.WriteLine("Explicar");
        }
    }
}
