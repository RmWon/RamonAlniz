using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6_RamonAlaniz
{
     class Circulo : Forma
    {
        private double radio;
        public Circulo() { }
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        protected double Radio { get => radio; set => radio = value; }
    }
}
