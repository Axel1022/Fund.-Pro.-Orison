/*PROGRAMA QUE LEA TRES NÚMEROS Y LOS
MUESTRE EN ORDEN ASCENDENTE (DE MENOR A MAYOR)*/
using System;
{
    {
        int N1, N2, N3, Mayor, Mediano, Pequeño;
        Console.Write("Ingresa el primer numero: ");
        N1 = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el primer numero: ");
        N2 = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el primer numero: ");
        N3 = int.Parse(Console.ReadLine());

        if (N1 > N2 && N1 > N3)
        {
            Mayor = N1;
            if (N2 > N3)
            {
                Mediano = N2;
                Pequeño = N3;
            }

            else
            {
                Mediano = N3;
                Pequeño = N2;
            }

            Console.Write(Pequeño);
            Console.Write(" " + Mediano);
            Console.Write(" " + Mayor);

        }
        if (N2 > N1 && N2 > N3)
        {
            Mayor = N2;
            if (N1 > N3)
            {
                Mediano = N1;
                Pequeño = N3;
            }

            else
            {
                Mediano = N3;
                Pequeño = N1;
            }

            Console.Write(Pequeño);
            Console.Write(" " + Mediano);
            Console.Write(" " + Mayor);

        }
        if (N3 > N1 && N3 > N2)
        {
            Mayor = N3;
            if (N2 > N1)
            {
                Mediano = N2;
                Pequeño = N1;
            }

            else
            {
                Mediano = N1;
                Pequeño = N2;
            }

            Console.Write(Pequeño);
            Console.Write(" " + Mediano);
            Console.Write(" " + Mayor);
        }

    }
}
