using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4_RamonAlaniz
{
    class Moto : Vehiculo
    {
        bool sidecar;

        public Moto(double Precio, bool sidecar)
        {
            this.sidecar = sidecar;
            base.Precio = Precio;
        }
        public bool Sidecar { get => sidecar; set => sidecar = value; }

        public override string ToString()
        {
            if (this.Sidecar == true)
            {
                base.Precio += 50;
                return "El precio de la moto a aumentado a: " + base.Precio + "$";
            }
            else
                return "Precio: " + base.Precio + "$";
        }
    }
}
