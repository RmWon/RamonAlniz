using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej9_RamonAlaniz
{
    class Paquete
    {
        int codigo;
        string descripcion;
        string destinatario;
        string direccion;
        public Paquete() { }
        public Paquete(int codigo, string descripcion, string destinatario, string direccion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.destinatario = destinatario;
            this.direccion = direccion;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public void Destinado()
        {
            Console.WriteLine("Un paquete tiene un destinatario.");
        }
    }
}
