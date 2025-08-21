using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.seccion8
{
    internal class Genericos
    {
        static void Main(string[] args)
        {
            //Variables locales
            string valorElemento;
            /*Alumno valorElemento*/
            ;


            //Instanciando la clase
            //GuardaObjetos<Alumno> objetos1 = new GuardaObjetos<Alumno>(3);

            Alumno alumno1 = new Alumno(9);
            Alumno alumno2 = new Alumno(9.3);
            Alumno alumno3 = new Alumno(9.5);


            ////Agregar Objetos
            //objetos1.AgregarElementos(alumno1);
            //objetos1.AgregarElementos(alumno2);
            //objetos1.AgregarElementos(alumno3);
            GuardaObjetos<String> objetos1 = new GuardaObjetos<String>(3);
            ////Agregar Objetos
            objetos1.AgregarElementos("Luis");
            objetos1.AgregarElementos("José");
            objetos1.AgregarElementos("Juan");

            //Obtener elemento
            //valorElemento = (string)objetos1.ObtenerElemento(1);
            //valorElemento = (Alumno)objetos1.ObtenerElemento(0);

            valorElemento = objetos1.ObtenerElemento(1);
            Console.WriteLine(valorElemento);
            //Console.WriteLine(valorElemento.Calificación);
        }
    }
        
    class GuardaObjetos<T>
    {
        //Campos
        private int i = 0;
        private T[] matrizElementos;

        //Constructor
        public GuardaObjetos(int elementoPa)
        {
            matrizElementos = new T[elementoPa];
        }

        //Métodos
        public void AgregarElementos(T elementoPa)
        {
            matrizElementos[i] = elementoPa;
            i++;
        }

        public T ObtenerElemento(int elementoPa)
        {
            return matrizElementos[elementoPa];
        }

     }

    class Alumno
    {
        //Campos
        double calificacion;

        //Constructor
        public Alumno(double calificacionPa)
        {
            calificacion = calificacionPa;
        }

        public double Calificación
        {
            get => calificacion;
        }
    }
    
}
