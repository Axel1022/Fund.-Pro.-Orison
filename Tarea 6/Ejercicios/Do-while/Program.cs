using System; 
{{
    Console.WriteLine(@"¿Que quieres hacer?
    1. Programa que pida el nombre y la edad del usuario, y que muestre un saludo con el nombre del usuario, la cantidad de veces de la edad. 
    (Ejemplo: si el nombre es LUIS y la edad es 24, debe mostrar el saludo: Hola Luis 24 veces)
    2.Crear un programa que reciba el nombre y la edad de una persona. Si la edad de la persona es mayor que 18, mostrar un mensaje que diga: 
    Estudia en el itla, la misma cantidad de veces que la edad. En caso contrario, mostrar el mensaje solo 5 veces.
    3. Crear un programa que pida al usuario un número. Si el numero ingresado es cero, mostrar un mensaje de error y terminar. En caso contrario
    que muestre la secuencia de números desde 1 hasta el numero ingresado por el usuario. ");
    int Usu = int.Parse(Console.ReadLine()); 
    Console.Clear();

    if (Usu == 1)
    {
        string Nom; 
        int Eda;
        Console.Write("Ingrese su nombre: "); 
        Nom = Console.ReadLine(); 
        Console.Write("Ingrese su edad: "); 
        Eda = int.Parse(Console.ReadLine()); 
        //Console.Clear(); 
        int Vec = 0, No = 0; 

        do 
        {
            Vec ++;
            No ++;
            Console.WriteLine(No + ". Hola, " + Nom + ".");
        }
        while(Vec < Eda);

    }

    if (Usu == 2)
    {
        //Crear un programa que reciba el nombre y la edad de una persona. Si la edad de la persona es mayor que 18, mostrar un mensaje que diga: 
        //Estudia en el itla, la misma cantidad de veces que la edad. En caso contrario, mostrar el mensaje solo 5 veces
        string Nom; 
        int Eda;
        Console.Write("Ingrese su nombre: "); 
        Nom = Console.ReadLine(); 
        Console.Write("Ingrese su edad: "); 
        Eda = int.Parse(Console.ReadLine()); 
        //Console.Clear(); 
        int Ves = 0, No = 0;
        
        if (Eda >= 18)
        {
            do
            {
                Ves ++;
                No ++;
                Console.WriteLine(No + ". Estudia en el itla.");
            }
            while(Ves < Eda);

        }
        else 
        {
            do 
            {
                 Ves ++;
                No ++;
                Console.WriteLine(No + ". Estudia en el itla.");
            }
            while(Ves < 5);
           
        }
    }

    if (Usu == 3)
    {
        int Num;
        Console.Write("Ingrese un numero: ");  
        Num = int.Parse(Console.ReadLine()); 
        //Console.Clear(); 
        int Ves = 0, No = 0;

        if (Num == 0)
        {
            Console.WriteLine("Error");
        }

         else 
        {
            
            do 
            {
                Ves ++;
                No ++;
                Console.WriteLine(No);   
            }
            while (Ves < Num);
            

        }

    }














































}}
