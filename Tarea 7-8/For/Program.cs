using System;
{
    int [] primero= new int [5];
    int [] segundo= new int [5];
    Console.WriteLine("ingrese los 5 numeros deseados");
    for (int i = 0; i < primero.Length  ; i++) 
    {
  
       primero[i] = int.Parse(Console.ReadLine());
       
    }
    for (int i = 0; i < primero.Length  ; i++)
    {
        if (primero[i] % 2 == 0)
        {
            segundo[i] = primero [i] * (10);
        }
        else
        {
            segundo [i] = primero [i];
        }
    }
    Console.Clear();
    Console.WriteLine("Primer arreglo (introduccido por el usuarios):");
    for (int i = 0; i < primero.Length  ; i++)
    { 
        Console.WriteLine(primero[i]);
    }
    Console.WriteLine("Segundo arreglo (Con proceso):");
    for (int i = 0; i < segundo.Length  ; i++)
    { 
        if (segundo[i] == primero[i])
        {
            Console.WriteLine(segundo[i]);
        }
        else
        {
            Console.WriteLine($"{primero [i]} multiplicado por 10: " + segundo[i] );
        }  
    } 
}