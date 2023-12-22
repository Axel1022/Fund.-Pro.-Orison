
//Dados dos números ingresados por el usuario, mostrar la suma, resta, división y multiplicación de ambos.
using System; 

{{
    int A, B, Sum, Res, Mul; 
    //double Div;
    Console.WriteLine("Suma, Multiplicacion, Resta y Divicion de dos numeros");
    Console.WriteLine("Ingrese el primer numero"); 
    A = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Ingrese el primer numero"); 
    B = int.Parse(Console.ReadLine()); 
    //Suma 
    Sum = A + B;
    //Resta
    Res = A - B; 
    //Multiplicacion
    Mul = A * B; 
    //Divicion 
    double  Div  = A/B; 
    //Salida
    Console.WriteLine("Suma: " + Sum);
    Console.WriteLine("Resta: " + Res);
    Console.WriteLine("Multiplicacion: " + Mul);
    Console.WriteLine("Division: " + Div);
}}