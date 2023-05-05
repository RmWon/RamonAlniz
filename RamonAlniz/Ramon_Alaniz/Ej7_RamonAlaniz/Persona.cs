using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7_RamonAlaniz
{  
    class Persona
    {  
        string nombre;
        public Persona() { }
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
