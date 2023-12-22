class Calculadora
{
    public static void Imprime(decimal N, decimal M, decimal Resultado, int X)
    {
        string Opx = "";
        string Opx2 = "";
        switch (X)
        {
            case 1:
                Opx = "La suma de ";
                Opx2 = "+";
                break;
            case 2:
                Opx = "La diferencia de ";
                Opx2 = "-";
                break;
            case 3:
                Opx = "El producto de ";
                Opx2 = "*";
                break;
            case 4:
                Opx = "El cociente de ";
                Opx2 = "/";
                break;
        }
        string ParaGuardar;
        ParaGuardar = Convert.ToString(Opx + N + Opx2 + M + " es: " + Resultado);
        la.Animacion(7);
        TextoGrande.Calculadora();
        Console.Write(ParaGuardar);
        Historial.EscribirHistorial(ParaGuardar, 1);
        Console.ReadKey();
    }
    public static void Calcular(int Opcion, decimal N, decimal M)
    {
        decimal Resultado = 0;
        //MenuCalcular:
        switch (Opcion)
        {
            case 1:

                Resultado = (N + M);
                Calculadora.Imprime(N, M, Resultado, Opcion);
                break;
            case 2:
                Resultado = N - M;
                Calculadora.Imprime(N, M, Resultado, Opcion);
                break;
            case 3:
                Resultado = N * M;
                Calculadora.Imprime(N, M, Resultado, Opcion);
                break;
            case 4:
                Resultado = N / M;
                Calculadora.Imprime(N, M, Resultado, Opcion);
                break;
        }
    }
}
class Pedir
{
    public static void Numeros(int opcion)
    {
        if (opcion > 0 && opcion < 5)
        {
            Console.Write("Ingres el primer numero: ");
            int N1 = int.Parse(Console.ReadLine());
            Console.Write("Ingres el segundo numero: ");
            int N2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Desicion.SRMD(opcion);
            Calculadora.Calcular(opcion, N1, N2);
        }
        if (opcion == 5)
        {
            Historial.LeerHistorial(1);
            Console.ReadKey();
        }
    }
}
class Desicion
{
    public static void SRMD(int Opcion)
    {
        if (Opcion == 1)
        {
            TextoGrande.Suma();
        }
        else if (Opcion == 2)
        {
            TextoGrande.Resta();
        }
        else if (Opcion == 3)
        {
            TextoGrande.Multifuncion();
        }
        else if (Opcion == 4)
        {
            TextoGrande.Division();
        }
    }
}
