class Utils
{
    public static string LeerString(string mensaje)
    {
        Console.Write(mensaje);
        return Console.ReadLine() ?? "";
    }

    public static double LeerDouble(string mensaje)
    {
        Console.Write(mensaje);
        double num = 0;
        while (!double.TryParse(Console.ReadLine(), out num))
        {
            MostrarMensaje("Debe de ser un número y este no debe de ser mayor a 2 dígitos", ConsoleColor.DarkRed);
            Console.ResetColor();
        }
        return num;
    }

    public static void MostrarMensajeError(string mensaje)
    {
        MostrarMensaje(mensaje, ConsoleColor.Red);
    }
    public static void MostrarMensaje(string mensaje)
    {
        MostrarMensaje(mensaje, ConsoleColor.Cyan);
    }
    public static void MostrarMensaje(string mensaje, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(mensaje);
        Console.ReadKey();
        Console.ResetColor();
    }
    public static void Repro(string audio)
    {

        audio = $"audios/{audio}";
        System.Diagnostics.Process.Start(@"powershell", $@"-c (New-Object Media.SoundPlayer '{audio}').PlaySync();");

    }
}
