/*Programa que lea un número y que muestre su 
raíz cuadrada y su raíz cúbica.*/
using System; 

{{
    //Variables
    double Num, Cub, Cua;
    //Entrada
    Console.Write("Ingrese un numero: ");
    Num = Convert.ToDouble(Console.ReadLine()); 
    //Console.Clear();
    //Proceso
    Cub = Math.Pow(Num,3); 
    Cua = Math.Pow(Num,2); 
    //Salida
    Console.WriteLine("El cuadrado de " + Num + " es: "+ Cua);
    Console.WriteLine("El cubo de " + Num + " es: "+ Cub);

}}
