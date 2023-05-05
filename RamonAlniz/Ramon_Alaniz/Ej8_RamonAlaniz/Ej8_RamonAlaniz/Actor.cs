using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej8_RamonAlaniz
{
    class Actor : Pelicula
    {
        string nombre;
        string apellido;
        public Actor() { }
        public Actor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public void Produce()
        {
            Console.WriteLine("\nUn Actro aparece en muchas peliculas");
        }
    }
}
