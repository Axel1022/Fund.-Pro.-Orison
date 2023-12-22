//Pide una frase y recorrela caracter por caracter.
string Palabra;
Console.WriteLine("Ingrese la frase");
Palabra = Console.ReadLine();
Console.Clear();
for (int i = 0; i < Palabra.Length; i++)
{
    Console.WriteLine(Palabra[i]);
}
Console.ReadKey();