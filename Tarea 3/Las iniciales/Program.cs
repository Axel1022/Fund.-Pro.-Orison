/*Pedir el nombre y los dos apellidos
 de una persona y mostrar las iniciales.*/

using System;
{
    {
        //Variables
        string Nom1, Ape1, Ape2, Nom2, Ape3, Ape4;
        //Entrada
        Console.Write("Ingrese su nombre: ");
        Nom1 = Console.ReadLine().ToString();
        Console.Write("Ingrese primer apellido: ");
        Ape1 = Console.ReadLine().ToString();
        Console.Write("Ingrese segundo apellido: ");
        Ape2 = Console.ReadLine().ToString();
        //Proceso
        Nom2 = Nom1.Substring(0, 1);
        Ape3 = Ape1.Substring(0, 1);
        Ape4 = Ape2.Substring(0, 1);
        //Salida
        Console.WriteLine(Nom1 + " abreviado: " + Nom2 + ".");
        Console.WriteLine(Ape1 + " abreviado: " + Ape3 + ".");
        Console.WriteLine(Ape2 + " abreviado: " + Ape4 + ".");


    }
}
