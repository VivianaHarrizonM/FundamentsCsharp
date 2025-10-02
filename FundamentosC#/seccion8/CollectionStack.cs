using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.seccion8
{
    internal class CollectionStack
    {
        static void Main(string[] args)
        {
            //Stack
            Stack<double> miPila = new Stack<double>();

            //Insertar objetos al principio del Stack
            miPila.Push(5.9);
            miPila.Push(13.1);
            miPila.Push(8.7);
            miPila.Push(3.2);
            miPila.Push(10.5);

            int i = 0; //Móstrar índice

            //Mostrar la información del Stack
            foreach (double elemento in miPila)
            {
                Console.WriteLine("{0}. {1}", i++, elemento);
            }

            //Despues de insertar un elemento
            Console.WriteLine("\n Déspues de insertar u elemento\n");
            miPila.Push(1.5);
            i = 0;

            //Mostrar la información del Stack
            foreach (double elemento in miPila)
            {
                Console.WriteLine("{0}. {1}", i++, elemento);
            }

        }
    }
}
