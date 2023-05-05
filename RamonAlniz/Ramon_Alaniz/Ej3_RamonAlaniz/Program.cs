using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3_RamonAlaniz
{
    class Program
    {
        static void Verificar(Computadora Cmp)
        {

            if (Cmp.Encendido == true)
            {
                Cmp.Encender(Cmp.Encendido);
                int op = 0;

                do
                {

                    Console.WriteLine("\n\n\t\tDatos de los archivos: \n\nCapacidad de disco: {0} \nEspacio disponible: {1}", Cmp.Capacidad_disco, Cmp.Espacio_disponible);
                    Console.WriteLine("\n\n\t\tOpciones de los archivos de la computadora: \n\n1.Añadir datos. \n2.Eliminar datos.");
                    Console.Write("\nDigite una de las opciones: ");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.Write("\nDigite el tamano del archivo a añadir en la pc: ");
                            int datos = int.Parse(Console.ReadLine());
                            Cmp.AniadirDatos(datos);
                            Console.WriteLine("\nEl nuevo espacio disponible es: {0} GB", Cmp.Espacio_disponible);
                            break;
                        case 2:
                            Console.Write("\nDigite el tamaño del archivo a eliminar de la pc: ");
                            int datos2 = int.Parse(Console.ReadLine());
                            Cmp.Eliminardatos(datos2);
                            Console.WriteLine("\nEl nuevo espacio disponible es: {0} GB", Cmp.Espacio_disponible);
                            break;

                        default: Console.WriteLine("Seleccione una opcion dentro del rango establecido.... :) "); break;
                    }
                } while (op != 2);
            }
            else
                Cmp.apagar(Cmp.Encendido);
        }
        static void Main(string[] args)
        {
            Computadora Cmp = new Computadora();

            Console.WriteLine("\t\t\tMenu de la computadora: ");
            Console.Write("\nDigite " + "'true'" + " si quiere encender y " + "'false'" + " si desea apagar la computador: ");
            bool encender = bool.Parse(Console.ReadLine());
            Cmp.Encendido = encender;
            Verificar(Cmp);
            Console.ReadKey();
        }
    }
}
