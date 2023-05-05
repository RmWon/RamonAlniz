using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4_RamonAlaniz
{
    class Vehiculo
    {
            //Definimos los campos de la clase 
            int id;
            string marca;
            string modelo;
            int km;
            double precio;
            int annio;
            //constructor
            public Vehiculo() { }
            public Vehiculo(int id, string marca, string modelo, int km, double precio, int annio)
            {
                this.Id = id;
                this.Marca = marca;
                this.Modelo = modelo;
                this.Km = km;
                this.Precio = precio;
                this.Annio = annio;
            }
            //propiedades
            public int Id { get => id; set => id = value; }
            public string Marca { get => marca; set => marca = value; }
            public string Modelo { get => modelo; set => modelo = value; }
            public int Km { get => km; set => km = value; }
            public double Precio { get => precio; set => precio = value; }
            public int Annio { get => annio; set => annio = value; }

            public override string ToString()
            {
                return "\nModelo: " + Modelo + "\n" + "Marca: " + Marca + "\n" + "Kilometraje: " + Km + "\n" + "Precio: " + Precio + "\n" + "Año: " + Annio;
            }

    }
}
