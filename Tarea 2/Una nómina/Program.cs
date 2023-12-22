/*Parte 1:3
En una aplicacion de nomina, 
se necesitan los siguientes campos:*/

using System;

{
    {
        string Nom,Ape, Dep, Fec;
        dynamic Ced, Cod; 
        float Sal;
        //Recibir valores
        Console.Write("Ingrese nombres: ");
        Nom = Console.ReadLine();
        Console.Write("Ingrese apellidos: ");
        Ape = Console.ReadLine();
        Console.Write("Ingrese cedula: ");
        Ced =  Console.ReadLine();
        Console.Write("Ingrese departamento/area de trabajo: ");
        Dep = Console.ReadLine();
        Console.Write("Ingrese fecha de ingreso: ");
        Fec= Console.ReadLine();
        Console.Write("Ingrese codigo: ");
        Cod = Console.ReadLine();
        Console.Write("Ingrese salario: ");
        Sal = float.Parse(Console.ReadLine());
        //Extra
        Console.WriteLine(Nom + Ape + "," +" cedula: "+ Ced+ " del departamento de " + Dep+", ingreso el " + Fec+", ganando: " + Sal + " pesos dominicanos cod: " + Cod);

    }               

}

   