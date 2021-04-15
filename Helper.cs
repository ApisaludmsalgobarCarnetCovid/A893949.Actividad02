using System;
using System.Collections.Generic;
using System.Text;

namespace Desarrollo_Segundo_Parcial
{
    class Helper
    {
        static int a = 0;
        static  double b = 0;
        static bool validacion;

        /// <summary>
        /// El objetivo de este método es solicitar numeros enteros al usuario,
        /// y si este no ingresa numero entero, le va a pedir que reingerse
        /// </summary>
        /// <returns></returns>
        public static int Solicitud_de_NumerosEnteros() 
        {
            validacion = false;

            Console.WriteLine("Ingrese un número"); 
            
            do
                if (!int.TryParse(Console.ReadLine(), out int a))
                    Console.WriteLine("Error, ingrese un número válido");
                else
                    validacion = true;


            while (!validacion);

            return a;
        }

        /// <summary>
        /// El objetivo de este método es solicitar numeros enteros al usuario,
        /// y si este no ingresa numero positivo, le va a pedir que reingerse
        /// </summary>
        /// <returns></returns>
        public static int Solicitud_de_NumerosEnterosPositivos()
        {
            validacion = false;
            do
                if (!int.TryParse(Console.ReadLine(), out a))
                    Console.WriteLine("Ingrese número positivo");
                else if (a < 0)
                    Console.WriteLine("Ingrese número positivo");
                else
                   validacion = true;

            while (validacion == false);

            return  a;
        
        }
        /// <summary>
        /// Valida el ingreso y que sea entre un máximo y un mínimo
        /// </summary>
        /// <param name="minimo"></param>
        /// <param name="maximo"></param>
        /// <returns></returns>
        public static double Solicitud_de_NumerosEnterosPositivos(int minimo, int maximo)
        {
            validacion = false;
            do
                if (!double.TryParse(Console.ReadLine(), out b))
                    Console.WriteLine("Ingrese número valido");
                else if (b < minimo || b> maximo)
                    Console.WriteLine("Ingrese número valido");
                else
                    validacion = true;

            while (validacion == false);

            return b;

        }




        public static double Solicitud_de_NumerosPorOpcion(int opcion1, int opcion2)
        {
            validacion = false;
            do
                if (!double.TryParse(Console.ReadLine(), out b))
                    Console.WriteLine("Ingrese número valido");
                else if ( ! (b == opcion1 || b == opcion2))
                    Console.WriteLine("Ingrese número valido");
                else
                    validacion = true;

            while (validacion == false);

            return b;

        }


    }
}
