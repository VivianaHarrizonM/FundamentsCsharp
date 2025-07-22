using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Seccion7
{
    internal class Tarea7
    {
        static void Main(string[] args)
        
            {

                string nombreAR, apellidoAR, direccionAR, rfcAR;
                double saldoInicial, montoAR;
                int opcion;

                Console.WriteLine(">>>>>>>>>>>>   Bienvenidos a MonsterInc   <<<<<<<<<<<<<<<<\n");
                Console.WriteLine("Ingrese los siguientes campos que se solicitan:");

                Console.Write("Nombre: ");
                nombreAR = Console.ReadLine();

                Console.Write("Apellido: ");
                apellidoAR = Console.ReadLine();

                Console.Write("Dirección: ");
                direccionAR = Console.ReadLine();

                Console.Write("RFC: ");
                rfcAR = Console.ReadLine();

                Console.Write("Saldo inicial: $ ");
                while (!double.TryParse(Console.ReadLine(), out saldoInicial) || saldoInicial < 0)
                {
                    Console.Write("Por favor ingrese un saldo válido: $ ");
                }

                CuentaBancaria cliente1 = new CuentaBancaria(nombreAR, apellidoAR, direccionAR, rfcAR, saldoInicial);

                Console.WriteLine("\n----- Felicidades, su cuenta ha sido creada con éxito. Presione cualquier tecla para continuar -----");
                Console.ReadKey();

                // Menú
                do
                {
                    Console.Clear();
                    Console.WriteLine("----- MENÚ PRINCIPAL -----");
                    Console.WriteLine("1. Depósito");
                    Console.WriteLine("2. Retiro");
                    Console.WriteLine("3. Consultar saldo");
                    Console.WriteLine("4. Mostrar información de la cuenta");
                    Console.WriteLine("5. Salir");
                    Console.Write("Elija una opción: ");

                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.WriteLine("Por favor ingrese una opción válida.");
                        continue;
                    }

                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese el monto a depositar: $");
                            if (double.TryParse(Console.ReadLine(), out montoAR) && montoAR > 0)
                            {
                                cliente1.Deposito(montoAR);
                                Console.WriteLine("Depósito exitoso.");
                            }
                            else
                            {
                                Console.WriteLine("Monto inválido.");
                            }
                            break;

                        case 2:
                            Console.Write("Ingrese el monto a retirar: $");
                            if (double.TryParse(Console.ReadLine(), out montoAR) && montoAR > 0)
                            {
                                cliente1.Retiro(montoAR);
                            }
                            else
                            {
                                Console.WriteLine("Monto inválido.");
                            }
                            break;

                        case 3:
                            Console.WriteLine($"Saldo actual: ${cliente1.ConsultaSaldo():F2}");
                            break;

                        case 4:
                            Console.WriteLine(cliente1.ToString());
                            break;

                        case 5:
                            Console.WriteLine("Gracias por usar el sistema. ¡Hasta pronto!");
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }

                    if (opcion != 5)
                    {
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }

                } while (opcion != 5);
            }

        class CuentaBancaria
        {
            private string nombre, apellido, direccion, rfc;
            private double saldo;

            public CuentaBancaria(string nombrePA, string apellidoPA, string direccionPA, string rfcPA, double saldoPA)
            {
                nombre = nombrePA;
                apellido = apellidoPA;
                direccion = direccionPA;
                rfc = rfcPA;
                saldo = saldoPA;
            }

            public void Deposito(double montoPA)
            {
                saldo += montoPA;
            }

            public void Retiro(double montoPA)
            {
                if (montoPA <= saldo)
                {
                    saldo -= montoPA;
                    Console.WriteLine("Retiro exitoso.");
                }
                else
                {
                    Console.WriteLine("¡Saldo insuficiente!");
                }
            }

            public double ConsultaSaldo()
            {
                return saldo;
            }

            public override string ToString()
            {
                return $"Empleado: {nombre} {apellido}\n" +
                       $"Dirección: {direccion}\n" +
                       $"RFC: {rfc}\n" +
                       $"Saldo actual: ${saldo:F2}";
            }
        }
    }
}
