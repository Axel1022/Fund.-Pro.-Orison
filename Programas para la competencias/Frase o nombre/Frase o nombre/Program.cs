/*Programa que permina escribir frases/nombres mediante numeros.
Nota: Darle la opcion al user en que momento usar los signos de puntuacion (Punto, coma , Punto y coma, dos puntos, puntos suspensivos y espacio).
El usuario debe (en todo todo momento) ir mirando lo que esta escribiendo.
El usuario debe decidir el momento en el que quiere imprimir lo que ha escrito.
Hacer esto hasta que el usuario lo desida */

using System;
{
    {
        int Dato;
        string Nombre = "", Desicion;
        string [] ArrayABC = new string [34]; //Declaro el arreglo ArrayABC como string y proceso a llenarlo.
        ArrayABC[0] = "";
        ArrayABC[1] = "A";
        ArrayABC[2] = "B";
        ArrayABC[3] = "C";
        ArrayABC[4] = "D";
        ArrayABC[5] = "E";
        ArrayABC[6] = "F";
        ArrayABC[7] = "G";
        ArrayABC[8] = "H";
        ArrayABC[9] = "I";
        ArrayABC[10] = "J";
        ArrayABC[11] = "K";
        ArrayABC[12] = "L";
        ArrayABC[13] = "M";
        ArrayABC[14] = "N";
        ArrayABC[15] = "Ñ";
        ArrayABC[16] = "O";
        ArrayABC[17] = "P";
        ArrayABC[18] = "Q";
        ArrayABC[19] = "R";
        ArrayABC[20] = "S";
        ArrayABC[21] = "T";
        ArrayABC[22] = "U";
        ArrayABC[23] = "V";
        ArrayABC[24] = "W";
        ArrayABC[25] = "X";
        ArrayABC[26] = "Y";
        ArrayABC[27] = "Z";
        ArrayABC[28] = " ";
        ArrayABC[29] = ". ";
        ArrayABC[30] = ", ";
        ArrayABC[31] = "; ";
        ArrayABC[32] = ": ";
        ArrayABC[33] = "... ";
        bool Parawhile = true;
        bool Parawhile1 = true;
        while (Parawhile == true)
        {
            Parawhile1 = true;
            while (Parawhile1 == true)
            {
                Console.Clear();
                Console.WriteLine($"preview: {Nombre}");
                Funciones.Opciones();
                Console.Write("Ingrese numero: ");
                Dato = int.Parse(Console.ReadLine());
                if (Dato != 0)
                {
                    //Nombre = ArrayABC[Dato];
                    Nombre = Nombre + ArrayABC[Dato];
                }
                else if (Dato == 0)
                {
                    Console.Clear();
                    Console.WriteLine(Nombre);
                    Parawhile1 = false;
                }
            }
                Console.WriteLine("¿Desea segir usando el programa?");
                Desicion=Console.ReadLine();
                Console.Clear();
                if (Desicion == "NO" || Desicion == "no"|| Desicion == "nO" || Desicion == "No" )
                {
                    Parawhile = false;
                    Console.WriteLine("Gracias por utilizar mi programa.");
                }
                else if (Desicion == "Si" || Desicion == "si"|| Desicion == "sI" || Desicion == "Si" )
                {
                    Parawhile=true;
                }
        }
    }
}
