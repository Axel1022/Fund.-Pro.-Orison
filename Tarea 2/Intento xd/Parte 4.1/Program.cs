/* Parte 4.1
Si me inscribo en el ITLA 
y apruebo todas las materias puedo 
obtener el título de Tecnólogo en 
Desarrollo de Software.
*/
using System;

class pp
{

    static void Main()
    {

        int A, B;
        Console.WriteLine("Esta aplicacion te ayuda a saber si estas listo para resibir tu titulo del ITLA");
        Console.Write(" ¿Estas inscrito en el ITLA?");
        Console.WriteLine(" Elige tu respuesta: (1 = Si) (2 = No)");

        A = int.Parse(Console.ReadLine());

        if (A == 1)
        {
            Console.WriteLine("¿Aprobaste todas las materias?");

            B = int.Parse(Console.ReadLine());

            if (B == 1)

            {
                Console.WriteLine("Obtendras tu titulo proximamente");

            }
            else if (B != 1) // Tambien es valido: ==2
            {
                Console.WriteLine("Debes aprobar todas las materias para obtener tu titulo");

            }

            else if (B != 1 || B != 2)
            {
                Console.WriteLine(B + " no es una opcion valida");

            }

        }

        if (A == 2)
        {
            Console.WriteLine("Debes inscribirte");

        }

        else if (A != 1)
        {
            Console.WriteLine(" no es una opcion valida");


        }
    }


}
