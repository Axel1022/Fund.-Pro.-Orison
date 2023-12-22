/*PROGRAMA QUE LEA UN NUMERO ENTERO DE DOS
DÍGITOS Y DETERMINE SI SUS DOS DÍGITOS SON IGUALES.*/
using System;

{
    {
        //Variables
        int Num, Num1, Num2;
        //Entrada
        Console.Write("Ingrese un numero de dos digitos: ");
        Num = int.Parse(Console.ReadLine());
        //Proceso
        Num1 = Num % 100 / 10;
        Num2 = Num % 10 / 1;
        if (Num1 == Num2)
        {
            //Salida
            Console.WriteLine(Num1 + " y " + Num2 + " son iguales");
        }
        else
        {
            //Salida
            Console.WriteLine(Num1 + " y " + Num2 + " no son iguales");
        }




    }
}

