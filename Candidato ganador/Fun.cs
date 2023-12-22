class Funciones
{
    public static void Candidato(string NombreG, string NombreP, int votosA, int votosB, int Cual, int Nullo)
    {
        if (Cual == 1)
        {
            Console.WriteLine(NombreG + " es el ganador de estas elecciones con " + votosA + " votos."); Thread.Sleep(800);
            Console.WriteLine(NombreP + " perdio con " + votosB + " votos."); Thread.Sleep(800);
            Console.WriteLine($"Votos nulos:" + Nullo + "."); Thread.Sleep(500);
        }
        else if (Cual == 2)
        {
            Console.WriteLine(NombreP + " es el ganador de estas elecciones con " + votosB + " votos."); Thread.Sleep(800);
            Console.WriteLine(NombreG + " perdio con " + votosA + " votos."); Thread.Sleep(800);
            Console.WriteLine($"Votos nulos:" + Nullo + "."); Thread.Sleep(500);
        }
    }
    public static void LaFuncion(string Desicion)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine($"{Desicion} Espere, por favor."); Thread.Sleep(500); Console.Clear();
            Console.WriteLine($"{Desicion} Espere, por favor.."); Thread.Sleep(500); Console.Clear();
            Console.WriteLine($"{Desicion} Espere, por favor..."); Thread.Sleep(500); Console.Clear();
        }
    }
}