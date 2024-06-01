/* Parte 2:8
{√25 [3 (3*3) – (20/5)]} (9-2) / (7+5*2)³ */

using System;

{
    {
        int B, C, D, E, F, X;
        //√25
        double A = Math.Sqrt(25); //5

        //3
         B = 3;

        //(3*3)
         C = (3*3); //9

         X = B *C;

        //(20/5)
         D = (20/5); //4

        //(9-2)
         E = (9-2); //7

        //(7+5*2)
        F = (7+(5 * 2)); //24

        //F*F*F
        double G = Math.Pow(F , 3); //

        int H = X - D;
        double I = (H * A);
        double J = I * E;

       double K = J  / G;

       Console.WriteLine(K);

    }


}
