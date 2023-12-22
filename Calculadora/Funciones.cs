class Funciones
{
    public static decimal Calcular(string Opcion, decimal N, decimal M)
    {
        decimal Resultado = 0;
        if (Opcion == "+") 
        { 
            Resultado = N + M; 
        }
        else if (Opcion == "-") 
        { 
            Resultado = N - M; 
        }
        else if (Opcion == "*") 
        { 
            Resultado = N * M; 
        }
        else if (Opcion == "/") 
        { 
            Resultado = N / M; 
        }
        return Resultado;
    }
    public static void NoValido()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("No es una opcion valida"); Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White; Console.Clear();
    }
}