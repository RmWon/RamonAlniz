using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej8_RamonAlaniz
{
    class Pelicula
    {
        string nombre;
        int annio;
        public Pelicula() { }
        public Pelicula(string nombre, int annio)
        {
            this.nombre = nombre;
            this.annio = annio;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Annio { get => annio; set => annio = value; }
    }
}
