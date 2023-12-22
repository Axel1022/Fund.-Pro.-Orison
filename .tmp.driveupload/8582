class FUNCIONES
{
    public static void FAHRENHEIT(int N)
    {
        Console.Clear();
        Convertor.TemperaturasDesicion(N);
        Console.Write("Ingrese los grados Fahrenheit: ");
        double Entrada = Convert.ToDouble(Console.ReadLine());
        double SalidaC = Entrada - 32;
        SalidaC = Math.Round(SalidaC / 1.8, 2);
        double SalidaK = Math.Round((Entrada - 32) * 5 / 9 + 273.15, 2);
        Console.Clear();
        Convertor.TemperaturasDesicion(N);
        Console.WriteLine(Entrada + " °F equivalen a:");
        Console.WriteLine("Celcius: " + SalidaC + " °C");
        Console.WriteLine("Kelvin: " + SalidaK + " K");
        Console.ReadKey();
    }
    public static void CELSIUS(int N)
    {
        Console.Clear();
        Convertor.TemperaturasDesicion(N);
        Console.WriteLine("Ingrese los grados Celsius");
        double Entrada = Convert.ToDouble(Console.ReadLine());
        double SalidaF = Math.Round(Entrada * 9 / 5 + 32, 2);
        double SalidaK = Math.Round(Entrada + 273.15, 2);
        Console.Clear();
        Convertor.TemperaturasDesicion(N);
        Console.WriteLine(Entrada + " °C equivalen a:");
        Console.WriteLine("Fahrenheit: " + SalidaF + " °F");
        Console.WriteLine("Kelvin: " + SalidaK + " K");
        Console.ReadKey();
    }
    public static void KELVIN(int N)
    {
        Console.Clear();
        Convertor.TemperaturasDesicion(N);
        Console.Write("Ingrese los grados Kelvin: ");
        double Entrada = Convert.ToDouble(Console.ReadLine());
        double SalidaF = Math.Round((Entrada - 273.15) * 9 / 5 + 32, 2);
        double SalidaC = Math.Round(Entrada - 273.15, 2);
        Console.Clear();
        Convertor.TemperaturasDesicion(N);
        Console.WriteLine(Entrada + " K equivalen a:");
        Console.WriteLine("Fahrenheit: " + SalidaF + " °F");
        Console.WriteLine("Celsius: " + SalidaC + " °C");
        Console.ReadKey();
    }
}