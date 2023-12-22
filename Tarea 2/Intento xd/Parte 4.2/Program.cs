using System; 




class ejercicios
{ 
    
   static void Main() 
    {
        int A;  
        Console.WriteLine("Esta aplicacion te ayuda a saber si tendras ojeras"); 
        Console.WriteLine("¿Duermes lo suficiente?"); 
        Console.WriteLine("Opcion 1 = Si, opcion 2 = No"); 
        A = int.Parse(Console.ReadLine()); 

        if (A == 1)

        {
            Console.WriteLine("No tendras ojeras"); 

  
        }   
        
            if (A == 2)

            {
                Console.WriteLine("Lo siento pero los pandas te van a quedar chiquitos😂🤣"); 
            }

        /* else if (A!=1||A!=2)
                {
                        Console.WriteLine(A + " no es una opcion valida"); 
                }
                */
                
    }
}