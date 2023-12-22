/*Calcular el perímetro y área (son dos cálculos diferentes)
 de un rectángulo, recibiendo por parte del usuario la base y la altura */ 
using System; 

{{
    int B, H, P, A; 

    //Entrada B = Base 
    Console.Write("Ingrese la base del rectangulo: ");
    B = int.Parse(Console.ReadLine()); 
    //H = Altura
    Console.Write("Ingrese la altura del rectangulo: ");
    H = int.Parse(Console.ReadLine()); 
    Console.Clear();
    //Proceso A = Area
    A = B * H; 
    //P = Perimetro
    P = 2*B + 2*H; 

    //Salida
    Console.WriteLine("Datos:"); 
    Console.WriteLine("Base: " + B + " cm"); 
    Console.WriteLine("Altura: " + H + " cm"); 
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------"); 
    Console.WriteLine("Area: " + A + " cm²"); 
    Console.WriteLine("Perimetro: " + P + " cm²"); 

}}
