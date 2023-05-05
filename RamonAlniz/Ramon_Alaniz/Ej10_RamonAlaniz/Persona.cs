using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10_RamonAlaniz
{
    class Persona
    {
        private string nombre;
        private int edad;
        public Persona() { }
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public void MostrarDatos()
        {
            Console.WriteLine("Se muestran los datos");
        }
    }
}
