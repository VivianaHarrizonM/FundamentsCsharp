using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Seccion7
{
    internal class Propiedades
    {
        //static void Main(string[] args)
        //{
        //    //bool acelerar;

        //    Automovil automovil1 = new Automovil();

        //    //Mostramos campo privado
        //    Console.WriteLine("El color es: {0}", automovil1.Color);

        //    //Asignamos valor a un campo privado
        //    automovil1.Combustible = "Diesel";
        //    Console.WriteLine("El combustible usado es: " +
        //        "{0}",automovil1.Combustible);

        //    Console.WriteLine(automovil1.ToString());

           
        //}

        public class Automovil
        {
            private string color= "Azul", modelo= "ZB10", combustible;
            private string numPuertas = "4", año = "2000";
            private int ccMotor = 1500;

            private String asientos, colorTablero;
            private bool camaraTrasera;

            public Automovil()
            {
                asientos = "Piel";
                colorTablero = "Beige";
                camaraTrasera = false;
            }
            public string Color
            {
                //get { return color; }
                //set { color = value; };
                get => color;
            }
            public string Combustible
            {
                //get { return combustible; }
                get => combustible;
                //set { combustible = value; }
                set => combustible = value;

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
            //Metodo estatico
            public static void Prueba()
            {
                Console.WriteLine("Soy un método estático");
            }

            //INvalidando el metodo ToString
            public override string ToString()
            {
                string mensaje;
                mensaje = " Modelo: " + modelo + "\n Color: "+color + "\n Año: " + año +"\n Puertas: "+ numPuertas +"\n Tipo de combustible: "+ combustible + "\n Motor: " + ccMotor + "\n Asientos: " + asientos + "\n Color del tablero: " + colorTablero + "\n Camara Trasera: " + camaraTrasera;

                return mensaje;
            }

        }
    }
}
