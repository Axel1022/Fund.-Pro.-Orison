/*Programa que le muestre al usuario un menu como este:
[E]Español  [I]Inglés  [F]Francés. Según la letra ingresada
por el usuario, muestre una frase en el lenguaje seleccionado.*/
using System;

{
    {

        string Num;
        Console.Write("Menu: [E]Español  [I]Inglés  [F]Francés  [P]Portugues  [H]Hindi  [IT]Italiano :");
        Num = Console.ReadLine();
        switch (Num)
        {
            case "E":
                Console.WriteLine("Programa hecho por Alexander Campusano"); break;
            case "I":
                Console.WriteLine("Program made by Alexander Campusano"); break;
            case "F":
                Console.WriteLine("Programme réalisé par Alexander Campusano"); break;
            case "P":
                Console.WriteLine("Programa feito por Alexandre Campusano"); break;
            case "H":
                Console.WriteLine("अलेक्जेंडर कैम्पुसानो द्वारा बनाया गया कार्यक्रम"); break;
            case "IT":
                Console.WriteLine("Programma realizzato da Alessandro Campusano"); break;
            default:
                Console.WriteLine("No es una opcion valida."); break;
        }
    }
}
