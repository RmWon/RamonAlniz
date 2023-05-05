using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej9_RamonAlaniz
{
    class Ciudad
    {
        string codigo;
        string nombre;
        public Ciudad() { }
        public Ciudad(string codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
