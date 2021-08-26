using System;

namespace Fin_de_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir el nombre de la semana al usuario y decirle si es fin de semana o no.
            //En caso de error, indicarlo.
            Console.WriteLine("Debe de tomar en cuenta su ortografia a la hora de introducir un dia de semana.");
            Fin_semana();
        }
        public static void Fin_semana()
        {
            string seleccion = "";
            string seleccion2 = "";
            do {
                
                Console.WriteLine("Ingrese nombre del dia de la semana:");
                seleccion = Console.ReadLine();
                seleccion = seleccion.ToUpper();

                if(seleccion == "LUNES")
                {
                    Console.WriteLine("No es fin de semana");
                    Console.WriteLine("Desea continuar s/n");
                    seleccion2 = Console.ReadLine();
                                    
                }
                else if(seleccion == "MARTES")
                {
                    Console.WriteLine("No es fin de semana");
                    Console.WriteLine("Desea continuar s/n");
                    seleccion2 = Console.ReadLine();
                }
                else if(seleccion == "MIERCOLES")
                {
                    Console.WriteLine("No es fin de semana");
                    Console.WriteLine("Desea continuar s/n");
                    seleccion2 = Console.ReadLine();
                }
                else if (seleccion == "JUEVES")
                {
                    Console.WriteLine("No es fin de semana");
                    Console.WriteLine("Desea continuar s/n");
                    seleccion2 = Console.ReadLine();
                }
                else if (seleccion == "VIERNES")
                {
                    Console.WriteLine("No es fin de semana");
                    Console.WriteLine("Desea continuar s/n");
                    seleccion2 = Console.ReadLine();
                }
                else if(seleccion == "SABADO")
                {
                    Console.WriteLine("Es fin de semana");
                    Console.WriteLine("Desea continuar s/n");
                    seleccion2 = Console.ReadLine();
                }
                else if (seleccion == "DOMINGO")
                {
                    Console.WriteLine("Es fin de semana");
                    Console.WriteLine("Desea continuar s/n");
                    seleccion2 = Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese un dia de semana Valido");
                    Console.WriteLine("Desea continuar s/n");
                    seleccion2 = Console.ReadLine();
                }
            } while (seleccion2 == "s" || seleccion2  == "S");
            

        }
    }
}
