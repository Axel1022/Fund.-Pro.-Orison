//Parte 1
/*using System;
{
    {
        string Nom, Ape, Ced;
        int Eda;
        string Dir;
        string Vac;
        dynamic Alt, Pes;
        //Entrada
        Console.WriteLine("Por favor, llenar todo correctamente");
        Console.Write("Ingrese su nombre: ");
        Nom = Console.ReadLine();
        Console.Write("Ingrese su apellido: ");
        Ape = Console.ReadLine();
        Console.Write("Ingrese su edad: ");
        Eda = Convert.ToByte(Console.ReadLine());
        Console.Write("Ingrese su cedula: ");
        Ced = Console.ReadLine();
        Console.Write("Ingrese direccion: ");
        Dir = Console.ReadLine();
        Console.Write("Ingrese su peso: ");
        Pes = Console.ReadLine();
        Console.Write("Ingrese su altura: ");
        Alt = Console.ReadLine();
        Console.WriteLine("¿Te vacunaste?");
        Vac = Console.ReadLine();
        //Salida
        Console.WriteLine("Nombre: " + Nom);
        Console.WriteLine("Apellido: " + Ape);
        Console.WriteLine("Edad: " + Eda);
        Console.WriteLine("Cedula: " + Ced);
        Console.WriteLine("Direccion: " + Dir);
        Console.WriteLine("Peso: " + Pes);
        Console.WriteLine("Altura: " + Alt);
        Console.WriteLine("Vacunado: " + Vac);

    }


}*/

using System;
string[] NombresArrays; //*Declarando el arreglo.
NombresArrays = new string[11];  //*Espacio que tiene el array.
//BOQUE 1
bool cicloHace = true;
bool cicloManda = true;
bool ciclorandom = true;
//BLOQUE 2
bool ciclrecorre = false;
//BLOQUE 3
bool ciclosalida = false;
int PH = 0, PM = 0;
//string ConteoDesicion;
int[] arrayManda = new int[21];
int[] arrayHace = new int[21];
Random Primero = new Random();  //*Numero ramdom.
Random Segundo = new Random();  //*Numero ramdom.
int Hace = 0, Manda = 0;
NombresArrays[0] = "";
NombresArrays[1] = "Derik Diaz";
NombresArrays[2] = "Rainy Diaz";
NombresArrays[3] = "Jinnet Reyes";
NombresArrays[4] = "Paul Garcia";
NombresArrays[5] = "Federico Garcia";
NombresArrays[6] = "Jack Gomez";
NombresArrays[7] = "Daniel Beras";
NombresArrays[8] = "Starling Jacobo";
NombresArrays[9] = "Bryant Reynoso";
NombresArrays[10] = "Enmanuel Lopez";

//BLOQUE1
while (ciclorandom == true)
{
    while (cicloHace == true)
    {
        Hace = Primero.Next(1, 11);
        cicloHace = false;
    }
    while (cicloManda == true)
    {
        Hace = Primero.Next(1, 11);
        cicloManda = false;
    }
    if (Manda != Hace)
    {
        ciclrecorre = true;//Abre el bloque2
    }
    else
    {
        cicloHace = true;
        cicloHace = true;
        //Para que se repita todo lo del bloque 1 e ignora el bloque 2, debido a que esta cerrado.
    }
    //BLOQUE 2
    while (ciclrecorre == true)
    {
        //Parte1
        for (int M = 0; M < arrayHace.Length + 1; M++)
        {
            Console.WriteLine(arrayHace[M]);
            if (Manda == arrayHace[M])
            {
                Manda = Primero.Next(1, 21);
                M = 0;
            }
        }
        arrayHace[PH] = Hace;
        PH++;
        //Parte2
        for (int i = 0; i < arrayManda.Length + 1; i++)
        {
            if (Manda == arrayManda[i])
            {
                Manda = Segundo.Next(1, 11);
                i = 0;
            }
        }
        arrayManda[PM] = Manda;
        PM++;
        ciclrecorre = false;
    }
    //Nda
    if (ciclrecorre == false)
    {
        ciclosalida = true;
    }

    //BLOQUE 3

    while (ciclosalida == true)
    {
        Console.WriteLine($"Manda {NombresArrays[Manda]}");
        Console.WriteLine($"Hace {NombresArrays[Hace]}");
        ciclosalida = false;
    }
}
