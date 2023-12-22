using System;

{
    {
        int Num, Num1, Num2;
        Console.Write("Ingrese un numero de dos digitos: ");
        Num = int.Parse(Console.ReadLine());

        Num1 = Num % 100 / 10;
        Num2 = Num % 10 / 1;

        Console.WriteLine("El numero invertido es: " + Num2 + "" + Num1);


    }
}
