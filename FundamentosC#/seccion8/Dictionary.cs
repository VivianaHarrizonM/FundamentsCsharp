using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.seccion8
{
    internal class Dictionary
    {
        static void Main(string[] args)
        {
            //Dictionary, se compone de un par "clave-valor" o "key-value" pair
            Dictionary<String, int> empleados = new Dictionary<String, int>();

            //Añadeindo key-value pairs a la colección
         empleados.Add("Hugo", 35);
         empleados.Add("Victor", 35);

            foreach (KeyValuePair<String, int> elemento in empleados)
            {
                Console.WriteLine("Key es: {0} su value es: {1}", elemento.Key ,elemento.Value);
            }

            //colección[Key ] = value;
            empleados["Diego"]= 45; //Con Add: empleado.Add("Miguel",45)

            //Despues de agregar un elemento con Item[]
            Console.WriteLine("\nDespues de agregar un elemento con Item[]");

            foreach (KeyValuePair<String, int> elemento in empleados)
            {
                Console.WriteLine("Key es: {0} su value es: {1}", elemento.Key, elemento.Value);
            }
            //Comprobando que Item[] reemplaza la "key"
            Console.WriteLine("\nComprobando que Item[] reemplaza la 'key' ");
            empleados["Hugo"] = 25;

            //Usando el get de la propiedad Item[]
            Console.WriteLine("La edad de Diego es: {0}", empleados["Diego"]);
        }
    }
}
