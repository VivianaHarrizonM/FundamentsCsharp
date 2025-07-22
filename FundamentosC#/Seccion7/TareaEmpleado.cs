using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Seccion7
{
    internal class TareaEmpleado
    {

     /*
        
        static void Main(string[] args)
        {
            //Variables locales
            string nombreAR, apellidoAR, nip;

         
            Console.WriteLine(">>>>>>>>>>>>   Bienvenidos a MonsterInc   <<<<<<<<<<<<<<<<\n");
            Console.WriteLine("ingrese los siguientes campos que se solicitan");

            Console.Write("Nombre: ");
            nombreAR = Console.ReadLine();
            Console.Write("apellido: ");
            apellidoAR = Console.ReadLine();
            Console.Write("Digite su NIP para asignarlo a su tarjeta bancaria: ");
            nip = Console.ReadLine();


            Empleado empleado1 = new Empleado(nombreAR, apellidoAR);

            empleado1.Nip = nip;

            //Mostrar la información
            Console.WriteLine(empleado1.ToString());
            


        }
     */
        class Empleado
        {
            //campos
            private string nombre, apellido, id, locker, banco, nip;

            //Constructor
            public Empleado(String nombrePA, string apellidoPA)
            {
                nombre = nombrePA;
                apellido = apellidoPA;

                //Llamamos a los metodos para generar los numeros aleatorios
                id = GenerarID();
                locker = GenerarLocker();
                banco = AsignaBanco();
            }
            //Instanciamos a random
            Random random = new Random();
            //Propiedades
            public string Nip
            {
                set => nip = value;
            }

            //Métodos
            private string GenerarID()
            {
             
                int i, numero;
                string id = "";

                for ( i = 0; i < 10; i++)
                {
                    numero = random.Next(10);
                    id += numero.ToString();
                }

                return id;

            }
            private string GenerarLocker()
            {
                int i, numero;
                string locker = "";

                for (i = 0; i < 2; i++)
                {
                    numero = random.Next(2);
                    locker += numero.ToString();
                }

                return locker;

            }
            private string AsignaBanco()
            {
                int asignarBanco;
                string banco = "";

                asignarBanco = random.Next(1, 3);

                switch (asignarBanco)
                {
                    case 1:
                        banco = "Santander";
                        break;
                    case 2:
                        banco = "BBVA";
                        break;
                }

                return banco;

            }
            public override string ToString()
            {
                string mensaje = " ";

                mensaje = "\nEmpleado: " + nombre + " " + apellido + "\nNúmero de empleado: " + id + "\nLocker No. " + locker + "\nBanco asignado: " + banco;

                return mensaje;

        }

        }

        
       


    }
}