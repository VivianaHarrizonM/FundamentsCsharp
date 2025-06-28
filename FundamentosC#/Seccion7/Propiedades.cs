using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Seccion7
{
    internal class Propiedades
    {
        static void Main(string[] args)
        {
            //bool acelerar;

            Automovil automovil1 = new Automovil();

            //Mostramos campo privado
            Console.WriteLine("El color es: {0}", automovil1.Color);

            //Asignamos valor a un campo privado
            automovil1.Combustible = "Diesel";
            Console.WriteLine("El combustible usado es: {0}",automovil1.Combustible);
           
        }

        public class Automovil
        {
            private string color= "Azul", modelo, combustible;
            private byte numPuertas, año;
            private int ccMotor;

            public string Color
            {
                get { return color; }
                //set { color = value; };
            }
            public string Combustible
            {
                get { return combustible; }
                set { combustible = value; }

            }
            public bool Acelerar()
            {
                bool acelerar = true;
                Console.WriteLine("Acelerar");
                Prueba();
                return acelerar;
            }

            public bool Frenar()
            {
                bool frenar = true;
                Console.WriteLine("Frenar");
                return frenar;
            }
            public void Velocidad(ref byte velocidadPa)
            {
                velocidadPa++;
                Console.WriteLine("Cambio de velocidad");
            }
            public static void Prueba()
            {
                Console.WriteLine("Soy un método estático");
            }
        }
    }
}
