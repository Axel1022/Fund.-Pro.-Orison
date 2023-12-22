/*
*/

using System;
{
    {
        //Variable
        int A;
        //Entrada
        Console.Write("Ingrese un numero: ");
        A = int.Parse(Console.ReadLine());
        //Proceso
        if (A < 0)
        {
            //Salida
            Console.WriteLine(A + " es un numero negativo");
        }
        if (A == 0)
        {
            //Salida
            Console.WriteLine(A + " es neutro");
        }
        else
        {
            //Salida
            Console.WriteLine(A + " es un numero positivo");
        }

    }
}
