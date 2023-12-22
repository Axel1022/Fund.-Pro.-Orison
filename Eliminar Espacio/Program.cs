class Program
{
    public static void Main()
    {
        string Palabra="", Frase="";
        Console.WriteLine("Ingrese la frase");
        Palabra = Console.ReadLine();
        //Forma 1
        Frase = Palabra.Replace(" ", "");
        //Forma 2
        for (int i = 0; i < Palabra.Length; i++)
        {
            if (Palabra[i] != ' ')
            {
                Console.Write(Palabra[i]);
            }
        }
    }
}