/* Parte 2:9 
{8 [9-4+6)² (4²-2) – (60*2/4) (9+1)]} + √36 + (9*2/2) 
*/
using System; 
{
    
    {   //8
        int A = 8; //8

        //[9-4+6)²
        int B1 = (9-4+6);
        double B = Math.Pow(B1, 2 ); 

        //(4²-2)
        double C1 = Math.Pow(4,2); 
        double C = C1 -2;

        //(60*2/4)
        int D = (60*2/4); 

        //(9+1)
        int E = (9+1); 

        //√36
        double F = Math.Sqrt(36); 

        //(9*2/2)
        int G = (9*2/2); 

        //(B*C-D*E) *8
        double Res = (B*C-D*E) * A;

        double Res1 = Res + F + G; 

        Console.WriteLine(Res1); 


    }      //Gary Alexander Campusano Paredes//
}