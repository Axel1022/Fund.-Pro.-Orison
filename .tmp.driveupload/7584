//Cantidato ganador

string letra="";
int votosA = 0,votosB = 0, Nulos=0;


Console.Clear();

Console.WriteLine("Elije el nuevo Presidente de la junta de vecino.");
for (int i = 0; i < 10; i++)
{

    Console.Write("Vota A por Donald Trum o B por Danilo Medina:");
    letra = Console.ReadLine();

    if (letra == "a" || letra == "A")
    {
        votosA++;
    }
    else if (letra == "b" || letra == "B")
    {
        votosB++;
    }
    else
        { Nulos++; }

    Console.Clear();

}

if (votosA == votosB)
{
    Console.WriteLine("Votacion empatada.");
}
else if (votosA > votosB)
{
    Console.WriteLine($"Donald Trum es el ganador de estas elecciones con {votosA} votos.");
    Console.WriteLine($"Danilo Medina perdio con  {votosB} votos.");
    Console.WriteLine($"Votos nulos: {Nulos}.");
}
else if (votosA < votosB)
{
    Console.WriteLine($"Danilo Medina es el ganador de estas elecciones con {votosB} votos.");
    Console.WriteLine($"Donald Trum perdio con  {votosA} votos.");
    Console.WriteLine($"Votos nulos: {Nulos}.");
}
