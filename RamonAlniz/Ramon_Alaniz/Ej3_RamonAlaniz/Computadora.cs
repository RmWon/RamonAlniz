using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3_RamonAlaniz
{
    class Computadora
    {
        int capacidad_disco;
        int espacio_disponible;
        bool encendido;
        int datos;
        //Constructores
        public Computadora(int capacidad_disco, int espacio_disponible, bool encendido,int datos)
        {
            this.capacidad_disco = capacidad_disco;
            this.espacio_disponible = espacio_disponible;
            this.encendido = encendido;
            this.datos = datos;
        }
        //propiedades
        public int Capacidad_disco { get => capacidad_disco; set => capacidad_disco = value; }
        public int Espacio_disponible { get => espacio_disponible; set => espacio_disponible = value; }
        public bool Encendido { get => encendido; set => encendido = value; }
        public int Datos { get => datos ; set => datos = value; }

        //Metodos de la computadora

        public void AniadirDatos(int Datos)
        {
            this.Datos = Datos;
               
                if(this.Datos <=  this.Capacidad_disco && this.Datos <= this.Espacio_disponible)
                {
                    this.Espacio_disponible -= this.datos;
                }
                else
                {
                    Console.WriteLine("El disco duro alacanzo el tamaño maximo de su capacidad");
                }
        }
        public void Eliminardatos(int Datos)
        {
            this.Datos = Datos;

            if (this.Espacio_disponible == 0)
                {
                        this.Espacio_disponible = 0;  
                }
                else
                {

                if (this.Espacio_disponible + this.Datos > this.Capacidad_disco)
                {
                    Console.WriteLine("\ninsuficiente espacio");
                }
                else
                    this.Espacio_disponible += this.Datos;
                }
        }
        public void Encender(bool n)
        {
            Console.WriteLine("\n\t\t\t¡Bienvenido :)! \n\tpresione cualquier tecla para ingresar a nuestro menu de archivo");
            Console.ReadKey();
        }
        public void apagar(bool n)
        {
            Console.WriteLine("\n\t\tApagando....");
        }
        public Computadora()
        {
            Capacidad_disco = 100000;
            Espacio_disponible = 90000;
        }


    }
}
