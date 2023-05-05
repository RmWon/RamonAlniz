using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4_RamonAlaniz
{
    class Auto : Vehiculo
    {

        bool airbag;
        public Auto() { }
        public Auto(double Precio, bool airbag)
        {
            this.airbag = airbag;
            base.Precio = Precio;
        }
        public bool Airbag { get => airbag; set => airbag = value; }

        public override string ToString()
        {
            if (this.Airbag == true)
            {
                base.Precio += 200;
                return "\nEl precio del auto a aumentado a: " + base.Precio + "$";
            }
            else
                return "Precio: " + base.Precio + "$";
        }
    }
}
