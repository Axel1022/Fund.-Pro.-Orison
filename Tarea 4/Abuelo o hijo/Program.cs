/*PROGRAMA QUE LEA LA EDAD DEL USUARIO. SI ES MAYOR QUE 50 MOSTRAR
 MENSAJE QUE DIGA "ABUELO." SI ES MAYOR QUE 30 MOSTRAR MENSAJE QUE DIGA
  "PADRE". EN CASO CONTRARIO MOSTRAR MENSAJE QUE DIGA "HIJO"*/

using System; 
{{
    int Eda; 
    Console.Write("ingrese su edad: ");
    Eda = int.Parse(Console.ReadLine()); 
    if (Eda < 30)
    {
        Console.WriteLine("Eres un nuñito");
    }

    if (Eda >= 30 && Eda <= 49)
    {
        Console.WriteLine("A la edad de " + Eda + " años deberias de ser papa");
    }
    if (Eda >= 50 && Eda <= 99)
    {
        Console.WriteLine("Eres un abulito");
    }
    if (Eda >=100 )
    {
        Console.WriteLine("Hablador, no tienes " + Eda);
    }

}}

