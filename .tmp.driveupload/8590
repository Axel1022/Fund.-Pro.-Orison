class Monedas
{
    public static void Domi()
    {
        string ParaGuardar = "";
        Console.Clear();
        TextoGrande.Pesos();
        Console.Write("Ingrese los RD$: ");
        int Entrada = Convert.ToInt32(Console.ReadLine());
        double Dolares = Entrada * 0.018;
        double Euros = Entrada * 0.017;
        Console.Clear();
        TextoGrande.Pesos();
        Console.WriteLine(Entrada + " RD es igual a:");
        Console.WriteLine("Eruros: " + Math.Round(Euros, 2) + " EUR");
        Console.WriteLine("Dolares Estadounidenses: " + Math.Round(Dolares, 2) + " USD");
        ParaGuardar = $"{Entrada} RD = {Dolares} USD y {Euros} EUR";
        Historial.EscribirHistorial(ParaGuardar, 2);
    }
    public static void Esta()
    {
        string ParaGuardar = "";
        Console.Clear();
        TextoGrande.Dolares();
        Console.WriteLine("Ingrese los USD$");
        int Entrada = Convert.ToInt32(Console.ReadLine());
        double Pesos = Entrada * 54.75;
        double Euros = Entrada * 0.96;
        Console.Clear();
        TextoGrande.Dolares();
        Console.WriteLine(Entrada + " USD es igual a:");
        Console.WriteLine("Eruros: " + Math.Round(Euros, 2) + " EUR");
        Console.WriteLine("Pesos Dominicanos: " + Math.Round(Pesos, 2) + " RD");
        ParaGuardar = $"{Entrada} USD = {Pesos} RD y {Euros} EUR";
        Historial.EscribirHistorial(ParaGuardar, 2);
    }
    public static void Espa()
    {
        string ParaGuardar = "";
        Console.Clear();
        TextoGrande.Euros();
        Console.WriteLine("Ingrese los EUR$");
        int Entrada = Convert.ToInt32(Console.ReadLine());
        double Pesos = Entrada * 57.29;
        double Dolares = Entrada * 1.05;
        Console.Clear();
        TextoGrande.Euros();
        Console.WriteLine(Entrada + " EUR es igual a:");
        Console.WriteLine("Pesos Dominicanos: " + Math.Round(Pesos, 2) + " RD");
        Console.WriteLine("Dolares Estadounidenses: " + Math.Round(Dolares, 2) + " USD");
        ParaGuardar = $"{Entrada} EUR = {Pesos} RD y {Dolares} USD";
        Historial.EscribirHistorial(ParaGuardar, 2);
    }
}


