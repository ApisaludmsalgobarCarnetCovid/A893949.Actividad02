using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo_de_futbol_Actividad_2
{
    public class Ayudante
    {
        public static int validacionNumeros1al7() //Valida que el usuario haya ingresado un numero entre 1 y 7.
        {
            bool validation = false;
            int variable;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out variable))
                {
                    Console.Clear();
                    Console.WriteLine("Solo se puede ingresar numeros. Favor intentar de nuevo");
                    Console.ReadKey();
                    Console.Clear();
                    break;


                }
                else
                {
                    if (variable > 7 || variable <=0  || variable == 0){

                        Console.Clear();
                        Console.WriteLine("Favor ingresar un numero entre 1 y 7");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    } 
                    
                    
                    else validation = true;
                }

            }
            while (!validation);
            return variable;
        }

    }
}