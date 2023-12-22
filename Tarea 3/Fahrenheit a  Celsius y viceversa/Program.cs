/*Escribir un programa que convierta un valor dado en grados
Fahrenheit a grados Celsius. El valor lo debe introducir el usuario.*/
using System;

{
    {
        double Usu, C, C1, F, F1;
        Console.Write("¿Que quieres hacer?");
        Console.WriteLine(" De Fahrenheit a Celsius (1) / De Celsius a Fahrenheit (2)");
        Usu = int.Parse(Console.ReadLine());
        // Console.Clear();
        if (Usu == 1)
        {
            Console.Write("Ingrese la cantidad de Fahrenheit: ");
            C1 = int.Parse(Console.ReadLine());
            C = (C1 - 32) / 1.8;
            Console.WriteLine("Datos:");
            Console.Write(C1 + " °F");
            Console.WriteLine(" es igual a " + C + " °C");
        }
        if (Usu == 2)
        {
            Console.Write("Ingrese la cantidad de Celsius: ");
            F1 = int.Parse(Console.ReadLine());
            F = (1.8 * F1) + 32;
            Console.WriteLine("Datos:");
            Console.Write(F1 + " °C");
            Console.WriteLine(" es igual a " + F + " °F");
        }
        else
        {
            Console.WriteLine(Usu + " no es una opcion valida");
        }
    }
}
