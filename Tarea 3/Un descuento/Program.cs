/* Una tienda ofrece un descuento del 15% sobre el total de 
la compra y un cliente desea saber cuanto deberá pagar finalmente 
por su compra. Ingresar el monto de la compra y mostrar los resultados. */
using System; 
{{
    //Variables 
    //Entrada
    double Pre, PreF, Por, R; 
    Console.WriteLine("Descuento de un produto");
    Console.Write("Ingrese el precio del producto: ");
    Pre = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese el porciento de descuento : ");
    Por = Convert.ToDouble(Console.ReadLine());
    //Console.Clear(); 
    //Proceso
    R = (Pre * Por) / 100; 
    PreF = Pre - R; 
    //Salida 
    Console.WriteLine("Datos: " );
    Console.WriteLine("Precio: " + Pre);
    Console.WriteLine("Descuento: " + R);
    Console.WriteLine("Total a pagar: " + PreF);
    
    
}}
