/*PROGRAMA QUE LEA UN NUMERO DE DOS DÍGITOS Y
DETERMINE SI UN DÍGITO ES MÚLTIPLO DE OTRO*/
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

        if (Num1 % Num2 == 0)
        {
            Console.WriteLine(Num1 + " es multiplo de " + Num2);
        }
        else
        {
            Console.WriteLine(Num1 + " y " + Num2 + " no son multiplo");
        }

    }
}
