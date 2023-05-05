using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6_RamonAlaniz
{
    public class Ubicacion
    {
        private double y;
        private double x;
        public Ubicacion() { }
        public Ubicacion(double y, double x)
        {
            this.y = y;
            this.x = x;
        }

        public double Y { get => y; set => y = value; }
        public double X { get => x; set => x = value; }

    }
}
