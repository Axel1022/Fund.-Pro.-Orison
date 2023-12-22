

//Calcular la media (promedio) de tres números pedidos por teclado.
using System; 

{{
    //Declarando variable
    double N1, N2, N3, Res; 
    //Entrada
    Console.WriteLine("Promedio de tres numeros");
    Console.Write("Ingrese el primer numero: "); 
    N1 = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("Ingrese el segundo  numero: "); 
    N2 = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("Ingrese el tercer numero: "); 
    N3 = Convert.ToDouble(Console.ReadLine()); 
    //Console.Clear(); 
    //Proceso
    Res = (N1 + N2 + N3) / 3; 
    //Salida
    Console.WriteLine("El promedio de los numeros ingresados es: " + Res); 

}}