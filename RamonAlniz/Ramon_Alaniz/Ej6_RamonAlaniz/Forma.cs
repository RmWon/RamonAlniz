using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6_RamonAlaniz
{
    public class Forma : Ubicacion
    {
        string nombre;
        private double area;
        private double perimetro;
        public Forma() { }
        public Forma(string nombre,double area, double perimetro)
        {
            this.area = area;
            this.perimetro = perimetro;
            this.nombre = nombre;
        }
        public double Area { get => area; set => area = value; }
        public double Perimetro { get => perimetro; set => perimetro = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return "El area es: " + Area + "El perimetro es: " + Perimetro;
        }
       
        
    }
}
