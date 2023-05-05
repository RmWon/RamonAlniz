using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7_RamonAlaniz
{
    
    class Program
    {const int N = 3;
        static void Entrada(Persona[] p, Profesor pr, Estudiante e)
        {
            for(int i = 0; 0 < N; i++)
            {
                if(i == 0)
                {
                    p[i] = new Persona("Juan");
                }
                else
                if( i== 1)
                {
                    p[i] = new Persona("Sara"); ;
                }
                else
                if(i == 2)
                {
                    p[i] = new Persona("Carlos");
                }
            }
        }
        static void Salida(Persona[] p, Profesor pr, Estudiante e)
        {
            for(int i=0; i < N; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine(p[i].ToString());
                    pr.Explicar();
                }
                 if (i == 1)
                {
                    Console.WriteLine(p[i].ToString());
                    e.Estudiar();
                }
                 if (i == 2)
                {
                    Console.WriteLine(p[i].ToString());
                    e.Estudiar();
                }

            }
            
        }
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[N];
            Profesor pr = new Profesor();
            Estudiante e = new Estudiante();
            Entrada(personas, pr, e);
            Salida(personas, pr, e);
            Console.ReadKey();
        }
    }
}
