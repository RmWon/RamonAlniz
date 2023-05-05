using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6_RamonAlaniz
{
     class Rectangulo : Forma
    {
        private double lado1;
        private double lado2;
        public Rectangulo() { }
        public Rectangulo(string nombre, double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            base.Nombre = nombre;
        } 
        protected double Lado1 { get => lado1; set => lado1 = value; }
        protected double Lado2 { get => lado2; set => lado2 = value; }

        public override string ToString()
        {
            this.Perimetro = (this.lado1 + this.lado1) + (this.lado2 + this.lado2);
            this.Area = this.lado1 * this.Lado2;
            return "Los valores del "+ Nombre+ "son: "+"\nEl Perimetro es: "+ Perimetro + "\nEl area es: " + Area;
        }
    }
}
