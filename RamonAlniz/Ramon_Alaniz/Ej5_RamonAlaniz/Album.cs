using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5_RamonAlaniz
{
    class Album : Foto
    {
        int id_album;
        string nombre;
        int fecha_creaciom;
        List<Foto> fotos;
        public Album() { }
        public Album(double tamaño,int id_album, string nombre, int fecha_creaciom, List<Foto> fotos)
        {
            this.id_album = id_album;
            this.nombre = nombre;
            this.fecha_creaciom = fecha_creaciom;
            this.fotos = fotos;
            base.Tamaño = tamaño;
        }

        public int Id_album { get => id_album; set => id_album = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Fecha_creaciom { get => fecha_creaciom; set => fecha_creaciom = value; }
        internal List<Foto> Fotos { get => fotos; set => fotos = value; }
        public void AniadirFoto(Foto f)
        {
            try
            {
                this.Fotos.Add(f);
                base.Tamaño += base.Tamaño;
                Console.WriteLine("\nSe ha añadido una nueva foto.");
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo añadir la foto. \n" + ex.Message);
                Console.ReadLine();
            }
        }
        public void MostrarFoto()
        {
            foreach (var item in this.Fotos)
            {
                Console.WriteLine("\n---------------");
                Console.WriteLine("\nDatos de la foto: ");
                item.ToString();
            }
        }
        public void VaciarAlbum()
        {
            Console.WriteLine("\nDesea eliminar todos los elementos mostrados en la lista?: R/N");
            string resp = Console.ReadLine();
            if (resp == "R" || resp == "r")
            {
                this.Fotos = new List<Foto>();
                base.Tamaño = 0;
                Console.WriteLine("\nEliminacion correcta");
            }
            else
            {
                Console.WriteLine("\nProblemas al eliminar fotos en el album");
            }
            Console.ReadLine();
        }
        public void EliminarFoto(Foto f)
        {
            this.Fotos.Remove(f);
            Console.ReadLine();
        }
        public void TamañoAlbum()
        {
            if (base.Tamaño > 0)
            {
                base.Tamaño *= 0.0009765625;
                Console.WriteLine("\nEl tamaño del album es: {0} GB", base.Tamaño);
            }
            else
                Console.WriteLine("\nEl tamaño de los datos es de cero.");
        }
    }
}

