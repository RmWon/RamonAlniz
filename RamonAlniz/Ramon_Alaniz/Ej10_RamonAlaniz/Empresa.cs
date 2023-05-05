using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10_RamonAlaniz
{
    class Empresa
    {
        private string nombrre;
        public Empresa() { }
        public Empresa(string nombrre)
        {
            this.nombrre = nombrre;
        }

        public string Nombrre { get => nombrre; set => nombrre = value; }
    }
}
