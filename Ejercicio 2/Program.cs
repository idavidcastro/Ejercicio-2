using System;

namespace Ejercicio_2
{
    class Program
    {
        /*
            Entrada: Edad del usuario.
            Proceso: Segun el sexo: 
                FEMENINO ( pulsaciones = (220 -edad)/10 ) 
                MASCULINO ( pulsaciones = (210 -edad)/10 )
            Salida: Número de pulsaciones que debe tener una persona por cada 10 segundos de ejercicio aeróbico.
        */
        static void Main(string[] args)
        {
            int edad, pulsaciones, sexo;
            string seguir;
            do {
                Console.Write("\t\n **** CALCULADORA DE PULSACIONES SEGUN EL SEXO ****\n");
                Console.Write("Ingrese su edad: ");
                try
                {
                    edad = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.Write("ERROR!! El dato que ingresó es incorrecto! Por lo tanto, su edad será de 15 años");
                    edad = 15;
                }
                Console.Write("Ingrese su sexo (1 - Masculino ; 2 - Femenino): ");
                try
                {
                    sexo = int.Parse(Console.ReadLine());

                }
                catch (FormatException e)
                {
                    Console.Write("ERROR!! El dato que ingresó es incorrecto! Por lo tanto, su sexo será 2(Femenino)");
                    sexo = 2;
                }

                while ((sexo <= 0) || (sexo > 2)) {
                    Console.Write("Error!! Ingrese su sexo correctamente (1 - Masculino ; 2 - Femenino): ");
                    try
                    {
                        sexo = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.Write("ERROR!! El dato que ingresó es incorrecto! Por lo tanto, su sexo será 1(Masculino)");
                        sexo = 1;
                    }
                }

                if (sexo == 2)
                {
                    pulsaciones = (220 - edad) / 10;
                    Console.Write("Sexo: Femenino\n");
                    Console.Write("Su número de pulsaciones por cada 10 segundos de ejercicio aeróbico es de: {0}", pulsaciones);
                }
                else
                {
                    pulsaciones = (210 - edad) / 10;
                    Console.Write("Sexo: Masculino\n");
                    Console.Write("Su número de pulsaciones por cada 10 segundos de ejercicio aeróbico es de: {0}", pulsaciones);
                }

                Console.Write("\n\n¿Desea volver a calcular el número de pulsaciones? S/N: ");
                seguir = Console.ReadLine();

            } while (seguir.ToUpper().Equals("S"));

        }
    }
}
