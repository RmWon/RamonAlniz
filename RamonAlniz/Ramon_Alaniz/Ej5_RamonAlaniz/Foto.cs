using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5_RamonAlaniz
{
    class Foto
    {
        int id_Foto;
        double tamaño;
        int fecha_creacion;
        string comentarios;
        public Foto() { }
        public Foto(int id_Foto, double tamaño, int fecha_creacion, string comentarios)
        {
            this.id_Foto = id_Foto;
            this.tamaño = tamaño;
            this.fecha_creacion = fecha_creacion;
            this.comentarios = comentarios;
        }

        public int Id_Foto { get => id_Foto; set => id_Foto = value; }
        public double Tamaño { get => tamaño; set => tamaño = value; }
        public int Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }

        public override string ToString()
        {
            return "\n\nMostrando datos con el metodo ToString: "+"\n\nId_Foto: " + Id_Foto + "\nTamaño: " + Tamaño + "\nFecha_Creacio: " + Fecha_creacion + "\nComentarios: " + Comentarios;
        }
    }
}
