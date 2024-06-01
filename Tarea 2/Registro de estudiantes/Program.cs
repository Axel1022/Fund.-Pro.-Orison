//aplicacion de registro de estudiantes del ITLA
using System;

{
    {
        string Nom, Ape, Fec, Dir, Ema;
        dynamic Mat, Tel, Car;

        //Entrada
        Console.WriteLine("Ingrese los siguientes datos corectamente");
        Console.Write("Ingrese su nombre: ");
        Nom = Console.ReadLine();
        Console.Write("Ingrese su apellido: ");
        Ape = Console.ReadLine();
        Console.Write("Ingrese su matricula: ");
        Mat = Console.ReadLine();
        Console.Write("Ingrese su fecha de nacimiento: ");
        Fec = Console.ReadLine();
        Console.Write("Ingrese su direccion: ");
        Dir = Console.ReadLine();
        Console.Write("Ingrese su numero de telefono: ");
        Tel = Console.ReadLine();
        Console.Write("Ingrese su correo electronico: ");
        Ema = Console.ReadLine();
        Console.Write("¿Que carrera estudias?");
        Car = Console.ReadLine();
        //Salida
        Console.WriteLine(Nom + Ape +", matricula " + Mat);
        Console.Write("Datos:");
        Console.Write(" Fecha de nacimiento: " + Fec);
        Console.Write(" Email: " + Ema);
        Console.Write(" Direccion: " + Dir);
        Console.Write(" Carrera: " + Car);
        Console.Write(" Telefono " + Tel);


    }
}
