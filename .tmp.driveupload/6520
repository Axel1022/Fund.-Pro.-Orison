using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa la cantidad de minutos: ");
        int minutos = int.Parse(Console.ReadLine());

        int segundosTotales = minutos * 60; // Convertir minutos a segundos
        int segundos = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("{0}:{1:D2}", segundos / 60, segundos % 60); // Imprimir minutos y segundos
            segundos++;
            Thread.Sleep(1000); // Esperar 1 segundo
        } while (segundos <= segundosTotales);

        Console.WriteLine("Cronómetro finalizado");
        Console.ReadKey();
    }
}
