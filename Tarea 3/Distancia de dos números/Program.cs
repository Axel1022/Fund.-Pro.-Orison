/*Pide al usuario dos números y muestra la “distancia” entre ellos
(el valor absoluto de su diferencia, de modo que el resultado sea siempre positivo).*/
using System;
{
    {
        //Variables
        double Num1, Num2, Res;
        //Entrada
        Console.WriteLine("Distancia de dos numeros");
        Console.Write("Ingrese el primer numero: ");
        Num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        Num2 = Convert.ToDouble(Console.ReadLine());
        //Console.Clear();
        //Proceso y desicion
        if (Num1 < 0 || Num2 < 0)
        {
            Num1 = Num1 * (-1);
            Num2 = Num2 * (-1);
        }

        Res = Num1 - Num2;

        if (Res < 0)
        {
            Res = Res * (-1);
        }
        Console.WriteLine("La distancia que hay entre: " + Num1 + " y " + Num2 + " es: " + Res);

    }
}
