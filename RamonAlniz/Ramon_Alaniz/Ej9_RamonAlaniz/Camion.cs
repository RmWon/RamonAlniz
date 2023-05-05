using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej9_RamonAlaniz
{
    class Camion
    {
        int potencia;
        string matricula;
        string tipo;
        string modelo;
        public Camion() { }
        public Camion(int potencia, string matricula, string tipo, string modelo)
        {
            this.potencia = potencia;
            this.matricula = matricula;
            this.tipo = tipo;
            this.modelo = modelo;
        }

        public int Potencia { get => potencia; set => potencia = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }
}
