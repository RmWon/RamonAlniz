using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Ej5_RamonAlaniz
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("\n\t\t\tMenu del Album: ");
            Console.WriteLine("\n\t1. Llenar datos de foto con el metodo ToString y usando el mostrar con ToString.");
            Console.WriteLine("\n\t2. Llenar datos del album.");
            Console.WriteLine("\n\t3. Llenar datos de foto con el metodo 'Añadir Foto'");
            Console.WriteLine("\n\t4. Mostrar datos de la Foto");
            Console.WriteLine("\n\t5. Vaciar Album.");
            Console.WriteLine("\n\t6. Eliminar una foto.");
            Console.WriteLine("\n\t7. Mostrar tamaño del album.");
            Console.WriteLine("\n\t8. Salir del album de foto");
        }
        static void Pedir(string m,ref int id)
        {
            Console.Write("{0}", m);
            id = int.Parse(Console.ReadLine());
        }
        static void Pedir(string m, ref double t)
        {
            Console.Write("{0}", m);
            t = double.Parse(Console.ReadLine());
        }
        static void Pedir(string m,ref string c)
        {
            Console.Write("{0}", m);
            c = Console.ReadLine(); 
        }
        static void Llenar( Foto f, Album al)
        {
            int id = 0;
            double tamaño = 0;
            int fecha_creacion = 0;
            string comentarios = " ";
            int Id_al = 0;
            string nombre = " ";
            int op = 0;
            do {

                Menu();

                Pedir("\nDigite la opcion de su gusto:  ", ref op);
                switch (op)
                {
                    case 1:
                        Console.WriteLine("\nLlenar datos de la foto: ");
                        Pedir("\nId: ", ref id);
                        Pedir("\nTamaño(Mb): ", ref tamaño);
                        Pedir("\nFecha de creacion: ", ref fecha_creacion);
                        Pedir("\nComentario: ", ref comentarios); 
                        f = new Foto(id, tamaño, fecha_creacion, comentarios);
                        Console.WriteLine(f.ToString()); 
                        Console.ReadLine();break;

                    case 2:
                        Console.WriteLine("\nDatos del album: ");
                        Pedir("\nId del album: ", ref Id_al);
                        Pedir("\nFecha de creacion: ", ref fecha_creacion);
                        Pedir("\nNombre del album: ", ref nombre);
                        al = new Album(tamaño, id, nombre, fecha_creacion, new List<Foto>());
                        Console.ReadLine(); break;

                    case 3:
                        Pedir("\nId: ", ref id);
                        Pedir("\nTamaño(Mb): ", ref tamaño);
                        Pedir("\nFecha de creacion: ", ref fecha_creacion);
                        Pedir("\nComentario: ", ref comentarios);
                        al.AniadirFoto(new Foto(id, tamaño, fecha_creacion, comentarios)); 
                        Console.ReadLine(); break;

                    case 4:
                         al.MostrarFoto();
                         Console.ReadLine(); break;

                    case 5: 
                        al.VaciarAlbum();
                        Console.ReadLine(); break;

                    case 6:
                        al.EliminarFoto(new Foto());
                        Console.ReadLine(); break;

                    case 7:
                        al.TamañoAlbum();
                        Console.ReadLine(); break;

                    case 8: 
                        Console.WriteLine("\nSaliendoooo.... :) "); break;

                    default:
                        Console.WriteLine("Los datos estan fuera de los limites establecido."); break;
                }
                } while (op != 8);
            
        }
        static void Main(string[] args)
        {
            Foto f = new Foto();
            Album al = new Album();
            Llenar(f, al);
            Console.ReadKey();
        }
    }
}
