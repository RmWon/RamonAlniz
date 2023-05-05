using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4_RamonAlaniz
{
    class Program
    {
        static void Añadir()
        {    
            int op = 0;
            Console.WriteLine("Llenar los datos de vehiculo: ");
            Console.Write("\nDigite el id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("\nMarca: ");
            string marca = Console.ReadLine();
            Console.Write("\nModelo: ");
            string modelo = Console.ReadLine();
            Console.Write("\nKilometraje: ");
            int km = int.Parse(Console.ReadLine());
            Console.Write("\nPrecio: ");
            double precio = double.Parse(Console.ReadLine());
            Console.Write("\nAño: ");
            int annio = int.Parse(Console.ReadLine());
            
           
            do         
            {
                Console.Write("\n\tMenu de opciones \n1.Auto \n2.Moto \nDigite su tipo de vehiculo: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Write("\nSi el auto tiene 'airbag' escriba true y si no 'false': ");
                        bool au = bool.Parse(Console.ReadLine());
                        Auto a = new Auto(precio,au);
                        Vehiculo Vh = new Vehiculo(id, marca, modelo, km, precio, annio);
                        Console.WriteLine(Vh.ToString());
                        Console.WriteLine(a.ToString());
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Write("\nSi la moto tiene 'sidecar' escriba true y si no 'false': ");
                        bool m = bool.Parse(Console.ReadLine());
                        Auto Mt = new Auto(precio, m);
                        Vehiculo Vhc = new Vehiculo(id, marca, modelo, km, precio, annio);
                        Console.WriteLine(Vhc.ToString());
                        Console.WriteLine(Mt.ToString());
                        Console.ReadKey();
                        break;
                    default: Console.WriteLine("Digite una opcion dentro del rango establecido....."); break;
                }

            } while (op != 2);
           
            
        }
        static void Main(string[] args)
        {
            Añadir();
            Console.ReadKey();
        }
    }
}
