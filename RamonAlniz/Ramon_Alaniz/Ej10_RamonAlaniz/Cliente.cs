using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10_RamonAlaniz
{
    class Cliente : Persona
    {
        private int telefono;
        public Cliente() { }
        public Cliente(int telefono)
        {
            this.telefono = telefono;
        }

        public int Telefono { get => telefono; set => telefono = value; }
    }
}
