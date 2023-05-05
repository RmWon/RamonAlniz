using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6_RamonAlaniz
{
    class Program
    {
        static void Llenar(Ubicacion ub,Forma fr, Circulo cl, Rectangulo rt)
        {

        }
        static void Main(string[] args)
        {
            Ubicacion Ub = new Ubicacion();
            Forma Fr = new Forma();
            Circulo Cl = new Circulo();
            Rectangulo Rt = new Rectangulo();
            Llenar(Ub,Fr,Cl,Rt);
            Console.ReadKey();
        }
    }
}
