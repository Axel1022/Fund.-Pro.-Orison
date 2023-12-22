using System;

class program
{

    public static void Main(string[] args)

    {
        string A, B, C, D;

        A = "Si";
        B = "Si";
        C = "No";
        D = "No";

        //Parte 4: 1 - 10

        Console.WriteLine("Si me inscribo en el ITLA y apruebo todas las materias puedo obtener el título de Tecnólogo en Desarrollo de Software: " + ((A == B) && (C == D)));
        Console.WriteLine("Si no duermo, no me salen ojeras: " + ((A != B) || (C != D)));
        Console.WriteLine("Me gusta comer pizza  y beber refresco: " + ((A == B) && (C == D)));
        Console.WriteLine("Si no asisto a clases, me mantendré al día con el contenido: " + ((A != B) && (C != D)));
        Console.WriteLine("Si me alimento bien y descanso lo suficiente, tendré buena salud: " + ((A == B) && (C == D)));
        Console.WriteLine("Si practico mucho la programación, no aprenderé rápido: " + ((A == B) && (C != D)));
        Console.WriteLine("Si hago las tareas bien o hago bien los examenes obtendré la puntuación máxima: " + ((A == B) && (C == D)));
        Console.WriteLine("Si tengo hambre, debo comer: " + ((A == B) && (C == D)));
        Console.WriteLine("Si tengo sueño, no debo dormir: " + ((A == B) && (C != D)));
        Console.WriteLine("Si monto bicicleta o nado, estaré haciendo ejercicio.: " + ((A == B) && (C == D)));

    }


}

