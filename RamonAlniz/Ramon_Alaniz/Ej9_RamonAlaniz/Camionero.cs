using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej9_RamonAlaniz
{
    class Camionero
    {
        int rec;
        string poblacion;
        string nombre;
        int telefono;
        string direccion;
        double salario;
        public Camionero() { }
        public Camionero(int rec, string poblacion, string nombre, int telefono, string direccion, double salario)
        {
            this.rec = rec;
            this.poblacion = poblacion;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.salario = salario;
        }

        public int Rec { get => rec; set => rec = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public double Salario { get => salario; set => salario = value; }
        public void Conduce()
        {
            Console.WriteLine("Un camionero conduce un camion");
        }
        public void Distribuye()
        {
            Console.WriteLine("Un camionero distribuye paqutes");
        }
    }
}
