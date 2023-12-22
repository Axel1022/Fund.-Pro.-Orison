class Historial
{
    public static void EscribirHistorial(string guardar, int N)
    {
        string C = "HistorialCalculadora.txt";
        string D = "HistorialDivisas.txt";
        if (N == 1)
        {
            TextWriter ElHistorial = File.AppendText(C);
            ElHistorial.WriteLine(guardar);
            ElHistorial.Close();
        }
        else
        {
            TextWriter ElHistorial = File.AppendText(D);
            ElHistorial.WriteLine(guardar);
            ElHistorial.Close();
        }
    }
    public static void LeerHistorial(int N)
    {
        string C = "HistorialCalculadora.txt";
        string D = "HistorialDivisas.txt";
        if (N == 1)
        {
            TextReader ELHistorial = new StreamReader(C);
            Console.WriteLine(ELHistorial.ReadToEnd());
            ELHistorial.Close();
        }
        else
        {
            TextReader ELHistorial = new StreamReader(D);
            Console.WriteLine(ELHistorial.ReadToEnd());
            ELHistorial.Close();
        }
    }
}