/*Dadas dos variables numericas A y B que el usuario debe teclear,
 intercambie los valores de ambas variables y miestren cuanto valen
  al final las dos vatiables*/
using System;
{
  {
    //Variables
    int A, B, A1, B1;
    //Entrada
    Console.Write("Ingrese Primer numero: ");
    A = int.Parse(Console.ReadLine());
    Console.Write("Ingrese segundo numero: ");
    B = int.Parse(Console.ReadLine());
    Console.Clear();
    //Proceso
    A1 = A;
    B1 = B;
    A = B1;
    B = A1;
    //Salida
    Console.WriteLine("Datos: ");
    Console.WriteLine("Primer valor:  " + A1);
    Console.WriteLine("Segundo valor:  " + B1);
    Console.WriteLine("Valores intercambiados: ");
    Console.WriteLine("Primer valor:  " + A);
    Console.WriteLine("Segundo valor:  " + B);









  }
}
