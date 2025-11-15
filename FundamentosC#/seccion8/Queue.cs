using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.seccion8
{
    internal class Queue
    {
        static void Main(string[] args)
        {
            //Queue
            Queue<char> miFila = new Queue<char>();

            //Agregando objetos al Queue
            miFila.Enqueue('a');
            miFila.Enqueue('b');
            miFila.Enqueue('c');
            miFila.Enqueue('d');
            miFila.Enqueue('e');

            int i = 0;

            //Recorriendo la Queue
            foreach (var elemento in miFila)
            {
                Console.WriteLine("{0}. {1}", i++, elemento);
            }
        
            //Agregando otro elemento
            Console.WriteLine("\nDespués de agregar un elemento \n");
            miFila.Enqueue('f');
            
            i = 0;
            foreach (var elemento in miFila)
            {
                Console.WriteLine("{0}. {1}", i++, elemento);
            }

            //Despues de quitar un elemento
            Console.WriteLine("\nDespués de quitar un elemento \n");
            var objElim = miFila.Dequeue();

            i = 0;
            foreach (var elemento in miFila)
            {
                Console.WriteLine("{0}. {1}", i++, elemento);
            }
            Console.WriteLine("\n({0}) fue eliminado correctamente ", objElim);
        }
    }
}
