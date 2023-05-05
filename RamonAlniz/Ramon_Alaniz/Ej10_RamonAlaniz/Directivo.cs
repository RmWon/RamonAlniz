using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10_RamonAlaniz
{
    class Directivo : Empleado
    {
        private string categoria;
        public Directivo() { }
        public Directivo(string categoria)
        {
            this.categoria = categoria;
        }

        public string Categoria { get => categoria; set => categoria = value; }

        public void Mostrardato()
        {
            Console.WriteLine("Se muestran los datos");
        }
    }
}
