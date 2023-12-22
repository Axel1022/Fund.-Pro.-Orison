/*PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 1 AL 500
2. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 500 AL 1
3. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS IMPARES COMPRENDIDOS ENTRE EL 1 Y EL 100
4. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 0 AL 1000, INCREMENTANDO DE 5 EN 5
5. PROGRAMA QUE PIDA AL USUARIO UN NUMERO, Y MUESTR EN PANTALLA LA SECUENCIA DESCENDENTE DESDE EL NUMERO INGRESADO HASTA 0
6. PROGRAMA QUE PIDA AL USUARIO UN NUMERO. EL NUMERO RECIBIDO LO MULTIPLICARA POR 5. SI EL RESULTADO ES UN NUMERO PAR, MOSTRARA EN PANTALLA LA SECUENCIA ASCENDENTE DESDE EL NUMERO RECIBIDO HASTA EL RESULTADO DE LA MULTIPLICACION. EN CASO CONTRARIO, MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL RESULTADO DE LA MULTIPLICACION HASTA EL NUMERO INGRESADO.
7. PROGRAMA QUE PIDA AL USUARIO DOS NUMERO. SI EL 1ER NUMERO ES MAYOR QUE EL SEGUNDO, MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL PRIMER NUMERO HASTA EL SEGUNDO, EN CASO CONTRARIO MOSTRAR LA SECUENCIA ASCENDENTE.*/


using System; 
{{
    Console.WriteLine(@"¿Que quieres hacer? 
1. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 1 AL 500
2. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 500 AL 1
3. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS IMPARES COMPRENDIDOS ENTRE EL 1 Y EL 100
4. PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 0 AL 1000, INCREMENTANDO DE 5 EN 5
5. PROGRAMA QUE PIDA AL USUARIO UN NUMERO, Y MUESTR EN PANTALLA LA SECUENCIA DESCENDENTE DESDE EL NUMERO INGRESADO HASTA 0
6. PROGRAMA QUE PIDA AL USUARIO UN NUMERO. EL NUMERO RECIBIDO LO MULTIPLICARA POR 5. SI EL RESULTADO ES UN NUMERO PAR, MOSTRARA EN PANTALLA LA SECUENCIA ASCENDENTE DESDE EL NUMERO RECIBIDO HASTA EL RESULTADO DE LA MULTIPLICACION. EN CASO CONTRARIO, MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL RESULTADO DE LA MULTIPLICACION HASTA EL NUMERO INGRESADO.
7. PROGRAMA QUE PIDA AL USUARIO DOS NUMERO. SI EL 1ER NUMERO ES MAYOR QUE EL SEGUNDO, MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL PRIMER NUMERO HASTA EL SEGUNDO, EN CASO CONTRARIO MOSTRAR LA SECUENCIA ASCENDENTE.");
int Val = int.Parse(Console.ReadLine());
Console.Clear(); 

if (Val == 1)

{
    //PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 1 AL 500
    int Valor = 1; int Num = 0;
    do
    {
        Valor ++;
        Num ++; 

        Console.WriteLine(Num + ""); 

    }while (Valor <= 500);

}

if (Val == 2)
{
    //PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 500 AL 1
    int Valor = 0; //int Num =  0, 
    int Dat=500; 
    do{
        
       Valor  ++;
        //Num  --; 
        Dat= Dat -1; 
        
        //Num = (-1 * Num); 

        Console.WriteLine(Dat + "");
    
    }while (Valor != 500); 
    
}

if (Val == 3)
{
    //PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS IMPARES COMPRENDIDOS ENTRE EL 1 Y EL 100
    int Valor = 0; int Num = -1;
    do
    {
         Valor = Valor +1;
        Num ++; 
        if (Num % 2 == 0)
        {
            Console.WriteLine(Num + " par");
        }
        else 
        {
            Console.WriteLine(Num + " impar");
        }
    }while (Valor <= 100);
    
}

if (Val == 4)
{
    //PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 0 AL 1000, INCREMENTANDO DE 5 EN 5
    int Valor = 1; int Num = 0;
    do
    {
        Valor ++;
        Num = Num + 5; 

        Console.WriteLine(Num + ""); 
    }
    while (Valor <= 200);
    

}

if (Val == 5)
{
    int Nom, Nom1;
    //PROGRAMA QUE PIDA AL USUARIO UN NUMERO, Y MUESTR EN PANTALLA LA SECUENCIA DESCENDENTE DESDE EL NUMERO INGRESADO HASTA 0
    Console.Write("Ingrese un numero: "); 
    Nom = int.Parse(Console.ReadLine()); 
    Nom1 = Nom;
    do
    {
        Nom = Nom -1;  
        Console.WriteLine(Nom);

    }
    while (Nom != 0 );
   
}

if (Val == 6)
{
    /*PROGRAMA QUE PIDA AL USUARIO UN NUMERO. EL NUMERO
    RECIBIDO LO MULTIPLICARA POR 5. SI EL RESULTADO ES 
    UN NUMERO PAR, MOSTRARA EN PANTALLA LA SECUENCIA 
    ASCENDENTE DESDE EL NUMERO RECIBIDO HASTA EL RESULTADO 
    DE LA MULTIPLICACION. EN CASO CONTRARIO, MOSTRARA LA SECUENCIA 
    DESCENDENTE DESDE EL RESULTADO DE LA MULTIPLICACION HASTA EL 
    NUMERO INGRESADO.*/

    int Nom, Num1;
    Console.Write("Ingrese un numero: "); 
    Nom = int.Parse(Console.ReadLine()); 
    Num1 = Nom * 5; 

    if (Nom % 2 == 0)
    {
        //Console.WriteLine(Nom);
        do
        {
            Nom = Nom + 1;
            Console.WriteLine(Nom);
        } while (Nom > Num1 );
        
    }
    else 
    {
        do 
        {
            Num1= Num1 - 1;
            Console.WriteLine(Num1);
        }
         while (Nom != Num1 );
    }
}

if (Val == 7)
{

    /*PROGRAMA QUE PIDA AL USUARIO DOS NUMERO. SI EL 1ER
    NUMERO ES MAYOR QUE EL SEGUNDO, MOSTRARA LA SECUENCIA 
    DESCENDENTE DESDE EL PRIMER NUMERO HASTA EL SEGUNDO, 
    EN CASO CONTRARIO MOSTRAR LA SECUENCIA ASCENDENTE.*/
    int A, B;
    Console.Write("Ingrese un numero: ");
    A = int.Parse(Console.ReadLine());
    Console.Write("Ingrese un numero: ");
    B = int.Parse(Console.ReadLine());
    Console.Clear(); 


    if (A > B)
    {

    Console.WriteLine(A);
    do
    {
        A = A - 1; 
        Console.WriteLine(A);
    }
    while(A != B);
    }

    if (B > A)
{

    do 
    {
        A = A + 1; 
        Console.WriteLine(A);
    }while(B != A);


}


}

}}
