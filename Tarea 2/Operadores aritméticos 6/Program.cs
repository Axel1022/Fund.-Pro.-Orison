//Parte 2.6

using System;

class mm
{

    static void Main()

    {

        double suma1 = (17 - 15);
        suma1 = Math.Pow(suma1, 3); //8

        double suma2 = (7 - 12);
        suma2 = Math.Pow(suma2, 2);//25

        double suma3 = suma1 + suma2; //33
        double suma4 = ((6 - 7) * ((double)12 / 23));
        suma4 = suma3 / suma4; //-63.25

        Console.WriteLine(suma4);

    }

}
