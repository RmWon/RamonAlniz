using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej8_RamonAlaniz
{
    class Estudio : Pelicula
    {
        string nombre;
        string direccion;
        public Estudio() { }
        public Estudio(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public void Produce()
        {
            Console.WriteLine("Un estudo produce muchas peliculas");
        }
    }
}
