using System;
using System.Linq;
using System.Collections.Generic;

class Torneo_De_Futbol_Actividad2 {

  static void Main() {






    bool validacion;
    int opcion;


    {



        Console.WriteLine("");
        Console.WriteLine("1.Ingresar Equipos");
        Console.WriteLine("2.Tabla de Pocision");
        Console.WriteLine("3.Salir del sistema");
        Console.WriteLine("");

        Console.Write("TU OPCION? ");

        opcion = validacionNumeros1al3() ;
        Dictionary<string,int> Equipos = new Dictionary<string,int>();
        List<string> NombreDeEquipos = new List<string>();

        switch (opcion)
        {
            case 1:
                {

                    Console.Clear();


                    int CantidadDeEquipos;
                    
                     
                        
                        Console.WriteLine("Ingresar Cantidad De Equipos");


                        string IngresoParticipante = Console.ReadLine(); 

                        bool ValidacionDeQueSeaNumero = Int32.TryParse(IngresoParticipante, out CantidadDeEquipos);
                        
                        while (!ValidacionDeQueSeaNumero || CantidadDeEquipos < 2 )
                        {
                            Console.WriteLine("Tiene Que haber 2 o mas Equipos para poder iniciar");
                            IngresoParticipante = Console.ReadLine(); 
                            ValidacionDeQueSeaNumero = Int32.TryParse(IngresoParticipante, out CantidadDeEquipos);
                        }
                        

                        
                        for (int i = 0; i < CantidadDeEquipos ; i++)
                        {
                            Console.WriteLine($"Ingresar Nombre Del Equipo Nº{i+1}:");
                            string NombreEquipo = Console.ReadLine();
                            if(String.IsNullOrEmpty(NombreEquipo))
                            {
                                Console.WriteLine("No Ha Ingresado nada"); 
                                i--;
                                continue;
                            }
                            NombreEquipo = NombreEquipo.Trim().ToUpper();
                            if(Equipos.ContainsKey(NombreEquipo))
                            {
                                Console.WriteLine("Ya Existe un Equipo con el mismo Nombre"); 
                                i--;
                                continue;
                            }
                            Equipos.Add(NombreEquipo, 0);
                            NombreDeEquipos.Add(NombreEquipo);
                        }
                        
                        
                        
                        
                        
                        for (int i = 0; i < CantidadDeEquipos ; i++)
                        {
                            for (int j = i+1; j < CantidadDeEquipos ; j++)
                            {
                                int Resultado1;
                                int Resultado2;

                                //Muestro Los partidos 
                                Console.WriteLine($"Resultado de {NombreDeEquipos[i]} vs {NombreDeEquipos[j]}:");
                                
                                Console.Write($"{NombreDeEquipos[i]}: ");
                                bool Validacion = Int32.TryParse(Console.ReadLine(), out Resultado1);
                                while (!Validacion || Resultado1 < 0 )
                                {
                                    Console.WriteLine("Ingreso incorrecto, por favor ingrese un número mayor o igual a 0");
                                    Validacion = Int32.TryParse(Console.ReadLine(), out Resultado1);
                                }
                                Console.Write($"{NombreDeEquipos[j]}: ");
                                Validacion = Int32.TryParse(Console.ReadLine(), out Resultado2);
                                while (!Validacion || Resultado2 < 0 )
                                {
                                    Console.WriteLine("Ingreso incorrecto, por favor ingrese un número mayor o igual a 0");
                                    Validacion = Int32.TryParse(Console.ReadLine(), out Resultado2);
                                }
                                if(Resultado2<Resultado1)
                                {
                                    Equipos[NombreDeEquipos[i]] += 3;
                                }
                                else if (Resultado1 == Resultado2)
                                {
                                    Equipos[NombreDeEquipos[i]] += 1;
                                    Equipos[NombreDeEquipos[j]] += 1;
                                }
                                else
                                {
                                    Equipos[NombreDeEquipos[j]] += 3;    
                                }
                            }
                            
                        }


                        Equipos = Equipos.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                        Console.Clear();
                        Console.WriteLine("Tabla de posiciones: ");
                        foreach(string nombre in Equipos.Keys)
                        {
                            Console.WriteLine($"{nombre}: {Equipos[nombre]}");
                        }


                    
                    break;
                }

            
            
             case 2:
                        {
                            Console.Clear();
                            Equipos = Equipos.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                            Console.Clear();
                            Console.WriteLine("Tabla de posiciones: ");
                            foreach(string nombre in Equipos.Keys)
                            {
                                Console.WriteLine($"{nombre}: {Equipos[nombre]}");
                            }                            break;
                        }
            
            
             case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Hasta Pronto. Saludos");
                            Console.ReadKey();
                            validacion = true;
                            break;
                        }
            


              default:
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese una opcion válida");
                            Console.ReadKey();
                            break;
                        }
            
            }
      
        
        
        }
    } 






        public static int validacionNumeros1al3() //Valida que el usuario haya ingresado un numero entre 1 y 7.
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
                    if (variable > 3 || variable <=0  || variable == 0){

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